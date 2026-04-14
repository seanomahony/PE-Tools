using PE_Tools.Theme;
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

            ApplyTheme();
            LoadSettings();
        }

        private void ApplyTheme()
        {
            ThemeHelper.ApplyTheme(this);

            // Style title
            lblTitle.Font = ThemeHelper.TitleFont;
            lblTitle.ForeColor = ThemeHelper.PrimaryText;

            // Style section headers
            lblFoldersSection.Font = ThemeHelper.HeaderFont;
            lblFoldersSection.ForeColor = ThemeHelper.SecondaryText;
            lblConnectionSection.Font = ThemeHelper.HeaderFont;
            lblConnectionSection.ForeColor = ThemeHelper.SecondaryText;
            lblConfigPathsSection.Font = ThemeHelper.HeaderFont;
            lblConfigPathsSection.ForeColor = ThemeHelper.SecondaryText;

            // Style buttons
            ThemeHelper.StyleButton(btnAddFolder, ButtonStyle.Primary);
            ThemeHelper.StyleButton(btnRemoveFolder, ButtonStyle.Danger);
            ThemeHelper.StyleButton(btnBrowseFolder, ButtonStyle.Default);
            ThemeHelper.StyleButton(btnTestConnection, ButtonStyle.Default);
            ThemeHelper.StyleButton(btnSaveAll, ButtonStyle.Success);

            // Style listbox
            lstFolders.BackColor = ThemeHelper.SecondaryBackground;
            lstFolders.ForeColor = ThemeHelper.PrimaryText;
            lstFolders.BorderStyle = BorderStyle.FixedSingle;

            // Style textboxes
            ThemeHelper.StyleTextBox(txtNewFolder);
            ThemeHelper.StyleTextBox(txtConnectionString);
            ThemeHelper.StyleTextBox(txtC1ConfigPath);
            ThemeHelper.StyleTextBox(txtDocConfigPath);
        }

        private void LoadSettings()
        {
            // Load folders
            lstFolders.Items.Clear();
            var folders = SettingsManager.GetFolders();
            foreach (var folder in folders)
            {
                lstFolders.Items.Add(folder);
            }

            // Load connection string
            txtConnectionString.Text = SettingsManager.GetDatabaseConnectionString();

            // Load config file paths
            txtC1ConfigPath.Text = SettingsManager.GetC1ConfigFilename();
            txtDocConfigPath.Text = SettingsManager.GetDocConfigFilename();

            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            btnRemoveFolder.Enabled = lstFolders.SelectedIndex >= 0;
            btnAddFolder.Enabled = !string.IsNullOrWhiteSpace(txtNewFolder.Text);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            var folderPath = txtNewFolder.Text.Trim();
            if (string.IsNullOrEmpty(folderPath))
            {
                return;
            }

            if (!Directory.Exists(folderPath))
            {
                var result = MessageBox.Show(
                    $"The folder '{folderPath}' does not exist. Add it anyway?",
                    "Folder Not Found",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            if (lstFolders.Items.Contains(folderPath))
            {
                MessageBox.Show("This folder is already in the list.", "Duplicate Folder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lstFolders.Items.Add(folderPath);
            txtNewFolder.Clear();
            UpdateButtonStates();
            Logger.Info("Added folder: {0}", folderPath);
        }

        private void btnRemoveFolder_Click(object sender, EventArgs e)
        {
            if (lstFolders.SelectedIndex >= 0)
            {
                var removedFolder = lstFolders.SelectedItem?.ToString();
                lstFolders.Items.RemoveAt(lstFolders.SelectedIndex);
                UpdateButtonStates();
                Logger.Info("Removed folder: {0}", removedFolder);
            }
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = "Select a project folder",
                ShowNewFolderButton = false
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtNewFolder.Text = dialog.SelectedPath;
                UpdateButtonStates();
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
                MessageBox.Show("Connection successful!", "Test Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Logger.Info("Connection test successful.");
            }
            catch (Exception ex)
            {
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
                // Save folders
                var folders = lstFolders.Items.Cast<string>().ToList();
                SettingsManager.SaveFolders(folders);

                // Save connection string
                SettingsManager.SaveDatabaseConnectionString(txtConnectionString.Text.Trim());

                // Save config file paths
                SettingsManager.SaveC1ConfigFilename(txtC1ConfigPath.Text.Trim());
                SettingsManager.SaveDocConfigFilename(txtDocConfigPath.Text.Trim());

                // Notify other components that settings changed
                SettingsManager.OnSettingsChanged();

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

        private void lstFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void txtNewFolder_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void txtNewFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnAddFolder.Enabled)
            {
                btnAddFolder_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}