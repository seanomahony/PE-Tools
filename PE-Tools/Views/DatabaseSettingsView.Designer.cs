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
            this.titleLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.docTextBox = new System.Windows.Forms.TextBox();
            this.c1TextBox = new System.Windows.Forms.TextBox();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new DevExpress.XtraEditors.SimpleButton();
            this.docListBox = new System.Windows.Forms.ListBox();
            this.SourceFolderLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.c1ListBox = new System.Windows.Forms.ListBox();
            this.C1LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.folderListBox = new System.Windows.Forms.ListBox();
            this.DocLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // titleLabelControl
            // 
            this.titleLabelControl.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelControl.Appearance.Options.UseFont = true;
            this.titleLabelControl.Location = new System.Drawing.Point(18, 4);
            this.titleLabelControl.Name = "titleLabelControl";
            this.titleLabelControl.Size = new System.Drawing.Size(280, 22);
            this.titleLabelControl.TabIndex = 36;
            this.titleLabelControl.Text = "Set Practice Evolve Databases";
            // 
            // saveButton
            // 
            this.saveButton.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(940, 292);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(191, 44);
            this.saveButton.TabIndex = 35;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.outputListBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(18, 344);
            this.outputListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(1113, 244);
            this.outputListBox.TabIndex = 34;
            // 
            // docTextBox
            // 
            this.docTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docTextBox.Location = new System.Drawing.Point(758, 258);
            this.docTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.docTextBox.Name = "docTextBox";
            this.docTextBox.Size = new System.Drawing.Size(373, 22);
            this.docTextBox.TabIndex = 33;
            this.docTextBox.Click += new System.EventHandler(this.docTextBox_Click);
            // 
            // c1TextBox
            // 
            this.c1TextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TextBox.Location = new System.Drawing.Point(388, 258);
            this.c1TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c1TextBox.Name = "c1TextBox";
            this.c1TextBox.Size = new System.Drawing.Size(364, 22);
            this.c1TextBox.TabIndex = 32;
            this.c1TextBox.Click += new System.EventHandler(this.c1TextBox_Click);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderTextBox.Location = new System.Drawing.Point(18, 258);
            this.folderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(364, 22);
            this.folderTextBox.TabIndex = 31;
            // 
            // applyButton
            // 
            this.applyButton.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Appearance.Options.UseFont = true;
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(18, 292);
            this.applyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(156, 44);
            this.applyButton.TabIndex = 30;
            this.applyButton.Text = "Apply";
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // docListBox
            // 
            this.docListBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docListBox.FormattingEnabled = true;
            this.docListBox.ItemHeight = 16;
            this.docListBox.Location = new System.Drawing.Point(758, 57);
            this.docListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.docListBox.Name = "docListBox";
            this.docListBox.Size = new System.Drawing.Size(373, 196);
            this.docListBox.TabIndex = 29;
            this.docListBox.SelectedIndexChanged += new System.EventHandler(this.docListBox_SelectedIndexChanged);
            // 
            // SourceFolderLabelControl
            // 
            this.SourceFolderLabelControl.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceFolderLabelControl.Appearance.Options.UseFont = true;
            this.SourceFolderLabelControl.Location = new System.Drawing.Point(18, 33);
            this.SourceFolderLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SourceFolderLabelControl.Name = "SourceFolderLabelControl";
            this.SourceFolderLabelControl.Size = new System.Drawing.Size(123, 16);
            this.SourceFolderLabelControl.TabIndex = 26;
            this.SourceFolderLabelControl.Text = "Select Source Folder";
            // 
            // c1ListBox
            // 
            this.c1ListBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1ListBox.FormattingEnabled = true;
            this.c1ListBox.ItemHeight = 16;
            this.c1ListBox.Location = new System.Drawing.Point(388, 57);
            this.c1ListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c1ListBox.Name = "c1ListBox";
            this.c1ListBox.Size = new System.Drawing.Size(364, 196);
            this.c1ListBox.TabIndex = 28;
            this.c1ListBox.SelectedIndexChanged += new System.EventHandler(this.c1ListBox_SelectedIndexChanged);
            // 
            // C1LabelControl
            // 
            this.C1LabelControl.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1LabelControl.Appearance.Options.UseFont = true;
            this.C1LabelControl.Location = new System.Drawing.Point(388, 33);
            this.C1LabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.C1LabelControl.Name = "C1LabelControl";
            this.C1LabelControl.Size = new System.Drawing.Size(79, 16);
            this.C1LabelControl.TabIndex = 24;
            this.C1LabelControl.Text = "Select C1 DB";
            // 
            // folderListBox
            // 
            this.folderListBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderListBox.FormattingEnabled = true;
            this.folderListBox.ItemHeight = 16;
            this.folderListBox.Location = new System.Drawing.Point(18, 57);
            this.folderListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.folderListBox.Name = "folderListBox";
            this.folderListBox.Size = new System.Drawing.Size(364, 196);
            this.folderListBox.TabIndex = 27;
            this.folderListBox.SelectedIndexChanged += new System.EventHandler(this.folderListBox_SelectedIndexChanged);
            // 
            // DocLabelControl
            // 
            this.DocLabelControl.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocLabelControl.Appearance.Options.UseFont = true;
            this.DocLabelControl.Location = new System.Drawing.Point(758, 33);
            this.DocLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DocLabelControl.Name = "DocLabelControl";
            this.DocLabelControl.Size = new System.Drawing.Size(86, 16);
            this.DocLabelControl.TabIndex = 25;
            this.DocLabelControl.Text = "Select Doc DB";
            // 
            // DatabaseSettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLabelControl);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.docTextBox);
            this.Controls.Add(this.c1TextBox);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.docListBox);
            this.Controls.Add(this.SourceFolderLabelControl);
            this.Controls.Add(this.c1ListBox);
            this.Controls.Add(this.C1LabelControl);
            this.Controls.Add(this.folderListBox);
            this.Controls.Add(this.DocLabelControl);
            this.Name = "DatabaseSettingsView";
            this.Size = new System.Drawing.Size(1152, 598);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl titleLabelControl;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.TextBox docTextBox;
        private System.Windows.Forms.TextBox c1TextBox;
        private System.Windows.Forms.TextBox folderTextBox;
        private DevExpress.XtraEditors.SimpleButton applyButton;
        private System.Windows.Forms.ListBox docListBox;
        private DevExpress.XtraEditors.LabelControl SourceFolderLabelControl;
        private System.Windows.Forms.ListBox c1ListBox;
        private DevExpress.XtraEditors.LabelControl C1LabelControl;
        private System.Windows.Forms.ListBox folderListBox;
        private DevExpress.XtraEditors.LabelControl DocLabelControl;
    }
}
