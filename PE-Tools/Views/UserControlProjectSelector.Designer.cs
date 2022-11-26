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
            this.cbFolders = new System.Windows.Forms.ComboBox();
            this.SourceFolderLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // cbFolders
            // 
            this.cbFolders.FormattingEnabled = true;
            this.cbFolders.Location = new System.Drawing.Point(15, 37);
            this.cbFolders.Name = "cbFolders";
            this.cbFolders.Size = new System.Drawing.Size(364, 21);
            this.cbFolders.TabIndex = 39;
            this.cbFolders.SelectedIndexChanged += new System.EventHandler(this.cbFolders_SelectedIndexChanged);
            // 
            // SourceFolderLabelControl
            // 
            this.SourceFolderLabelControl.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceFolderLabelControl.Appearance.Options.UseFont = true;
            this.SourceFolderLabelControl.Location = new System.Drawing.Point(15, 14);
            this.SourceFolderLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SourceFolderLabelControl.Name = "SourceFolderLabelControl";
            this.SourceFolderLabelControl.Size = new System.Drawing.Size(123, 16);
            this.SourceFolderLabelControl.TabIndex = 38;
            this.SourceFolderLabelControl.Text = "Select Source Folder";
            // 
            // userControlProjectSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbFolders);
            this.Controls.Add(this.SourceFolderLabelControl);
            this.Name = "userControlProjectSelector";
            this.Size = new System.Drawing.Size(395, 71);
            this.Load += new System.EventHandler(this.userControlProjectSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFolders;
        private DevExpress.XtraEditors.LabelControl SourceFolderLabelControl;
    }
}
