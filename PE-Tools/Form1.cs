using PE_Tools.Notifications;
using System;
using System.Windows.Forms;

namespace PE_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the notification manager
            NotificationManager.Initialize(this);
        }
    }
}
