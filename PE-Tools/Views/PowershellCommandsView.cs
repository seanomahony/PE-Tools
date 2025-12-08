using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using NLog;
using PE_Tools.Models;
using PE_Tools.Theme;

namespace PE_Tools.Views
{
    public partial class PowershellCommandsView : UserControl
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The selected folder, set externally from Form1
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Folder SelectedFolder { get; set; }

        public PowershellCommandsView()
        {
            InitializeComponent();
        }

        private void PowershellCommandsView_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            checkElevatedMode();
        }

        private void ApplyTheme()
        {
            ThemeHelper.ApplyTheme(this);

            ThemeHelper.StyleButton(btnBuildOECore, ButtonStyle.Primary);
            ThemeHelper.StyleButton(btnBuildClickOne, ButtonStyle.Primary);
            ThemeHelper.StyleButton(btnBuildIntegration, ButtonStyle.Primary);
            ThemeHelper.StyleButton(btnBuildWebPortal, ButtonStyle.Primary);
            ThemeHelper.StyleButton(btnBuild, ButtonStyle.Success);

            ThemeHelper.StyleButton(btnRunTestServices, ButtonStyle.Success);
            ThemeHelper.StyleButton(btnRunCommand, ButtonStyle.Success);
            ThemeHelper.StyleButton(btnStop, ButtonStyle.Danger);

            ThemeHelper.StyleTextBox(tbResults, isConsole: true);
        }

        private string RunScript(string script, bool requiresAuth = false, string changeDir = null)
        {
            var sb = new StringBuilder();
            try
            {
                Logger.Debug("Running script: {0} changeDir={1} requiresAuth={2}", script, changeDir, requiresAuth);

                // Use pwsh (PowerShell 7+) if available, fallback to powershell.exe
                string pwshPath = "pwsh";
                string arguments = "-NoProfile -NonInteractive -Command ";

                // Build the command string
                var commandBuilder = new StringBuilder();
                if (requiresAuth)
                {
                    commandBuilder.Append("Set-ExecutionPolicy Unrestricted -Scope Process; ");
                }
                if (!string.IsNullOrEmpty(changeDir))
                {
                    commandBuilder.Append($"cd '{changeDir}'; ");
                }
                commandBuilder.Append(script);

                // Wrap the command in quotes for the process
                arguments += $"\"{commandBuilder}\"";

                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = pwshPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8
                };

                using (var process = System.Diagnostics.Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (!string.IsNullOrWhiteSpace(output))
                        sb.AppendLine(output);
                    if (!string.IsNullOrWhiteSpace(error))
                        sb.AppendLine(error);
                }
            }
            catch (Exception e)
            {
                Logger.Error(e, "Error running script: {0}", script);
                sb.AppendLine(e.Message);
                return sb.ToString();
            }
            if (string.IsNullOrWhiteSpace(sb.ToString()))
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                return $"[{timestamp}] Script executed successfully (no output).";
            }
            return sb.ToString();
        }

        private void ShowMessage(string msg)
        {
            tbResults.Clear();
            tbResults.Text = RunScript(msg);
        }

        private void checkElevatedMode()
        {
            var principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if(!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                ShowMessage("echo \'You need to run this application as administrator to use most powershell tools\'");
            }
        }

        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            tbResults.Clear();

            // Extract embedded PowerShell script to temp file
            string tempScriptPath = Path.Combine(Path.GetTempPath(), "StartServices.ps1");
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("PE_Tools.Resources.StartServices.ps1"))
            using (var fileStream = new FileStream(tempScriptPath, FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fileStream);
            }

            // Unblock the script file
            RunScript($"Unblock-File -Path \"{tempScriptPath}\"");

            // Optionally get folder parameter from UI, fallback to default
            string folderParam = @"Development\onprem";
            if (SelectedFolder != null)
            {
                folderParam = SelectedFolder.FullPath ?? folderParam;
            }

            // Run the script with folder parameter
            string command = $"{tempScriptPath} -folder '{folderParam}'";
            tbResults.Text = RunScript(command, true);

            // Optionally delete the temp file after execution
            try { File.Delete(tempScriptPath); } catch { /* ignore */ }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            tbResults.Clear();
            if (SelectedFolder is null)
            {
                ShowMessage("echo \'Please select a target projectfolder\'");
                return;
            }
            var path = $@"'{SelectedFolder.FullPath}\'";
            //tbResults.Text = RunScript("./start.ps1 -build", true,@"c:\dev\onprem\");
            tbResults.Text = RunScript("./start.ps1 -build", true, path);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tbResults.Clear();

            // Extract embedded PowerShell script to temp file
            string tempScriptPath = Path.Combine(Path.GetTempPath(), "StopServices.ps1");
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("PE_Tools.Resources.StopServices.ps1"))
            using (var fileStream = new FileStream(tempScriptPath, FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fileStream);
            }

            // Unblock and run the script
            RunScript($"Unblock-File -Path \"{tempScriptPath}\"");
            tbResults.Text = RunScript(tempScriptPath, true);

            // Optionally delete the temp file after execution
            try { File.Delete(tempScriptPath); } catch { /* ignore */ }
        }

        private void btnBuildOECore_Click(object sender, EventArgs e)
        {
            tbResults.Clear();
            if (SelectedFolder is null)
            {
                ShowMessage("echo \'Please select a target projectfolder\'");
                return;
            }
            var path = SelectedFolder.FullPath + @"\officeevolve\OECore.sln";
            var command = $"./builder.bat '{path}'";
            tbResults.Text = RunScript(command, true);
        }

        private void btnBuildClickOne_Click(object sender, EventArgs e)
        {
            tbResults.Clear();
            if (SelectedFolder is null)
            {
                ShowMessage("echo \'Please select a target projectfolder\'");
                return;
            }
            var path = SelectedFolder.FullPath + @"\clickonelegal\ClickOneLegal.sln";
            var command = $"./builder.bat '{path}'";
            tbResults.Text = RunScript(command, true);
        }

        private void btnBuildIntegration_Click(object sender, EventArgs e)
        {
            tbResults.Clear();
            if (SelectedFolder is null)
            {
                ShowMessage("echo \'Please select a target projectfolder\'");
                return;
            }
            var path = SelectedFolder.FullPath + @"\integration\Integration.sln";
            var command = $"./builder.bat '{path}'";
            tbResults.Text = RunScript(command, true);
        }

        private void btnBuildWebPortal_Click(object sender, EventArgs e)
        {
            tbResults.Clear();
            if (SelectedFolder is null)
            {
                ShowMessage("echo \'Please select a target projectfolder\'");
                return;
            }
            var path = SelectedFolder.FullPath + @"\";
            //tbResults.Text = RunScript("./start.ps1 -build", true,@"c:\dev\onprem\");
            tbResults.Text = RunScript("./start.ps1 -build -build_type WebPortal", true, path);
        }

        private void btnRunTestServices_Click(object sender, EventArgs e)
        {
            tbResults.Clear();
            if (SelectedFolder is null)
            {
                ShowMessage("echo \'Please select a target projectfolder\'");
                return;
            }
            var project = SelectedFolder.Target;
            tbResults.Text = RunScript($"./RunPE_ServicesOnly_in.ps1 '{project}'", true);
        }
    }
}
