using PE_Tools.Models;
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

        List<string> c1Databases { get; set; }
        List<string> docDatabases { get; set; }
        FileManager fileManager { get; set; }
        string currentView = null;

        /// <summary>
        /// The selected folder, set externally from Form1
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Folder SelectedFolder { get; set; }

        public DatabaseSettingsView()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Called when the folder selection changes from Form1
        /// </summary>
        public void OnFolderChanged()
        {
            FolderSelectedIndexChanged();
        }

        private void activateApplyButton()
        {
            this.saveButton.Enabled = false;
            this.outputRichTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.applyButton.Enabled = this.SelectedFolder != null
                && cbC1DBs.SelectedIndex > 0
                && cbDocDBs.SelectedIndex > 0;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
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
                Logger.Info("Applied database selection: c1={0}, doc={1} for folder={2}", c1DbName, docsDbName, this.SelectedFolder.FullPath);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error applying database changes");
                MessageBox.Show($"Error applying changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.outputRichTextBox.BackColor = System.Drawing.SystemColors.Info;
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

        private void docTextBox_Click(object sender, EventArgs e)
        {
            if (fileManager != null)
            {
                currentView = "doc";
                string formattedXml = GetFormattedXml(fileManager.docConfig);
                this.outputRichTextBox.Text = formattedXml;
                HighlightUpdatedSection(formattedXml, "cms.database.connection");
            }
        }

        private void c1TextBox_Click(object sender, EventArgs e)
        {
            if (fileManager != null)
            {
                currentView = "c1";
                string formattedXml = GetFormattedXml(fileManager.c1Config);
                this.outputRichTextBox.Text = formattedXml;
                HighlightUpdatedSection(formattedXml, "connectionString");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (fileManager != null)
            {
                try
                {
                    fileManager.SaveC1File();
                    fileManager.SaveDocFile();
                    MessageBox.Show("Files Updated OK", $"Database updated for {this.SelectedFolder.FullPath}");
                    // After save, reflect the saved state
                    this.saveButton.Enabled = false;
                    this.outputRichTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to save configuration files: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void DatabaseSettingsView_Load(object sender, EventArgs e)
        {
            var database = new Database();
            c1Databases = await database.GetSelectedDatabasesAsync("_c1");
            docDatabases = await database.GetSelectedDatabasesAsync("_doc");

            this.outputRichTextBox.Visible = true;

            DatabaseListItem.CurrentIndex = 1;
            this.cbC1DBs.DataSource = c1Databases.Select(d => new DatabaseListItem(d)).ToList();
            this.cbC1DBs.ValueMember = "ID";
            this.cbC1DBs.DisplayMember = "Name";
            this.cbC1DBs.SelectedIndex = 0;

            DatabaseListItem.CurrentIndex = 1;
            this.cbDocDBs.DataSource = docDatabases.Select(d => new DatabaseListItem(d)).ToList();
            this.cbDocDBs.ValueMember = "ID";
            this.cbDocDBs.DisplayMember = "Name";
            this.cbDocDBs.SelectedIndex = 0;

            this.btnViewC1config.Enabled = this.btnViewDocConfig.Enabled = false;
        }

        private void FolderSelectedIndexChanged()
        {
            if (this.SelectedFolder == null)
            {
                this.btnViewC1config.Enabled = this.btnViewDocConfig.Enabled = false;
                return;
            }

            try
            {
                fileManager = new FileManager(this.SelectedFolder.FullPath);
                this.btnViewC1config.Enabled = this.btnViewDocConfig.Enabled = true;
                activateApplyButton();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error loading configuration files for folder {0}", this.SelectedFolder?.FullPath);
                MessageBox.Show($"Error loading configuration files: {ex.Message}", "File Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnViewC1config.Enabled = this.btnViewDocConfig.Enabled = false;
            }
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

        private void btnViewC1config_Click(object sender, EventArgs e)
        {
            currentView = "c1";
            string formattedXml = GetFormattedXml(fileManager.c1Config);
            this.outputRichTextBox.Text = formattedXml;
            HighlightUpdatedSection(formattedXml, "connectionString");
        }

        private void btnViewDocConfig_Click(object sender, EventArgs e)
        {
            currentView = "doc";
            string formattedXml = GetFormattedXml(fileManager.docConfig);
            this.outputRichTextBox.Text = formattedXml;
            HighlightUpdatedSection(formattedXml, "cms.database.connection");
        }
    }
}
