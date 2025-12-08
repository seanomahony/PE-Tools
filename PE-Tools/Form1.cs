using PE_Tools.Models;
using PE_Tools.Theme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Disable tabs that require folder selection initially
            tabPageDatabases.Enabled = false;
            tabPagePowershell.Enabled = false;
            
            // Set up the callback for when a folder is selected
            projectSelector.Callback = OnFolderSelected;
        }

        private void OnFolderSelected()
        {
            var selectedFolder = projectSelector.SelectedFolder;
            
            if (selectedFolder != null)
            {
                // Enable the tabs that depend on folder selection
                tabPageDatabases.Enabled = true;
                tabPagePowershell.Enabled = true;
                
                // Pass the selected folder to the views
                databaseSettingsView1.SelectedFolder = selectedFolder;
                powershellCommandsView1.SelectedFolder = selectedFolder;
                
                // Notify DatabaseSettingsView that the folder changed
                databaseSettingsView1.OnFolderChanged();
            }
            else
            {
                // Disable the tabs if no folder is selected
                tabPageDatabases.Enabled = false;
                tabPagePowershell.Enabled = false;
                
                databaseSettingsView1.SelectedFolder = null;
                powershellCommandsView1.SelectedFolder = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            ThemeHelper.ApplyTheme(this);
            ThemeHelper.StyleTabControl(tabControl1);
        }
    }
}
