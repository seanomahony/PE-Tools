using PE_Tools.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NLog;
using Microsoft.Data.SqlClient;

namespace PE_Tools.Views
{
    /// <summary>
    /// User control for managing application settings including folders and connection strings.
    /// </summary>
    public partial class AppSettingsView : UserControl
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public AppSettingsView()
        {
            InitializeComponent();
        }

        private void AppSettingsView_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            LoadSettings();
        }

        private void LoadSettings()
        {
            // Load connection string
            txtConnectionString.Text = SettingsManager.GetDatabaseConnectionString();

            // Load config file paths
            txtC1ConfigPath.Text = SettingsManager.GetC1ConfigFilename();
            txtDocConfigPath.Text = SettingsManager.GetDocConfigFilename();
            // Load development folder
            txtDevelopmentFolder.Text = SettingsManager.GetDevelopmentFolder();

            // Load notification duration
            numNotificationDuration.Value = SettingsManager.GetNotificationDuration();
        }

        private void btnBrowseDevFolder_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = "Select development folder",
                ShowNewFolderButton = false
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtDevelopmentFolder.Text = dialog.SelectedPath;
            }
        }

        private void btnBrowseC1_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Title = "Select C1 config file";
            dialog.Filter = "Config Files (*.config;*.xml)|*.config;*.xml|All Files (*.*)|*.*";
            dialog.CheckFileExists = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtC1ConfigPath.Text = dialog.FileName;
            }
        }

        private void btnBrowseDoc_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Title = "Select Doc config file";
            dialog.Filter = "Config Files (*.config;*.xml)|*.config;*.xml|All Files (*.*)|*.*";
            dialog.CheckFileExists = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtDocConfigPath.Text = dialog.FileName;
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            var connectionString = txtConnectionString.Text.Trim();
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Please enter a connection string to test.", "Empty Connection String", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnTestConnection.Enabled = false;
            btnTestConnection.Text = "Testing...";

            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                NotificationManager.Show("Database connection successful!");
                MessageBox.Show("Connection successful!", "Test Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Logger.Info("Connection test successful.");
            }
            catch (Exception ex)
            {
                NotificationManager.Show("Database connection failed", 4);
                MessageBox.Show($"Connection failed: {ex.Message}", "Test Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Error(ex, "Connection test failed.");
            }
            finally
            {
                btnTestConnection.Enabled = true;
                btnTestConnection.Text = "Test Connection";
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                // Save connection string
                SettingsManager.SaveDatabaseConnectionString(txtConnectionString.Text.Trim());

                // Save config file paths
                SettingsManager.SaveC1ConfigFilename(txtC1ConfigPath.Text.Trim());
                SettingsManager.SaveDocConfigFilename(txtDocConfigPath.Text.Trim());
                // Save development folder
                SettingsManager.SaveDevelopmentFolder(txtDevelopmentFolder.Text.Trim());

                // Save notification duration
                SettingsManager.SaveNotificationDuration((int)numNotificationDuration.Value);

                // Notify other components that settings changed
                SettingsManager.OnSettingsChanged();

                NotificationManager.Show("Settings saved successfully!");
                MessageBox.Show("Settings saved successfully!\n\nNote: Restart the application for all changes to take effect.",
                    "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Logger.Info("All settings saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save settings: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Error(ex, "Failed to save settings.");
            }
        }

        private void btnTestNotification_Click(object sender, EventArgs e)
        {
            int duration = (int)numNotificationDuration.Value;
            NotificationManager.Show($"This is a test notification (Duration: {duration} seconds)", duration);
            Logger.Info("Test notification shown with duration: {0} seconds", duration);
        }
    }
}