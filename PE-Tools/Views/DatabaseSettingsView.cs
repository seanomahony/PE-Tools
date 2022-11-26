using PE_Tools.Models;
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
        public List<string> FolderNames { get; set; }

        List<string> c1Databases { get; set; }
        List<string> docDatabases { get; set; }
        FileManager fileManager { get; set; }

        public DatabaseSettingsView()
        {
            InitializeComponent();

        }

        private void activateApplyButton()
        {
            this.saveButton.Enabled = false;
            this.outputListBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.applyButton.Enabled = this.userControlProjectSelector1.SelectedFolder != null
                && cbC1DBs.SelectedIndex > 0
                && cbDocDBs.SelectedIndex > 0;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            fileManager.UpdateC1File((this.cbC1DBs.SelectedItem as DatabaseListItem).Name);
            fileManager.UpdateDocFile((this.cbDocDBs.SelectedItem as DatabaseListItem).Name);

            this.outputListBox.DataSource = null;
            this.outputListBox.BackColor = System.Drawing.SystemColors.Info;
            this.saveButton.Enabled = true;
            this.applyButton.Enabled = false;
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
                    MessageBox.Show("Files Updated OK", $"Database updated for {this.userControlProjectSelector1.SelectedFolder.FullPath}");
                }
            }
        }

        private void DatabaseSettingsView_Load(object sender, EventArgs e)
        {
            this.userControlProjectSelector1.FolderNames = FolderNames;
            this.userControlProjectSelector1.Callback = FolderSelectedIndexChanged;
            var database = new Database();
            c1Databases = database.GetSelectedDatabases("_c1");
            docDatabases = database.GetSelectedDatabases("_doc");

            this.outputListBox.Visible = true;

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

        private List<Folder> getFolders()
        {//TODO: get list of folders form config file
            return new List<Folder>() { new Folder(@"select"), new Folder(@"c:\Dev\onPrem"), new Folder(@"c:\Test\Repo\onPrem") };
        }

        private void FolderSelectedIndexChanged()
        {
            if(this.userControlProjectSelector1.SelectedFolder == null)
            {
                this.btnViewC1config.Enabled = this.btnViewDocConfig.Enabled = false;
                return;
            }
            fileManager = new FileManager(this.userControlProjectSelector1.SelectedFolder.FullPath);
            this.btnViewC1config.Enabled = this.btnViewDocConfig.Enabled = true;
            activateApplyButton();
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
            this.outputListBox.DataSource = fileManager.c1Config;
        }

        private void btnViewDocConfig_Click(object sender, EventArgs e)
        {
            this.outputListBox.DataSource = fileManager.docConfig;
        }
    }
}
