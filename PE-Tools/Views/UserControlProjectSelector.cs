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
    public partial class UserControlProjectSelector : UserControl
    {
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
        {//TODO: get list of folders form config file
            return new List<Folder>() {
                new Folder(@"select"), 
                new Folder(@"c:\Dev\onPrem"), 
                new Folder(@"c:\Test\Repo\onPrem") };
        }
    }
}
