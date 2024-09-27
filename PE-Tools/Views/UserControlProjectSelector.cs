using PE_Tools.Models;
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

namespace PE_Tools.Views
{
    public partial class UserControlProjectSelector : UserControl
    {
        public delegate void FolderSelectedNotification();

        public FolderSelectedNotification Callback { get; set; }
        public List<string> FolderNames { get; set; }
        public Folder SelectedFolder { get; set; }
        public UserControlProjectSelector()
        {
            InitializeComponent();
            SelectedFolder = null;
        }

        private void cbFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFolders.SelectedIndex < 1)
            {
                this.SelectedFolder = null;
                return;
            }
            this.SelectedFolder = this.cbFolders.SelectedItem as Folder;

            if(this.Callback != null)
            {
                Callback();
            }
        }

        private void userControlProjectSelector_Load(object sender, EventArgs e)
        {
            var folders = getFolders();
            this.cbFolders.DataSource = folders;
            this.cbFolders.ValueMember = "ID";
            this.cbFolders.DisplayMember = "FullPath";
            this.cbFolders.SelectedIndex = 0;
        }

        private List<Folder> getFolders()
        {
            var folderSettings = ConfigurationManager.AppSettings["folders"];
            if (!string.IsNullOrEmpty(folderSettings))
            {
                FolderNames = folderSettings.Split(',').ToList();

                if (FolderNames != null && FolderNames.Any())
                {
                    var folders = new List<Folder>()
                    {
                        new Folder(@"select")
                    };
                    FolderNames.ForEach(f => folders.Add(new Folder(f)));
                    return folders;
                }
             }
            
            return new List<Folder>() {
                new Folder(@"select"), 
                new Folder(@"c:\Dev\onPrem"), 
                new Folder(@"c:\Test\Repo\onPrem") };
        }
    }
}
