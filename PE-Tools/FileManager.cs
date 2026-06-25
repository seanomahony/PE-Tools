using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using NLog;
using PE_Tools.Notifications;

namespace PE_Tools
{
    public class FileManager
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public XmlDocument c1Config { get; set; }
        public XmlDocument docConfig { get; set; }

        string c1Path { get; set; }
        string docPath { get; set; }

        string c1ConfigFilename;
        string docConfigFilename;

        public FileManager(string prefix)
        {
            if (prefix == null)
            {
                throw new ArgumentNullException(nameof(prefix));
            }

            prefix = prefix.Trim();
            if (string.IsNullOrEmpty(prefix))
            {
                Logger.Error("Prefix is empty.");
                throw new ArgumentException("Prefix must not be empty.", nameof(prefix));
            }

            try
            {
                // Normalize the prefix to a full path
                prefix = Path.GetFullPath(prefix);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Invalid prefix path: {0}", prefix);
                throw;
            }

            c1ConfigFilename = ConfigurationManager.AppSettings["c1ConfigFilename"];
            if (string.IsNullOrEmpty(c1ConfigFilename))
            {
                Logger.Error("C1 config filename not found in app settings.");
                throw new ConfigurationErrorsException("C1 config filename not found in app settings.");
            }

            docConfigFilename = ConfigurationManager.AppSettings["docConfigFilename"];
            if (string.IsNullOrEmpty(docConfigFilename))
            {
                Logger.Error("Doc config filename not found in app settings.");
                throw new ConfigurationErrorsException("Doc config filename not found in app settings.");
            }

            // Trim and sanitize filenames so leading directory separators won't make Path.Combine ignore prefix
            c1ConfigFilename = c1ConfigFilename.Trim();
            docConfigFilename = docConfigFilename.Trim();

            // If the filename is an absolute path, use it as-is; otherwise combine with the normalized prefix.
            if (Path.IsPathRooted(c1ConfigFilename))
            {
                c1Path = Path.GetFullPath(c1ConfigFilename);
            }
            else
            {
                c1Path = Path.Combine(prefix, c1ConfigFilename.TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));
            }

            if (!File.Exists(c1Path))
            {
                Logger.Error("C1 configuration file not found: {0}", c1Path);
                throw new FileNotFoundException($"C1 configuration file not found: {c1Path}");
            }

            c1Config = new XmlDocument();
            c1Config.Load(c1Path);

            if (Path.IsPathRooted(docConfigFilename))
            {
                docPath = Path.GetFullPath(docConfigFilename);
            }
            else
            {
                docPath = Path.Combine(prefix, docConfigFilename.TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));
            }

            if (!File.Exists(docPath))
            {
                Logger.Error("Doc configuration file not found: {0}", docPath);
                throw new FileNotFoundException($"Doc configuration file not found: {docPath}");
            }

            docConfig = new XmlDocument();
            docConfig.Load(docPath);

            Logger.Info("Loaded configuration files from {0}", prefix);
        }

        public void UpdateC1File(string database)
        {
            var node = c1Config.SelectSingleNode("//connectionStrings/add/@connectionString");
            if (node == null)
            {
                Logger.Error("Connection string not found in C1 configuration file.");
                throw new InvalidOperationException("Connection string not found in C1 configuration file.");
            }

            string connStr = node.Value ?? string.Empty;
            var parts = connStr.Split(new[] { ';' }, StringSplitOptions.None).ToList();
            for (var i = 0; i < parts.Count; i++)
            {
                if (parts[i].Trim().StartsWith("Database=", StringComparison.OrdinalIgnoreCase))
                {
                    parts[i] = "Database=" + database;
                    break;
                }
            }
            node.Value = string.Join(";", parts);

            Logger.Info("Updated C1 config database to {0}", database);
        }

        public void SaveC1File()
        {
            c1Config.Save(c1Path);
            Logger.Info("Saved C1 config to {0}", c1Path);
            NotificationManager.Show("C1 config saved successfully");
        }

        public void UpdateDocFile(string docsDb, string c1Db)
        {
            // Helper to replace either "Database=" or "Initial Catalog=" in a connection string's parts
            void ReplaceDatabaseToken(List<string> parts, string newDb)
            {
                for (int i = 0; i < parts.Count; i++)
                {
                    var partTrim = parts[i].Trim();
                    if (partTrim.StartsWith("Database=", StringComparison.OrdinalIgnoreCase) || partTrim.StartsWith("Initial Catalog=", StringComparison.OrdinalIgnoreCase))
                    {
                        // Preserve the form used in the original part (use the same key casing as the existing part)
                        var key = parts[i].Substring(0, parts[i].IndexOf('=') + 1);
                        parts[i] = key + newDb;
                        break;
                    }
                }
            }

            var node = docConfig.SelectSingleNode("//appSettings/add[@key='cms.database.connection']/@value");
            if (node != null)
            {
                var connStr = node.Value;
                var parts = connStr.Split(new[] { ';' }, StringSplitOptions.None).ToList();
                ReplaceDatabaseToken(parts, docsDb);
                node.Value = string.Join(";", parts);
            }

            node = docConfig.SelectSingleNode("//appSettings/add[@key='cms.c1.database.connection']/@value");
            if (node != null)
            {
                string connStr = node.Value ?? string.Empty;
                var parts = connStr.Split(new[] { ';' }, StringSplitOptions.None).ToList();
                ReplaceDatabaseToken(parts, c1Db);
                node.Value = string.Join(";", parts);
            }

            Logger.Info("Updated Doc config databases: docs={0} c1={1}", docsDb, c1Db);
        }

        public void SaveDocFile()
        {
            docConfig.Save(docPath);
            Logger.Info("Saved Doc config to {0}", docPath);
            NotificationManager.Show("Doc config saved successfully");
        }

        public void OpenC1File()
        {
            OpenFile(c1Path);
        }

        public void OpenDocFile()
        {
            OpenFile(docPath);
        }

        private void OpenFile(string path)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true
                });
                Logger.Info("Opened file: {0}", path);
            }
            catch (Exception e)
            {
                Logger.Error(e, "Failed to open file: {0}", path);
                MessageBox.Show($"Failed to open file: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}