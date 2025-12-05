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
            btnRunCommand = new System.Windows.Forms.Button();
            tbResults = new System.Windows.Forms.TextBox();
            btnBuild = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            btnBuildOECore = new System.Windows.Forms.Button();
            btnBuildClickOne = new System.Windows.Forms.Button();
            btnRunTestServices = new System.Windows.Forms.Button();
            btnBuildWebPortal = new System.Windows.Forms.Button();
            btnBuildIntegration = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnRunCommand
            // 
            btnRunCommand.Location = new System.Drawing.Point(835, 13);
            btnRunCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRunCommand.Name = "btnRunCommand";
            btnRunCommand.Size = new System.Drawing.Size(175, 27);
            btnRunCommand.TabIndex = 1;
            btnRunCommand.Text = "Run Services and Client";
            btnRunCommand.UseVisualStyleBackColor = true;
            btnRunCommand.Click += btnRunCommand_Click;
            // 
            // tbResults
            // 
            tbResults.BackColor = System.Drawing.SystemColors.HotTrack;
            tbResults.ForeColor = System.Drawing.Color.White;
            tbResults.Location = new System.Drawing.Point(22, 115);
            tbResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbResults.Multiline = true;
            tbResults.Name = "tbResults";
            tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tbResults.Size = new System.Drawing.Size(1003, 335);
            tbResults.TabIndex = 3;
            // 
            // btnBuild
            // 
            btnBuild.Location = new System.Drawing.Point(22, 80);
            btnBuild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBuild.Name = "btnBuild";
            btnBuild.Size = new System.Drawing.Size(175, 27);
            btnBuild.TabIndex = 4;
            btnBuild.Text = "Build Solution";
            btnBuild.UseVisualStyleBackColor = true;
            btnBuild.Click += btnBuild_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new System.Drawing.Point(835, 46);
            btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(175, 27);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop Services/Client";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnBuildOECore
            // 
            btnBuildOECore.Location = new System.Drawing.Point(22, 14);
            btnBuildOECore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBuildOECore.Name = "btnBuildOECore";
            btnBuildOECore.Size = new System.Drawing.Size(175, 27);
            btnBuildOECore.TabIndex = 7;
            btnBuildOECore.Text = "Build OECore";
            btnBuildOECore.UseVisualStyleBackColor = true;
            btnBuildOECore.Click += btnBuildOECore_Click;
            // 
            // btnBuildClickOne
            // 
            btnBuildClickOne.Location = new System.Drawing.Point(22, 47);
            btnBuildClickOne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBuildClickOne.Name = "btnBuildClickOne";
            btnBuildClickOne.Size = new System.Drawing.Size(175, 27);
            btnBuildClickOne.TabIndex = 8;
            btnBuildClickOne.Text = "Build Click One Legal";
            btnBuildClickOne.UseVisualStyleBackColor = true;
            btnBuildClickOne.Click += btnBuildClickOne_Click;
            // 
            // btnRunTestServices
            // 
            btnRunTestServices.Location = new System.Drawing.Point(652, 14);
            btnRunTestServices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRunTestServices.Name = "btnRunTestServices";
            btnRunTestServices.Size = new System.Drawing.Size(175, 27);
            btnRunTestServices.TabIndex = 9;
            btnRunTestServices.Text = "Run Services";
            btnRunTestServices.UseVisualStyleBackColor = true;
            btnRunTestServices.Click += btnRunTestServices_Click;
            // 
            // btnBuildWebPortal
            // 
            btnBuildWebPortal.Location = new System.Drawing.Point(205, 46);
            btnBuildWebPortal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBuildWebPortal.Name = "btnBuildWebPortal";
            btnBuildWebPortal.Size = new System.Drawing.Size(175, 27);
            btnBuildWebPortal.TabIndex = 10;
            btnBuildWebPortal.Text = "Build Web Portal";
            btnBuildWebPortal.UseVisualStyleBackColor = true;
            btnBuildWebPortal.Click += btnBuildWebPortal_Click;
            // 
            // btnBuildIntegration
            // 
            btnBuildIntegration.Location = new System.Drawing.Point(205, 13);
            btnBuildIntegration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBuildIntegration.Name = "btnBuildIntegration";
            btnBuildIntegration.Size = new System.Drawing.Size(175, 27);
            btnBuildIntegration.TabIndex = 11;
            btnBuildIntegration.Text = "Build Integration";
            btnBuildIntegration.UseVisualStyleBackColor = true;
            btnBuildIntegration.Click += btnBuildIntegration_Click;
            // 
            // PowershellCommandsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnBuildIntegration);
            Controls.Add(btnBuildWebPortal);
            Controls.Add(btnRunTestServices);
            Controls.Add(btnBuildClickOne);
            Controls.Add(btnBuildOECore);
            Controls.Add(btnStop);
            Controls.Add(btnBuild);
            Controls.Add(tbResults);
            Controls.Add(btnRunCommand);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "PowershellCommandsView";
            Size = new System.Drawing.Size(1038, 455);
            Load += PowershellCommandsView_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRunCommand;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBuildOECore;
        private System.Windows.Forms.Button btnBuildClickOne;
        private System.Windows.Forms.Button btnRunTestServices;
        private System.Windows.Forms.Button btnBuildWebPortal;
        private System.Windows.Forms.Button btnBuildIntegration;
    }
}
