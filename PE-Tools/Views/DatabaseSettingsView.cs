using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_Tools.Views
{
    public partial class DatabaseSettingsView : UserControl
    {
        List<string> folders { get; set; }
        List<string> c1Databases { get; set; }
        List<string> docDatabases { get; set; }
        FileManager fileManager { get; set; }

        public DatabaseSettingsView()
        {
            InitializeComponent();
            folders = new List<string>
            {
                @"c:\Dev\onPrem",
                @"c:\Test\Repo\onPrem"
            };

            var database = new Database();
            c1Databases = database.GetSelectedDatabases("_c1");
            docDatabases = database.GetSelectedDatabases("_doc");

            this.folderListBox.DataSource = folders;
            this.c1ListBox.DataSource = c1Databases;
            this.docListBox.DataSource = docDatabases;

            this.outputListBox.Visible = true;
        }

        private void folderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.folderTextBox.Text = this.folderListBox.Text;
            fileManager = new FileManager(this.folderTextBox.Text);
            activateApplyButton();
        }

        private void activateApplyButton()
        {
            this.saveButton.Enabled = false;
            this.outputListBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.applyButton.Enabled = !string.IsNullOrEmpty(this.folderTextBox.Text)
                && !string.IsNullOrEmpty(this.c1TextBox.Text)
                && !string.IsNullOrEmpty(this.docTextBox.Text);
            //this.outputListBox.Visible = !this.applyButton.Enabled;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            fileManager.UpdateC1File(this.c1TextBox.Text);
            fileManager.UpdateDocFile(this.docTextBox.Text);

            this.outputListBox.DataSource = null;
            this.outputListBox.BackColor = System.Drawing.SystemColors.Info;
            this.saveButton.Enabled = true;
            this.applyButton.Enabled = false;
        }

        private void docListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.docTextBox.Text = this.docListBox.Text;
            activateApplyButton();
        }

        private void c1ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.c1TextBox.Text = this.c1ListBox.Text;
            activateApplyButton();
        }

        private void docTextBox_Click(object sender, EventArgs e)
        {
            if (fileManager != null)
            {
                this.outputListBox.DataSource = fileManager.docConfig;
            }
        }

        private void c1TextBox_Click(object sender, EventArgs e)
        {
            if (fileManager != null)
            {
                this.outputListBox.DataSource = fileManager.c1Config;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (fileManager != null)
            {
                if (fileManager.SaveC1File() && fileManager.SaveDocFile())
                {
                    MessageBox.Show("Files Updated OK", $"Database updated for {this.folderTextBox.Text}");
                }
            }
        }
    }
}
