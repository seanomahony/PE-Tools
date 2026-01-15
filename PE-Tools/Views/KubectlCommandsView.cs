using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PE_Tools.Theme;

namespace PE_Tools.Views
{
    public partial class KubectlCommandsView : UserControl
    {
        private const int MaxHistoryItems = 5;

        public KubectlCommandsView()
        {
            InitializeComponent();
            this.Load += KubectlCommandsView_Load;
        }

        private void KubectlCommandsView_Load(object sender, EventArgs e)
        {
            if (this.cbAction.Items.Count > 0)
            {
                this.cbAction.SelectedIndex = 0;
            }

            // Populate Container options
            this.cbContainer.Items.AddRange(new object[] { "documents", "clickone" });
            this.cbContainer.Text = "documents";

            if (!this.cbAction.Items.Contains("Copy To (Windows)"))
            {
                this.cbAction.Items.Insert(1, "Copy To (Windows)");
            }

            LoadHistory(cbNamespace, "kubectl_namespaces");
            LoadHistory(cbPodName, "kubectl_pods");
            LoadHistory(cbSourcePath, "kubectl_sources");
            LoadHistory(cbDestPath, "kubectl_dests");
            LoadHistory(cbContainer, "kubectl_containers"); // Optional: also save container history if user types custom
            
            // Set default pod name if empty
            if (string.IsNullOrWhiteSpace(cbPodName.Text))
            {
                cbPodName.Text = "evolveonprem-0";
            }

            ApplyTheme();
        }
        
        private void LoadHistory(ComboBox comboBox, string key)
        {
            var history = SettingsManager.GetList(key);
            comboBox.Items.Clear();
            if (history.Any())
            {
                comboBox.Items.AddRange(history.ToArray());
                // Don't auto-select the first one unless you want to load state. 
                // User requirement just says "default to evolveonprem-0" for pod, and remember last 5.
                // Usually "remembering" means the dropdown list is populated.
                
                // If we also want to restore the last *selected* value, we could select index 0 if we save Most Recently Used at top.
                // I'll assume MRU at top.
            }
        }
        
        private void SaveHistory(ComboBox comboBox, string key)
        {
            var currentText = comboBox.Text.Trim();
            if (string.IsNullOrEmpty(currentText)) return;

            var history = SettingsManager.GetList(key);
            
            // Remove if exists to move to top
            history.RemoveAll(x => x.Equals(currentText, StringComparison.OrdinalIgnoreCase));
            
            // Insert at top
            history.Insert(0, currentText);
            
            // Truncate
            if (history.Count > MaxHistoryItems)
            {
                history = history.Take(MaxHistoryItems).ToList();
            }
            
            SettingsManager.SaveList(key, history);
            
            // Refresh combo box items
            comboBox.Items.Clear();
            comboBox.Items.AddRange(history.ToArray());
            comboBox.Text = currentText; // Restore text
        }

        private void InputChanged(object sender, EventArgs e)
        {
             // No auto-generation anymore
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateCommand();
            
            // Save history
            SaveHistory(cbNamespace, "kubectl_namespaces");
            SaveHistory(cbPodName, "kubectl_pods");
            SaveHistory(cbSourcePath, "kubectl_sources");
            SaveHistory(cbDestPath, "kubectl_dests");
            SaveHistory(cbContainer, "kubectl_containers");
        }

