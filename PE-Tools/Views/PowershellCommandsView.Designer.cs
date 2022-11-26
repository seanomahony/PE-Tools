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
            this.SuspendLayout();
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(19, 49);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(226, 20);
            this.tbCommand.TabIndex = 0;
            this.tbCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCommand_KeyDown);
            // 
            // btnRunCommand
            // 
            this.btnRunCommand.Location = new System.Drawing.Point(742, 48);
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
            this.tbResults.Location = new System.Drawing.Point(18, 89);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResults.Size = new System.Drawing.Size(860, 275);
            this.tbResults.TabIndex = 3;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(672, 48);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(64, 23);
            this.btnBuild.TabIndex = 4;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(812, 48);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // userControlProjectSelector1
            // 
            this.userControlProjectSelector1.Location = new System.Drawing.Point(250, 12);
            this.userControlProjectSelector1.Name = "userControlProjectSelector1";
            this.userControlProjectSelector1.SelectedFolder = null;
            this.userControlProjectSelector1.Size = new System.Drawing.Size(384, 71);
            this.userControlProjectSelector1.TabIndex = 6;
            // 
            // PowershellCommandsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlProjectSelector1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.btnRunCommand);
            this.Controls.Add(this.tbCommand);
            this.Name = "PowershellCommandsView";
            this.Size = new System.Drawing.Size(890, 379);
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
    }
}
