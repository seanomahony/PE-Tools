namespace PE_Tools.Views
{
    partial class KubectlCommandsView
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
            this.grpConfiguration = new System.Windows.Forms.GroupBox();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.cbNamespace = new System.Windows.Forms.ComboBox();
            this.lblPodName = new System.Windows.Forms.Label();
            this.cbPodName = new System.Windows.Forms.ComboBox();
            this.lblContainer = new System.Windows.Forms.Label();
            this.cbContainer = new System.Windows.Forms.ComboBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.cbSourcePath = new System.Windows.Forms.ComboBox();
            this.lblDestPath = new System.Windows.Forms.Label();
            this.cbDestPath = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            
            this.grpConfiguration.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();

            // 
            // grpConfiguration
            // 
            this.grpConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConfiguration.Controls.Add(this.lblNamespace);
            this.grpConfiguration.Controls.Add(this.cbNamespace);
            this.grpConfiguration.Controls.Add(this.lblPodName);
            this.grpConfiguration.Controls.Add(this.cbPodName);
            this.grpConfiguration.Controls.Add(this.lblContainer);
            this.grpConfiguration.Controls.Add(this.cbContainer);
            this.grpConfiguration.Controls.Add(this.lblAction);
            this.grpConfiguration.Controls.Add(this.cbAction);
            this.grpConfiguration.Controls.Add(this.lblSourcePath);
            this.grpConfiguration.Controls.Add(this.cbSourcePath);
            this.grpConfiguration.Controls.Add(this.lblDestPath);
            this.grpConfiguration.Controls.Add(this.cbDestPath);
            this.grpConfiguration.Location = new System.Drawing.Point(12, 12);
            this.grpConfiguration.Name = "grpConfiguration";
            this.grpConfiguration.Size = new System.Drawing.Size(960, 260); // Increased height for button or spacing
            this.grpConfiguration.TabIndex = 0;
            this.grpConfiguration.TabStop = false;
            this.grpConfiguration.Text = "Configuration";

            int y = 30;
            int labelX = 20;
            int inputX = 140;
            int inputWidth = 300;
            int gap = 35;

            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(100, 20);
            this.lblNamespace.Text = "Namespace:";
            
            // 
            // cbNamespace
            // 
            this.cbNamespace.FormattingEnabled = true;
            this.cbNamespace.Location = new System.Drawing.Point(inputX, y);
            this.cbNamespace.Name = "cbNamespace";
            this.cbNamespace.Size = new System.Drawing.Size(inputWidth, 30);
            this.cbNamespace.TabIndex = 0;

            y += gap;

            // 
            // lblPodName
            // 
            this.lblPodName.AutoSize = true;
            this.lblPodName.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblPodName.Name = "lblPodName";
            this.lblPodName.Size = new System.Drawing.Size(100, 20);
            this.lblPodName.Text = "Pod Name:";
            
            // 
            // cbPodName
            // 
            this.cbPodName.FormattingEnabled = true;
            this.cbPodName.Location = new System.Drawing.Point(inputX, y);
            this.cbPodName.Name = "cbPodName";
            this.cbPodName.Size = new System.Drawing.Size(inputWidth, 30);
            this.cbPodName.TabIndex = 1;

            y += gap;

            // 
            // lblContainer
            // 
            this.lblContainer.AutoSize = true;
            this.lblContainer.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Size = new System.Drawing.Size(100, 20);
            this.lblContainer.Text = "Container:";

            // 
            // cbContainer
            // 
            this.cbContainer.DropDownWidth = inputWidth;
            this.cbContainer.FormattingEnabled = true;
            this.cbContainer.Location = new System.Drawing.Point(inputX, y);
            this.cbContainer.Name = "cbContainer";
            this.cbContainer.Size = new System.Drawing.Size(inputWidth, 30);
            this.cbContainer.TabIndex = 2;

            y += gap;

            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(100, 20);
            this.lblAction.Text = "Action:";

            // 
            // cbAction
            // 
            this.cbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] { "Copy To", "Copy From" });
            this.cbAction.Location = new System.Drawing.Point(inputX, y);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(inputWidth, 30);
            this.cbAction.TabIndex = 3;

            y += gap;

            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(100, 20);
            this.lblSourcePath.Text = "Source Path:";

            // 
            // cbSourcePath
            // 
            this.cbSourcePath.FormattingEnabled = true;
            this.cbSourcePath.Location = new System.Drawing.Point(inputX, y);
            this.cbSourcePath.Name = "cbSourcePath";
            this.cbSourcePath.Size = new System.Drawing.Size(600, 30);
            this.cbSourcePath.TabIndex = 4;

            y += gap;

            // 
            // lblDestPath
            // 
            this.lblDestPath.AutoSize = true;
            this.lblDestPath.Location = new System.Drawing.Point(labelX, y + 3);
            this.lblDestPath.Name = "lblDestPath";
            this.lblDestPath.Size = new System.Drawing.Size(100, 20);
            this.lblDestPath.Text = "Dest Path:";

            // 
            // cbDestPath
            // 
            this.cbDestPath.FormattingEnabled = true;
            this.cbDestPath.Location = new System.Drawing.Point(inputX, y);
            this.cbDestPath.Name = "cbDestPath";
            this.cbDestPath.Size = new System.Drawing.Size(600, 30);
            this.cbDestPath.TabIndex = 5;

            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 280); 
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 30);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            // 
            // grpResult
            // 
            this.grpResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Location = new System.Drawing.Point(12, 320);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(960, 150);
            this.grpResult.TabIndex = 1;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";

            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 23); 
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(954, 124);
            this.txtResult.TabIndex = 0;

            // 
            // KubectlCommandsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpConfiguration);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.btnGenerate);
            this.Name = "KubectlCommandsView";
            this.Size = new System.Drawing.Size(986, 397);
            
            this.grpConfiguration.ResumeLayout(false);
            this.grpConfiguration.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpConfiguration;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.ComboBox cbNamespace;
        private System.Windows.Forms.Label lblPodName;
        private System.Windows.Forms.ComboBox cbPodName;
        private System.Windows.Forms.Label lblContainer;
        private System.Windows.Forms.ComboBox cbContainer;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.ComboBox cbSourcePath;
        private System.Windows.Forms.Label lblDestPath;
        private System.Windows.Forms.ComboBox cbDestPath;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGenerate;
    }
}