        public static string SanitizePath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return path;
            }
            // Get invalid chars plus explicitly add double quotes as they are often pasted in but we quote the path ourselves
            var invalidChars = System.IO.Path.GetInvalidPathChars().Concat(new[] { '"' }).ToHashSet();
            return new string(path.Where(ch => !invalidChars.Contains(ch)).ToArray());
        }

        private static string QuotePath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return path;
            }

            return path.Contains(' ') ? $"\"{path}\"" : path;
        }

        private static string FormatRemotePath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return path;
            }

            // Remove drive letter if present
            var cleanPath = System.Text.RegularExpressions.Regex.Replace(path, @"^[a-zA-Z]:", "");

            // Convert backslashes
            cleanPath = cleanPath.Replace('\\', '/');

            // Ensure single quotes
            return $"'{cleanPath.Trim('\'')}'";
        }

        public static string GenerateCommandText(string ns, string pod, string container, string action, string rawSrc, string rawDest)
        {
            var command = "kubectl";
            var src = SanitizePath(rawSrc);
            var dest = SanitizePath(rawDest);
            var preCommand = string.Empty;

            var podRef = string.IsNullOrEmpty(ns) ? pod : $"{ns}/{pod}";

            if (action == "Copy To")
            {
                // check if src is absolute path
                if (!string.IsNullOrEmpty(src) && System.IO.Path.IsPathRooted(src))
                {
                    var dir = System.IO.Path.GetDirectoryName(src);
                    var file = System.IO.Path.GetFileName(src);
                    if (!string.IsNullOrEmpty(dir))
                    {
                        preCommand = $"cd {QuotePath(dir)}{Environment.NewLine}";
                        src = $"./{file}";
                    }
                }

                // Format: kubectl cp <local-src> <namespace>/<pod>:<dest> -c <container>
                if (string.IsNullOrEmpty(pod))
                {
                    return "Pod name required.";
                }

                var podDest = $"{podRef}:{FormatRemotePath(dest)}";
                command += $" cp {QuotePath(src)} {QuotePath(podDest)}";
            }
            else if (action == "Copy To (Windows Container)")
            {
                if (string.IsNullOrEmpty(src)) return "Source path required.";
                if (string.IsNullOrEmpty(dest)) return "Destination path required.";
                if (string.IsNullOrEmpty(pod)) return "Pod name required.";

                // Ensure backslashes for Windows paths
                var winDest = dest.Replace('/', '\\');
                var destDir = System.IO.Path.GetDirectoryName(winDest);

                // 1. Read file to base64 (Local PowerShell)
                var readCommand = $"$b64 = [Convert]::ToBase64String([System.IO.File]::ReadAllBytes(\"{src}\"))";

                // 2. Prepare inner command (Container PowerShell)
                var mkdirCmd = string.IsNullOrEmpty(destDir) ? "" : $"mkdir \"{destDir}\" -Force; ";
                var innerCmd = $"{mkdirCmd}[System.Convert]::FromBase64String($input) | Set-Content -Path \"{winDest}\" -Encoding Byte";

                // 3. Exec with pipe
                var nsArg = string.IsNullOrEmpty(ns) ? "" : $"-n {ns}";
                var containerArg = string.IsNullOrEmpty(container) ? "" : $"-c {container}";

                // Use single quotes for the outer powershell command so local shell doesn't expand $input
                var execCommand = $"$b64 | kubectl exec -i {pod} {nsArg} {containerArg} -- powershell -Command '{innerCmd}'";

                return $"{readCommand}{Environment.NewLine}{execCommand}";
            }
            else if (action == "Copy From")
            {
                // check if dest is absolute path
                if (!string.IsNullOrEmpty(dest) && System.IO.Path.IsPathRooted(dest))
                {
                    var dir = System.IO.Path.GetDirectoryName(dest);
                    var file = System.IO.Path.GetFileName(dest);
                    if (!string.IsNullOrEmpty(dir))
                    {
                        preCommand = $"cd {QuotePath(dir)}{Environment.NewLine}";
                        dest = string.IsNullOrEmpty(file) ? "." : $"./{file}";
                    }
                }

                // Format: kubectl cp <namespace>/<pod>:<src> <local-dest> -c <container>
                if (string.IsNullOrEmpty(pod))
                {
                    return "Pod name required.";
                }

                var podSrc = $"{podRef}:{FormatRemotePath(src)}";
                command += $" cp {QuotePath(podSrc)} {QuotePath(dest)}";
            }
            else
            {
                return "Select an action.";
            }

            if (!string.IsNullOrEmpty(container))
            {
                command += $" -c {container}";
            }

            return preCommand + command;
        }

        private void GenerateCommand()
        {
            var ns = cbNamespace.Text.Trim();
            var pod = cbPodName.Text.Trim();
            var container = cbContainer.Text.Trim();
            var action = cbAction.SelectedItem?.ToString();
            var rawSrc = cbSourcePath.Text.Trim();
            var rawDest = cbDestPath.Text.Trim();

            txtResult.Text = GenerateCommandText(ns, pod, container, action, rawSrc, rawDest);
        }
        
        public void ApplyTheme() 
        {
             ThemeHelper.ApplyTheme(this);
             ThemeHelper.StyleTextBox(txtResult, isConsole: true);
             ThemeHelper.StyleButton(btnGenerate, ButtonStyle.Success);
        }
    }
}
