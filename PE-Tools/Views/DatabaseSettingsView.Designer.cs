namespace PE_Tools.Views
{
    partial class DatabaseSettingsView
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
            this.titleLabelControl = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.C1LabelControl = new System.Windows.Forms.Label();
            this.DocLabelControl = new System.Windows.Forms.Label();
            this.cbC1DBs = new System.Windows.Forms.ComboBox();
            this.cbDocDBs = new System.Windows.Forms.ComboBox();
            this.btnViewC1config = new System.Windows.Forms.Button();
            this.btnViewDocConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabelControl
            // 
            this.titleLabelControl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelControl.Location = new System.Drawing.Point(18, 4);
            this.titleLabelControl.Name = "titleLabelControl";
            this.titleLabelControl.Size = new System.Drawing.Size(280, 22);
            this.titleLabelControl.TabIndex = 36;
            this.titleLabelControl.Text = "Set Practice Evolve Databases";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(127, 105);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 35;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.outputRichTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputRichTextBox.Location = new System.Drawing.Point(18, 136);
            this.outputRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputRichTextBox.Size = new System.Drawing.Size(1113, 244);
            this.outputRichTextBox.TabIndex = 34;
            this.outputRichTextBox.Text = "";
            this.outputRichTextBox.WordWrap = false;
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(18, 105);
            this.applyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 30;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // C1LabelControl
            // 
            this.C1LabelControl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1LabelControl.Location = new System.Drawing.Point(417, 42);
            this.C1LabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.C1LabelControl.Name = "C1LabelControl";
            this.C1LabelControl.Size = new System.Drawing.Size(79, 16);
            this.C1LabelControl.TabIndex = 24;
            this.C1LabelControl.Text = "Select C1 DB";
            // 
            // DocLabelControl
            // 
            this.DocLabelControl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocLabelControl.Location = new System.Drawing.Point(756, 42);
            this.DocLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DocLabelControl.Name = "DocLabelControl";
            this.DocLabelControl.Size = new System.Drawing.Size(86, 16);
            this.DocLabelControl.TabIndex = 25;
            this.DocLabelControl.Text = "Select Doc DB";
            // 
            // cbC1DBs
            // 
            this.cbC1DBs.FormattingEnabled = true;
            this.cbC1DBs.Location = new System.Drawing.Point(417, 65);
            this.cbC1DBs.Name = "cbC1DBs";
            this.cbC1DBs.Size = new System.Drawing.Size(333, 21);
            this.cbC1DBs.TabIndex = 38;
            this.cbC1DBs.SelectedIndexChanged += new System.EventHandler(this.cbC1DBs_SelectedIndexChanged);
            // 
            // cbDocDBs
            // 
            this.cbDocDBs.FormattingEnabled = true;
            this.cbDocDBs.Location = new System.Drawing.Point(756, 65);
            this.cbDocDBs.Name = "cbDocDBs";
            this.cbDocDBs.Size = new System.Drawing.Size(373, 21);
            this.cbDocDBs.TabIndex = 39;
            this.cbDocDBs.SelectedIndexChanged += new System.EventHandler(this.cbDocDBs_SelectedIndexChanged);
            // 
            // btnViewC1config
            // 
            this.btnViewC1config.Location = new System.Drawing.Point(417, 106);
            this.btnViewC1config.Name = "btnViewC1config";
            this.btnViewC1config.Size = new System.Drawing.Size(75, 23);
            this.btnViewC1config.TabIndex = 40;
            this.btnViewC1config.Text = "View C1 config";
            this.btnViewC1config.UseVisualStyleBackColor = true;
            this.btnViewC1config.Click += new System.EventHandler(this.btnViewC1config_Click);
            // 
            // btnViewDocConfig
            // 
            this.btnViewDocConfig.Location = new System.Drawing.Point(756, 106);
            this.btnViewDocConfig.Name = "btnViewDocConfig";
            this.btnViewDocConfig.Size = new System.Drawing.Size(75, 23);
            this.btnViewDocConfig.TabIndex = 41;
            this.btnViewDocConfig.Text = "View Doc";
            this.btnViewDocConfig.UseVisualStyleBackColor = true;
            this.btnViewDocConfig.Click += new System.EventHandler(this.btnViewDocConfig_Click);
            // 
            // DatabaseSettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewDocConfig);
            this.Controls.Add(this.btnViewC1config);
            this.Controls.Add(this.cbDocDBs);
            this.Controls.Add(this.cbC1DBs);
            this.Controls.Add(this.titleLabelControl);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.C1LabelControl);
            this.Controls.Add(this.DocLabelControl);
            this.Name = "DatabaseSettingsView";
            this.Size = new System.Drawing.Size(1152, 393);
            this.Load += new System.EventHandler(this.DatabaseSettingsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabelControl;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label C1LabelControl;
        private System.Windows.Forms.Label DocLabelControl;
        private System.Windows.Forms.ComboBox cbC1DBs;
        private System.Windows.Forms.ComboBox cbDocDBs;
        private System.Windows.Forms.Button btnViewC1config;
        private System.Windows.Forms.Button btnViewDocConfig;
    }
}
