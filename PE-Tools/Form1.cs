using PE_Tools.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
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
            this.powershellCommandsView1.Visible = false; ;
            this.databaseSettingsView1.Visible = false;
            ListItem.CurrentIndex = 1;
            this.cbViews.DataSource = getViewItems();
            this.cbViews.ValueMember = "ID";
            this.cbViews.DisplayMember = "Name";
            this.cbViews.SelectedIndex = 0;
        }

        private List<ListItem> getViewItems()
        {//TODO: get list of folders form config file
            return new List<ListItem>() { new ListItem(@"select"), new ListItem(@"Databases"), new ListItem(@"Powershell") };
        }
        private void cbViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbViews.SelectedIndex < 1)
            {
                return;
            }
            var viewName = (this.cbViews.SelectedItem as ListItem).Name;

            if (viewName == "Powershell")
            {
                this.powershellCommandsView1.Visible = true;
                this.databaseSettingsView1.Visible = false;
            }
            else if (viewName == "Databases")
            {
                this.powershellCommandsView1.Visible = false;
                this.databaseSettingsView1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var folderSettings = ConfigurationSettings.AppSettings["folders"];
            if (!string.IsNullOrEmpty(folderSettings))
            {
                var folders = folderSettings.Split(',').ToList();
                if (folders.Count > 0)
                {
                    this.powershellCommandsView1.FolderNames = folders;
                    this.databaseSettingsView1.FolderNames = folders;
                }
            }
        }
    }
}
