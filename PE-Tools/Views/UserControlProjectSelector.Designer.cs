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
            cbFolders.FormattingEnabled = true;
            cbFolders.Location = new System.Drawing.Point(4, 29);
            cbFolders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbFolders.Name = "cbFolders";
            cbFolders.Size = new System.Drawing.Size(424, 23);
            cbFolders.TabIndex = 39;
            cbFolders.SelectedIndexChanged += cbFolders_SelectedIndexChanged;
            // 
            // SourceFolderLabelControl
            // 
            SourceFolderLabelControl.AutoSize = true;
            SourceFolderLabelControl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SourceFolderLabelControl.Location = new System.Drawing.Point(4, 5);
            SourceFolderLabelControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            SourceFolderLabelControl.Name = "SourceFolderLabelControl";
            SourceFolderLabelControl.Size = new System.Drawing.Size(129, 16);
            SourceFolderLabelControl.TabIndex = 38;
            SourceFolderLabelControl.Text = "Select Source Folder";
            // 
            // UserControlProjectSelector
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(cbFolders);
            Controls.Add(SourceFolderLabelControl);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "UserControlProjectSelector";
            Size = new System.Drawing.Size(437, 61);
            Load += userControlProjectSelector_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFolders;
        private System.Windows.Forms.Label SourceFolderLabelControl;
    }
}
