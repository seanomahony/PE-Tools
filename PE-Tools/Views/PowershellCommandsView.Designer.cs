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
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.btnRunCommand = new System.Windows.Forms.Button();
            this.lblCommand = new DevExpress.XtraEditors.LabelControl();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.userControlProjectSelector1 = new PE_Tools.Views.UserControlProjectSelector();
            this.btnBuildOECore = new System.Windows.Forms.Button();
            this.btnBuildClickOne = new System.Windows.Forms.Button();
            this.btnRunTestServices = new System.Windows.Forms.Button();
            this.btnBuildWebPortal = new System.Windows.Forms.Button();
            this.btnBuildIntegration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(19, 49);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(94, 20);
            this.tbCommand.TabIndex = 0;
            this.tbCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCommand_KeyDown);
            // 
            // btnRunCommand
            // 
            this.btnRunCommand.Location = new System.Drawing.Point(725, 73);
            this.btnRunCommand.Name = "btnRunCommand";
            this.btnRunCommand.Size = new System.Drawing.Size(64, 23);
            this.btnRunCommand.TabIndex = 1;
            this.btnRunCommand.Text = "Run";
            this.btnRunCommand.UseVisualStyleBackColor = true;
            this.btnRunCommand.Click += new System.EventHandler(this.btnRunCommand_Click);
            // 
            // lblCommand
            // 
            this.lblCommand.Location = new System.Drawing.Point(21, 27);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(47, 13);
            this.lblCommand.TabIndex = 2;
            this.lblCommand.Text = "Command";
            // 
            // tbResults
            // 
            this.tbResults.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbResults.ForeColor = System.Drawing.Color.White;
            this.tbResults.Location = new System.Drawing.Point(19, 127);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResults.Size = new System.Drawing.Size(860, 264);
            this.tbResults.TabIndex = 3;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(541, 72);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(150, 23);
            this.btnBuild.TabIndex = 4;
            this.btnBuild.Text = "Build Solution";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(814, 73);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // userControlProjectSelector1
            // 
            this.userControlProjectSelector1.Callback = null;
            this.userControlProjectSelector1.FolderNames = null;
            this.userControlProjectSelector1.Location = new System.Drawing.Point(119, 12);
            this.userControlProjectSelector1.Name = "userControlProjectSelector1";
            this.userControlProjectSelector1.SelectedFolder = null;
            this.userControlProjectSelector1.Size = new System.Drawing.Size(384, 71);
            this.userControlProjectSelector1.TabIndex = 6;
            // 
            // btnBuildOECore
            // 
            this.btnBuildOECore.Location = new System.Drawing.Point(541, 12);
            this.btnBuildOECore.Name = "btnBuildOECore";
            this.btnBuildOECore.Size = new System.Drawing.Size(150, 23);
            this.btnBuildOECore.TabIndex = 7;
            this.btnBuildOECore.Text = "Build OECore";
            this.btnBuildOECore.UseVisualStyleBackColor = true;
            this.btnBuildOECore.Click += new System.EventHandler(this.btnBuildOECore_Click);
            // 
            // btnBuildClickOne
            // 
            this.btnBuildClickOne.Location = new System.Drawing.Point(725, 12);
            this.btnBuildClickOne.Name = "btnBuildClickOne";
            this.btnBuildClickOne.Size = new System.Drawing.Size(150, 23);
            this.btnBuildClickOne.TabIndex = 8;
            this.btnBuildClickOne.Text = "Build Click One Legal";
            this.btnBuildClickOne.UseVisualStyleBackColor = true;
            this.btnBuildClickOne.Click += new System.EventHandler(this.btnBuildClickOne_Click);
            // 
            // btnRunTestServices
            // 
            this.btnRunTestServices.Location = new System.Drawing.Point(541, 100);
            this.btnRunTestServices.Name = "btnRunTestServices";
            this.btnRunTestServices.Size = new System.Drawing.Size(337, 23);
            this.btnRunTestServices.TabIndex = 9;
            this.btnRunTestServices.Text = "Run Services for Unit Tests";
            this.btnRunTestServices.UseVisualStyleBackColor = true;
            this.btnRunTestServices.Click += new System.EventHandler(this.btnRunTestServices_Click);
            // 
            // btnBuildWebPortal
            // 
            this.btnBuildWebPortal.Location = new System.Drawing.Point(725, 44);
            this.btnBuildWebPortal.Name = "btnBuildWebPortal";
            this.btnBuildWebPortal.Size = new System.Drawing.Size(150, 23);
            this.btnBuildWebPortal.TabIndex = 10;
            this.btnBuildWebPortal.Text = "Build Web Portal";
            this.btnBuildWebPortal.UseVisualStyleBackColor = true;
            this.btnBuildWebPortal.Click += new System.EventHandler(this.btnBuildWebPortal_Click);
            // 
            // btnBuildIntegration
            // 
            this.btnBuildIntegration.Location = new System.Drawing.Point(541, 43);
            this.btnBuildIntegration.Name = "btnBuildIntegration";
            this.btnBuildIntegration.Size = new System.Drawing.Size(150, 23);
            this.btnBuildIntegration.TabIndex = 11;
            this.btnBuildIntegration.Text = "Build Integration";
            this.btnBuildIntegration.UseVisualStyleBackColor = true;
            this.btnBuildIntegration.Click += new System.EventHandler(this.btnBuildIntegration_Click);
            // 
            // PowershellCommandsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuildIntegration);
            this.Controls.Add(this.btnBuildWebPortal);
            this.Controls.Add(this.btnRunTestServices);
            this.Controls.Add(this.btnBuildClickOne);
            this.Controls.Add(this.btnBuildOECore);
            this.Controls.Add(this.userControlProjectSelector1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.btnRunCommand);
            this.Controls.Add(this.tbCommand);
            this.Name = "PowershellCommandsView";
            this.Size = new System.Drawing.Size(890, 394);
            this.Load += new System.EventHandler(this.PowershellCommandsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Button btnRunCommand;
        private DevExpress.XtraEditors.LabelControl lblCommand;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnStop;
        private UserControlProjectSelector userControlProjectSelector1;
        private System.Windows.Forms.Button btnBuildOECore;
        private System.Windows.Forms.Button btnBuildClickOne;
        private System.Windows.Forms.Button btnRunTestServices;
        private System.Windows.Forms.Button btnBuildWebPortal;
        private System.Windows.Forms.Button btnBuildIntegration;
    }
}
