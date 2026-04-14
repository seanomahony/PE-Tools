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
            grpDatabaseSelection = new System.Windows.Forms.GroupBox();
            C1LabelControl = new System.Windows.Forms.Label();
            cbC1DBs = new System.Windows.Forms.ComboBox();
            btnViewC1config = new System.Windows.Forms.Button();
            DocLabelControl = new System.Windows.Forms.Label();
            cbDocDBs = new System.Windows.Forms.ComboBox();
            btnViewDocConfig = new System.Windows.Forms.Button();
            grpActions = new System.Windows.Forms.GroupBox();
            applyButton = new System.Windows.Forms.Button();
            saveButton = new System.Windows.Forms.Button();
            grpOutput = new System.Windows.Forms.GroupBox();
            outputRichTextBox = new System.Windows.Forms.RichTextBox();
            titleLabelControl = new System.Windows.Forms.Label();
            btnOpenC1config = new System.Windows.Forms.Button();
            btnOpenDocConfig = new System.Windows.Forms.Button();
            grpDatabaseSelection.SuspendLayout();
            grpActions.SuspendLayout();
            grpOutput.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatabaseSelection
            // 
            grpDatabaseSelection.Controls.Add(C1LabelControl);
            grpDatabaseSelection.Controls.Add(cbC1DBs);
            grpDatabaseSelection.Controls.Add(btnOpenDocConfig);
            grpDatabaseSelection.Controls.Add(btnOpenC1config);
            grpDatabaseSelection.Controls.Add(btnViewC1config);
            grpDatabaseSelection.Controls.Add(DocLabelControl);
            grpDatabaseSelection.Controls.Add(cbDocDBs);
            grpDatabaseSelection.Controls.Add(btnViewDocConfig);
            grpDatabaseSelection.Location = new System.Drawing.Point(16, 44);
            grpDatabaseSelection.Name = "grpDatabaseSelection";
            grpDatabaseSelection.Padding = new System.Windows.Forms.Padding(12);
            grpDatabaseSelection.Size = new System.Drawing.Size(760, 95);
            grpDatabaseSelection.TabIndex = 1;
            grpDatabaseSelection.TabStop = false;
            grpDatabaseSelection.Text = "Database Selection";
            // 
            // C1LabelControl
            // 
            C1LabelControl.AutoSize = true;
            C1LabelControl.Location = new System.Drawing.Point(15, 28);
            C1LabelControl.Name = "C1LabelControl";
            C1LabelControl.Size = new System.Drawing.Size(73, 15);
            C1LabelControl.TabIndex = 0;
            C1LabelControl.Text = "Select C1 DB";
            // 
            // cbC1DBs
            // 
            cbC1DBs.FormattingEnabled = true;
            cbC1DBs.Location = new System.Drawing.Point(15, 50);
            cbC1DBs.Name = "cbC1DBs";
            cbC1DBs.Size = new System.Drawing.Size(280, 23);
            cbC1DBs.TabIndex = 1;
            cbC1DBs.SelectedIndexChanged += cbC1DBs_SelectedIndexChanged;
            // 
            // btnViewC1config
            // 
            btnViewC1config.Location = new System.Drawing.Point(301, 11);
            btnViewC1config.Name = "btnViewC1config";
            btnViewC1config.Size = new System.Drawing.Size(75, 32);
            btnViewC1config.TabIndex = 2;
            btnViewC1config.Text = "View File";
            btnViewC1config.Click += btnViewC1config_Click;
            // 
            // DocLabelControl
            // 
            DocLabelControl.AutoSize = true;
            DocLabelControl.Location = new System.Drawing.Point(390, 28);
            DocLabelControl.Name = "DocLabelControl";
            DocLabelControl.Size = new System.Drawing.Size(80, 15);
            DocLabelControl.TabIndex = 3;
            DocLabelControl.Text = "Select Doc DB";
            // 
            // cbDocDBs
            // 
            cbDocDBs.FormattingEnabled = true;
            cbDocDBs.Location = new System.Drawing.Point(390, 50);
            cbDocDBs.Name = "cbDocDBs";
            cbDocDBs.Size = new System.Drawing.Size(280, 23);
            cbDocDBs.TabIndex = 4;
            cbDocDBs.SelectedIndexChanged += cbDocDBs_SelectedIndexChanged;
            // 
            // btnViewDocConfig
            // 
            btnViewDocConfig.Location = new System.Drawing.Point(685, 11);
            btnViewDocConfig.Name = "btnViewDocConfig";
            btnViewDocConfig.Size = new System.Drawing.Size(75, 32);
            btnViewDocConfig.TabIndex = 5;
            btnViewDocConfig.Text = "View File";
            btnViewDocConfig.Click += btnViewDocConfig_Click;
            // 
            // grpActions
            // 
            grpActions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            grpActions.Controls.Add(applyButton);
            grpActions.Controls.Add(saveButton);
            grpActions.Location = new System.Drawing.Point(790, 44);
            grpActions.Name = "grpActions";
            grpActions.Padding = new System.Windows.Forms.Padding(12);
            grpActions.Size = new System.Drawing.Size(340, 95);
            grpActions.TabIndex = 2;
            grpActions.TabStop = false;
            grpActions.Text = "Actions";
            // 
            // applyButton
            // 
            applyButton.Enabled = false;
            applyButton.Location = new System.Drawing.Point(15, 40);
            applyButton.Margin = new System.Windows.Forms.Padding(6);
            applyButton.Name = "applyButton";
            applyButton.Size = new System.Drawing.Size(150, 36);
            applyButton.TabIndex = 0;
            applyButton.Text = "Apply Changes";
            applyButton.Click += applyButton_Click;
            // 
            // saveButton
            // 
            saveButton.Enabled = false;
            saveButton.Location = new System.Drawing.Point(177, 40);
            saveButton.Margin = new System.Windows.Forms.Padding(6);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(150, 36);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save to Files";
            saveButton.Click += saveButton_Click;
            // 
            // grpOutput
            // 
            grpOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpOutput.Controls.Add(outputRichTextBox);
            grpOutput.Location = new System.Drawing.Point(16, 148);
            grpOutput.Name = "grpOutput";
            grpOutput.Padding = new System.Windows.Forms.Padding(12);
            grpOutput.Size = new System.Drawing.Size(1114, 232);
            grpOutput.TabIndex = 3;
            grpOutput.TabStop = false;
            grpOutput.Text = "Configuration Output";
            // 
            // outputRichTextBox
            // 
            outputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            outputRichTextBox.Location = new System.Drawing.Point(12, 28);
            outputRichTextBox.Margin = new System.Windows.Forms.Padding(0);
            outputRichTextBox.Name = "outputRichTextBox";
            outputRichTextBox.ReadOnly = true;
            outputRichTextBox.Size = new System.Drawing.Size(1090, 192);
            outputRichTextBox.TabIndex = 0;
            outputRichTextBox.Text = "";
            outputRichTextBox.WordWrap = false;
            // 
            // titleLabelControl
            // 
            titleLabelControl.AutoSize = true;
            titleLabelControl.Location = new System.Drawing.Point(16, 12);
            titleLabelControl.Name = "titleLabelControl";
            titleLabelControl.Size = new System.Drawing.Size(161, 15);
            titleLabelControl.TabIndex = 0;
            titleLabelControl.Text = "Set Practice Evolve Databases";
            // 
            // btnOpenC1config
            // 
            btnOpenC1config.Location = new System.Drawing.Point(301, 44);
            btnOpenC1config.Name = "btnOpenC1config";
            btnOpenC1config.Size = new System.Drawing.Size(75, 32);
            btnOpenC1config.TabIndex = 2;
            btnOpenC1config.Text = "Open File";
            btnOpenC1config.Click += BtnOpenC1config_Click;
            // 
            // btnOpenDocConfig
            // 
            btnOpenDocConfig.Location = new System.Drawing.Point(685, 44);
            btnOpenDocConfig.Name = "btnOpenDocConfig";
            btnOpenDocConfig.Size = new System.Drawing.Size(75, 32);
            btnOpenDocConfig.TabIndex = 2;
            btnOpenDocConfig.Text = "Open File";
            btnOpenDocConfig.Click += BtnOpenDocConfig_Click;
            // 
            // DatabaseSettingsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(grpOutput);
            Controls.Add(grpActions);
            Controls.Add(grpDatabaseSelection);
            Controls.Add(titleLabelControl);
            Name = "DatabaseSettingsView";
            Padding = new System.Windows.Forms.Padding(8);
            Size = new System.Drawing.Size(1152, 393);
            Load += DatabaseSettingsView_Load;
            grpDatabaseSelection.ResumeLayout(false);
            grpDatabaseSelection.PerformLayout();
            grpActions.ResumeLayout(false);
            grpOutput.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabelControl;
        private System.Windows.Forms.GroupBox grpDatabaseSelection;
        private System.Windows.Forms.Label C1LabelControl;
        private System.Windows.Forms.ComboBox cbC1DBs;
        private System.Windows.Forms.Button btnViewC1config;
        private System.Windows.Forms.Label DocLabelControl;
        private System.Windows.Forms.ComboBox cbDocDBs;
        private System.Windows.Forms.Button btnViewDocConfig;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Button btnOpenDocConfig;
        private System.Windows.Forms.Button btnOpenC1config;
    }
}
