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
            this.cbViews = new System.Windows.Forms.ComboBox();
            this.databaseSettingsView1 = new PE_Tools.Views.DatabaseSettingsView();
            this.powershellCommandsView1 = new PE_Tools.Views.PowershellCommandsView();
            this.SuspendLayout();
            // 
            // cbViews
            // 
            this.cbViews.FormattingEnabled = true;
            this.cbViews.Location = new System.Drawing.Point(5, 5);
            this.cbViews.Name = "cbViews";
            this.cbViews.Size = new System.Drawing.Size(114, 28);
            this.cbViews.TabIndex = 37;
            this.cbViews.SelectedIndexChanged += new System.EventHandler(this.cbViews_SelectedIndexChanged);
            // 
            // databaseSettingsView1
            // 
            this.databaseSettingsView1.Location = new System.Drawing.Point(5, 41);
            this.databaseSettingsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.databaseSettingsView1.Name = "databaseSettingsView1";
            this.databaseSettingsView1.Size = new System.Drawing.Size(1515, 598);
            this.databaseSettingsView1.TabIndex = 24;
            // 
            // powershellCommandsView1
            // 
            this.powershellCommandsView1.Location = new System.Drawing.Point(5, 41);
            this.powershellCommandsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powershellCommandsView1.Name = "powershellCommandsView1";
            this.powershellCommandsView1.Size = new System.Drawing.Size(1515, 598);
            this.powershellCommandsView1.TabIndex = 24;
            this.powershellCommandsView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PE_Tools.Properties.Resources.blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 649);
            this.Controls.Add(this.cbViews);
            this.Controls.Add(this.databaseSettingsView1);
            this.Controls.Add(this.powershellCommandsView1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "PE Tools";
            this.ResumeLayout(false);

        }

        #endregion
        private Views.DatabaseSettingsView databaseSettingsView1;
        private Views.PowershellCommandsView powershellCommandsView1;
        private System.Windows.Forms.ComboBox cbViews;
    }
}