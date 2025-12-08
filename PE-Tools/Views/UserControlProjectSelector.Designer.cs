namespace PE_Tools.Views
{
    partial class UserControlProjectSelector
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
            cbFolders = new System.Windows.Forms.ComboBox();
            SourceFolderLabelControl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cbFolders
            // 
            cbFolders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFolders.FormattingEnabled = true;
            cbFolders.Location = new System.Drawing.Point(8, 28);
            cbFolders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbFolders.Name = "cbFolders";
            cbFolders.Size = new System.Drawing.Size(424, 23);
            cbFolders.TabIndex = 1;
            cbFolders.SelectedIndexChanged += cbFolders_SelectedIndexChanged;
            // 
            // SourceFolderLabelControl
            // 
            SourceFolderLabelControl.AutoSize = true;
            SourceFolderLabelControl.Location = new System.Drawing.Point(8, 7);
            SourceFolderLabelControl.Margin = new System.Windows.Forms.Padding(4);
            SourceFolderLabelControl.Name = "SourceFolderLabelControl";
            SourceFolderLabelControl.Size = new System.Drawing.Size(113, 15);
            SourceFolderLabelControl.TabIndex = 0;
            SourceFolderLabelControl.Text = "Select Source Folder";
            // 
            // UserControlProjectSelector
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(cbFolders);
            Controls.Add(SourceFolderLabelControl);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(300, 57);
            Name = "UserControlProjectSelector";
            Padding = new System.Windows.Forms.Padding(4);
            Size = new System.Drawing.Size(440, 57);
            Load += userControlProjectSelector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label SourceFolderLabelControl;
        private System.Windows.Forms.ComboBox cbFolders;
    }
}
