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
        /// Gets the development folder path from App.config. If not present, returns the default path.
        /// </summary>
        public static string GetDevelopmentFolder()
        {
            return ConfigurationManager.AppSettings["developmentFolder"] ?? @"C:\Development\onprem";
        }

        /// <summary>
        /// Saves the development folder path to App.config.
        /// </summary>
        public static void SaveDevelopmentFolder(string path)
        {
            UpdateAppSetting("developmentFolder", path ?? string.Empty);
            Logger.Info("Saved development folder: {0}", path);
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
        /// Gets the notification duration in seconds from App.config.
        /// </summary>
        public static int GetNotificationDuration()
        {
            var value = ConfigurationManager.AppSettings["notificationDurationSeconds"];
            if (int.TryParse(value, out int duration) && duration > 0)
            {
                return duration;
            }
            return 2; // Default to 2 seconds
        }

        /// <summary>
        /// Saves the notification duration in seconds to App.config.
        /// </summary>
        public static void SaveNotificationDuration(int durationSeconds)
        {
            if (durationSeconds < 1)
            {
                throw new ArgumentException("Duration must be at least 1 second.", nameof(durationSeconds));
            }

            UpdateAppSetting("notificationDurationSeconds", durationSeconds.ToString());
            Logger.Info("Saved notification duration: {0} seconds", durationSeconds);
        }

        /// <summary>
        /// Gets a list of strings from App.config using pipe separator.
        /// </summary>
        public static List<string> GetList(string key)
        {
            var value = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrEmpty(value)) return new List<string>();
            return value.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        /// <summary>
        /// Saves a list of strings to App.config using pipe separator.
        /// </summary>
        public static void SaveList(string key, List<string> list)
        {
            var value = string.Join("|", list.Where(s => !string.IsNullOrWhiteSpace(s)));
            UpdateAppSetting(key, value);
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