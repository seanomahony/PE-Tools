using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_Tools.Views
{
    public partial class PowershellCommandsView : UserControl
    {
        public PowershellCommandsView()
        {
            InitializeComponent();
        }

        private string RunScript(string script)
        {
            var sb = new StringBuilder();
            try
            {
                var runspace = RunspaceFactory.CreateRunspace();
                runspace.Open();
                var pipeline = runspace.CreatePipeline();
                pipeline.Commands.AddScript(script);
                pipeline.Commands.Add("Out-String");
                var results = pipeline.Invoke();
                runspace.Close();

                foreach (var obj in results)
                {
                    sb.AppendLine(obj.ToString());
                }
            }
            catch(Exception e)
            {
                sb.AppendLine(e.Message);
                return sb.ToString();
            }
            return sb.ToString();
        }

        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            tbResults.Clear();
            tbResults.Text = RunScript(tbCommand.Text);
        }

        private void tbCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                tbResults.Clear();
                tbResults.Text = RunScript(tbCommand.Text);
            }
        }
    }
}
