namespace PE_Tools
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.databaseSettingsView1 = new PE_Tools.Views.DatabaseSettingsView();
            this.SuspendLayout();
            // 
            // titleLabelControl
            // 
            this.titleLabelControl.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelControl.Appearance.Options.UseFont = true;
            this.titleLabelControl.Location = new System.Drawing.Point(64, 13);
            this.titleLabelControl.Name = "titleLabelControl";
            this.titleLabelControl.Size = new System.Drawing.Size(80, 22);
            this.titleLabelControl.TabIndex = 23;
            this.titleLabelControl.Text = "PE Tools";
            // 
            // databaseSettingsView1
            // 
            this.databaseSettingsView1.Location = new System.Drawing.Point(64, 42);
            this.databaseSettingsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.databaseSettingsView1.Name = "databaseSettingsView1";
            this.databaseSettingsView1.Size = new System.Drawing.Size(1515, 917);
            this.databaseSettingsView1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 968);
            this.Controls.Add(this.databaseSettingsView1);
            this.Controls.Add(this.titleLabelControl);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "PE Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl titleLabelControl;
        private Views.DatabaseSettingsView databaseSettingsView1;
    }
}