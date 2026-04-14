namespace PE_Tools.Views
{
    partial class PowershellCommandsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBuildCommands = new System.Windows.Forms.GroupBox();
            btnBuildOECore = new System.Windows.Forms.Button();
            btnBuildClickOne = new System.Windows.Forms.Button();
            btnBuildIntegration = new System.Windows.Forms.Button();
            btnBuildWebPortal = new System.Windows.Forms.Button();
            btnBuild = new System.Windows.Forms.Button();
            grpRunCommands = new System.Windows.Forms.GroupBox();
            btnRunTestServices = new System.Windows.Forms.Button();
            btnRunCommand = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            grpOutput = new System.Windows.Forms.GroupBox();
            tbResults = new System.Windows.Forms.TextBox();
            grpBuildCommands.SuspendLayout();
            grpRunCommands.SuspendLayout();
            grpOutput.SuspendLayout();
            SuspendLayout();
            // 
            // grpBuildCommands
            // 
            grpBuildCommands.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            grpBuildCommands.Controls.Add(btnBuildOECore);
            grpBuildCommands.Controls.Add(btnBuildClickOne);
            grpBuildCommands.Controls.Add(btnBuildIntegration);
            grpBuildCommands.Controls.Add(btnBuildWebPortal);
            grpBuildCommands.Controls.Add(btnBuild);
            grpBuildCommands.Location = new System.Drawing.Point(16, 16);
            grpBuildCommands.Name = "grpBuildCommands";
            grpBuildCommands.Padding = new System.Windows.Forms.Padding(12);
            grpBuildCommands.Size = new System.Drawing.Size(560, 100);
            grpBuildCommands.TabIndex = 0;
            grpBuildCommands.TabStop = false;
            grpBuildCommands.Text = "Build Commands";
            // 
            // btnBuildOECore
            // 
            btnBuildOECore.Location = new System.Drawing.Point(15, 26);
            btnBuildOECore.Margin = new System.Windows.Forms.Padding(6);
            btnBuildOECore.Name = "btnBuildOECore";
            btnBuildOECore.Size = new System.Drawing.Size(125, 32);
            btnBuildOECore.TabIndex = 0;
            btnBuildOECore.Text = "OE Core";
            btnBuildOECore.Click += btnBuildOECore_Click;
            // 
            // btnBuildClickOne
            // 
            btnBuildClickOne.Location = new System.Drawing.Point(146, 26);
            btnBuildClickOne.Margin = new System.Windows.Forms.Padding(6);
            btnBuildClickOne.Name = "btnBuildClickOne";
            btnBuildClickOne.Size = new System.Drawing.Size(125, 32);
            btnBuildClickOne.TabIndex = 1;
            btnBuildClickOne.Text = "Click One Legal";
            btnBuildClickOne.Click += btnBuildClickOne_Click;
            // 
            // btnBuildIntegration
            // 
            btnBuildIntegration.Location = new System.Drawing.Point(277, 26);
            btnBuildIntegration.Margin = new System.Windows.Forms.Padding(6);
            btnBuildIntegration.Name = "btnBuildIntegration";
            btnBuildIntegration.Size = new System.Drawing.Size(125, 32);
            btnBuildIntegration.TabIndex = 2;
            btnBuildIntegration.Text = "Integration";
            btnBuildIntegration.Click += btnBuildIntegration_Click;
            // 
            // btnBuildWebPortal
            // 
            btnBuildWebPortal.Location = new System.Drawing.Point(408, 26);
            btnBuildWebPortal.Margin = new System.Windows.Forms.Padding(6);
            btnBuildWebPortal.Name = "btnBuildWebPortal";
            btnBuildWebPortal.Size = new System.Drawing.Size(125, 32);
            btnBuildWebPortal.TabIndex = 3;
            btnBuildWebPortal.Text = "Web Portal";
            btnBuildWebPortal.Click += btnBuildWebPortal_Click;
            // 
            // btnBuild
            // 
            btnBuild.Location = new System.Drawing.Point(15, 64);
            btnBuild.Margin = new System.Windows.Forms.Padding(6);
            btnBuild.Name = "btnBuild";
            btnBuild.Size = new System.Drawing.Size(256, 32);
            btnBuild.TabIndex = 4;
            btnBuild.Text = "Build All Solutions";
            btnBuild.Click += btnBuild_Click;
            // 
            // grpRunCommands
            // 
            grpRunCommands.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            grpRunCommands.Controls.Add(btnRunTestServices);
            grpRunCommands.Controls.Add(btnRunCommand);
            grpRunCommands.Controls.Add(btnStop);
            grpRunCommands.Location = new System.Drawing.Point(590, 16);
            grpRunCommands.Name = "grpRunCommands";
            grpRunCommands.Padding = new System.Windows.Forms.Padding(12);
            grpRunCommands.Size = new System.Drawing.Size(380, 100);
            grpRunCommands.TabIndex = 1;
            grpRunCommands.TabStop = false;
            grpRunCommands.Text = "Run Commands";
            // 
            // btnRunTestServices
            // 
            btnRunTestServices.Location = new System.Drawing.Point(15, 26);
            btnRunTestServices.Margin = new System.Windows.Forms.Padding(6);
            btnRunTestServices.Name = "btnRunTestServices";
            btnRunTestServices.Size = new System.Drawing.Size(170, 32);
            btnRunTestServices.TabIndex = 0;
            btnRunTestServices.Text = "Run Services";
            btnRunTestServices.Click += btnRunTestServices_Click;
            // 
            // btnRunCommand
            // 
            btnRunCommand.Location = new System.Drawing.Point(191, 26);
            btnRunCommand.Margin = new System.Windows.Forms.Padding(6);
            btnRunCommand.Name = "btnRunCommand";
            btnRunCommand.Size = new System.Drawing.Size(170, 32);
            btnRunCommand.TabIndex = 1;
            btnRunCommand.Text = "Services && Client";
            btnRunCommand.Click += btnRunCommand_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new System.Drawing.Point(15, 64);
            btnStop.Margin = new System.Windows.Forms.Padding(6);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(170, 32);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop All";
            btnStop.Click += btnStop_Click;
            // 
            // grpOutput
            // 
            grpOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpOutput.Controls.Add(tbResults);
            grpOutput.Location = new System.Drawing.Point(16, 124);
            grpOutput.Name = "grpOutput";
            grpOutput.Padding = new System.Windows.Forms.Padding(12);
            grpOutput.Size = new System.Drawing.Size(954, 315);
            grpOutput.TabIndex = 2;
            grpOutput.TabStop = false;
            grpOutput.Text = "Output";
            // 
            // tbResults
            // 
            tbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            tbResults.Location = new System.Drawing.Point(12, 28);
            tbResults.Margin = new System.Windows.Forms.Padding(0);
            tbResults.Multiline = true;
            tbResults.Name = "tbResults";
            tbResults.ReadOnly = true;
            tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tbResults.Size = new System.Drawing.Size(930, 275);
            tbResults.TabIndex = 0;
            tbResults.WordWrap = false;
            // 
            // PowershellCommandsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(grpOutput);
            Controls.Add(grpRunCommands);
            Controls.Add(grpBuildCommands);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(986, 450);
            Name = "PowershellCommandsView";
            Padding = new System.Windows.Forms.Padding(8);
            Size = new System.Drawing.Size(986, 455);
            Load += PowershellCommandsView_Load;
            grpBuildCommands.ResumeLayout(false);
            grpRunCommands.ResumeLayout(false);
            grpOutput.ResumeLayout(false);
            grpOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuildCommands;
        private System.Windows.Forms.GroupBox grpRunCommands;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button btnBuildOECore;
        private System.Windows.Forms.Button btnBuildClickOne;
        private System.Windows.Forms.Button btnBuildIntegration;
        private System.Windows.Forms.Button btnBuildWebPortal;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnRunTestServices;
        private System.Windows.Forms.Button btnRunCommand;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbResults;
    }
}
