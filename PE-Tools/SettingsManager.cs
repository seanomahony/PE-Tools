using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using NLog;

namespace PE_Tools
{
    /// <summary>
    /// Manages reading and writing application settings to App.config.
    /// </summary>
    public static class SettingsManager
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Gets the list of configured folders from App.config.
        /// </summary>
        public static List<string> GetFolders()
        {
            var folderSettings = ConfigurationManager.AppSettings["folders"];
            if (string.IsNullOrEmpty(folderSettings))
            {
                return new List<string>();
            }
            return folderSettings.Split(',')
                                 .Select(f => f.Trim())
                                 .Where(f => !string.IsNullOrEmpty(f))
                                 .ToList();
        }

        /// <summary>
        /// Saves the list of folders to App.config.
        /// </summary>
        public static void SaveFolders(List<string> folders)
        {
            var folderValue = string.Join(",", folders.Where(f => !string.IsNullOrWhiteSpace(f)));
            UpdateAppSetting("folders", folderValue);
            Logger.Info("Saved folders: {0}", folderValue);
        }

        /// <summary>
        /// Gets the database connection string from App.config.
        /// </summary>
        public static string GetDatabaseConnectionString()
        {
            return ConfigurationManager.AppSettings["databaseConnectionString"] ?? string.Empty;
        }

        /// <summary>
        /// Saves the database connection string to App.config.
        /// </summary>
        public static void SaveDatabaseConnectionString(string connectionString)
        {
            UpdateAppSetting("databaseConnectionString", connectionString);
            Logger.Info("Saved database connection string.");
        }

        /// <summary>
        /// Gets the C1 config filename from App.config.
        /// </summary>
        public static string GetC1ConfigFilename()
        {
            return ConfigurationManager.AppSettings["c1ConfigFilename"] ?? string.Empty;
        }

        /// <summary>
        /// Saves the C1 config filename to App.config.
        /// </summary>
        public static void SaveC1ConfigFilename(string filename)
        {
            UpdateAppSetting("c1ConfigFilename", filename);
            Logger.Info("Saved C1 config filename: {0}", filename);
        }

        /// <summary>
        /// Gets the Doc config filename from App.config.
        /// </summary>
        public static string GetDocConfigFilename()
        {
            return ConfigurationManager.AppSettings["docConfigFilename"] ?? string.Empty;
        }

        /// <summary>
        /// Saves the Doc config filename to App.config.
        /// </summary>
        public static void SaveDocConfigFilename(string filename)
        {
            UpdateAppSetting("docConfigFilename", filename);
            Logger.Info("Saved Doc config filename: {0}", filename);
        }

        /// <summary>
        /// Updates an app setting in App.config and refreshes the configuration.
        /// </summary>
        private static void UpdateAppSetting(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;

            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Event raised when settings are changed.
        /// </summary>
        public static event EventHandler? SettingsChanged;

        /// <summary>
        /// Raises the SettingsChanged event.
        /// </summary>
        public static void OnSettingsChanged()
        {
            SettingsChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}