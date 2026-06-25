using PE_Tools.Models;
using PE_Tools.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using NLog;

namespace PE_Tools.Views
{
    public partial class DatabaseSettingsView : UserControl
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        List<string> c1Databases { get; set; } = new List<string>();
        List<string> docDatabases { get; set; } = new List<string>();
        FileManager? fileManager { get; set; }
        private string developmentPath = string.Empty;
        string? currentView = null;
        private bool databaseSettingsLoaded;

        public DatabaseSettingsView()
        {
            InitializeComponent();
            SettingsManager.SettingsChanged += OnSettingsChanged;
        }

        private void OnSettingsChanged(object? sender, EventArgs e)
        {
            databaseSettingsLoaded = false;
            fileManager = null;
            lblConfigError.Visible = false;
            grpDatabaseSelection.Visible = true;
            grpActions.Visible = true;
            grpOutput.Visible = true;
            DatabaseSettingsView_Load(this, EventArgs.Empty);
        }

        private void ShowConfigError(string message)
        {
            lblConfigError.Text = message;
            lblConfigError.Visible = true;
            grpDatabaseSelection.Visible = false;
            grpActions.Visible = false;
            grpOutput.Visible = false;
        }

        private void activateApplyButton()
        {
            this.saveButton.Enabled = false;
            this.applyButton.Enabled = cbC1DBs.SelectedIndex > 0
                && cbDocDBs.SelectedIndex > 0;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (fileManager == null)
            {
                ShowConfigError("File manager not initialised. Check Settings.");
                return;
            }

            var c1Item = this.cbC1DBs.SelectedItem as DatabaseListItem;
            var docItem = this.cbDocDBs.SelectedItem as DatabaseListItem;

            if (c1Item == null || docItem == null)
            {
                MessageBox.Show("Please select valid databases for both C1 and Doc.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var c1DbName = c1Item.Name;
            var docsDbName = docItem.Name;
            try
            {
                fileManager.UpdateC1File(c1DbName);
                fileManager.UpdateDocFile(docsDbName, c1DbName);
                Logger.Info("Applied database selection: c1={0}, doc={1} for folder={2}", c1DbName, docsDbName, this.developmentPath);
                NotificationManager.Show($"Database settings applied: C1={c1DbName}, Doc={docsDbName}");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error applying database changes");
                MessageBox.Show($"Error applying changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NotificationManager.Show("Failed to apply database settings", 4);
                return;
            }

            this.saveButton.Enabled = true;
            this.applyButton.Enabled = false;

            // Reload the current view if one is active
            if (currentView == "c1")
            {
                btnViewC1config_Click(null, null);
            }
            else if (currentView == "doc")
            {
                btnViewDocConfig_Click(null, null);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (fileManager == null)
            {
                ShowConfigError("File manager not initialised. Check Settings.");
                return;
            }

            try
            {
                fileManager.SaveC1File();
                fileManager.SaveDocFile();
                this.saveButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save configuration files: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NotificationManager.Show("Failed to save configuration files", 4);
            }
        }

        private async void DatabaseSettingsView_Load(object sender, EventArgs e)
        {
            if (databaseSettingsLoaded)
            {
                return;
            }

            databaseSettingsLoaded = true;

            developmentPath = SettingsManager.GetDevelopmentFolder();

            if (string.IsNullOrWhiteSpace(developmentPath))
            {
                ShowConfigError("Development folder is not configured. Go to Settings and configure your paths first.");
                return;
            }

            try
            {
                fileManager = new FileManager(developmentPath);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "FileManager initialisation failed");
                ShowConfigError($"Could not load configuration files: {ex.Message}");
                return;
            }

            var database = new Database();
            c1Databases = await database.GetSelectedDatabasesAsync("_c1");
            docDatabases = await database.GetSelectedDatabasesAsync("_doc");

            this.outputRichTextBox.Visible = true;

            this.cbC1DBs.DataSource = c1Databases.Select((d, i) => new DatabaseListItem(d, i + 1)).ToList();
            this.cbC1DBs.ValueMember = "ID";
            this.cbC1DBs.DisplayMember = "Name";
            this.cbC1DBs.SelectedIndex = 0;

            this.cbDocDBs.DataSource = docDatabases.Select((d, i) => new DatabaseListItem(d, i + 1)).ToList();
            this.cbDocDBs.ValueMember = "ID";
            this.cbDocDBs.DisplayMember = "Name";
            this.cbDocDBs.SelectedIndex = 0;
        }

        private string GetFormattedXml(XmlDocument doc)
        {
            using (var stringWriter = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
                {
                    doc.WriteTo(xmlWriter);
                }
                return stringWriter.ToString();
            }
        }

        private void HighlightUpdatedSection(string formattedXml, string key)
        {
            string[] lines = formattedXml.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            int lineIndex = Array.FindIndex(lines, l => l.Contains(key));
            if (lineIndex >= 0)
            {
                string line = lines[lineIndex];
                int start = line.IndexOf("Database=");
                if (start >= 0)
                {
                    int end = line.IndexOf(';', start);
                    if (end < 0) end = line.Length;
                    // position in whole text
                    int globalStart = 0;
                    for (int i = 0; i < lineIndex; i++)
                    {
                        globalStart += lines[i].Length + Environment.NewLine.Length;
                    }
                    globalStart += start;
                    int length = end - start;
                    this.outputRichTextBox.Select(globalStart, length);
                    this.outputRichTextBox.ScrollToCaret();
                }
            }
        }

        private void cbC1DBs_SelectedIndexChanged(object sender, EventArgs e)
        {
            activateApplyButton();
        }

        private void cbDocDBs_SelectedIndexChanged(object sender, EventArgs e)
        {
            activateApplyButton();
        }

        private void btnViewC1config_Click(object? sender, EventArgs? e)
        {
            if (fileManager == null)
            {
                ShowConfigError("File manager not initialised. Check Settings.");
                return;
            }

            currentView = "c1";
            string formattedXml = GetFormattedXml(fileManager.c1Config);
            this.outputRichTextBox.Text = formattedXml;
            HighlightUpdatedSection(formattedXml, "connectionString");
        }

        private void btnViewDocConfig_Click(object? sender, EventArgs? e)
        {
            if (fileManager == null)
            {
                ShowConfigError("File manager not initialised. Check Settings.");
                return;
            }

            currentView = "doc";
            string formattedXml = GetFormattedXml(fileManager.docConfig);
            this.outputRichTextBox.Text = formattedXml;
            HighlightUpdatedSection(formattedXml, "cms.database.connection");
        }

        private void BtnOpenC1config_Click(object sender, System.EventArgs e)
        {
            if (fileManager == null)
            {
                ShowConfigError("File manager not initialised. Check Settings.");
                return;
            }

            fileManager.OpenC1File();
        }

        private void BtnOpenDocConfig_Click(object sender, System.EventArgs e)
        {
            if (fileManager == null)
            {
                ShowConfigError("File manager not initialised. Check Settings.");
                return;
            }

            fileManager.OpenDocFile();
        }
    }
}
