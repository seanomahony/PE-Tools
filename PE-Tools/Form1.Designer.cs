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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPageDatabases = new System.Windows.Forms.TabPage();
            databaseSettingsView1 = new PE_Tools.Views.DatabaseSettingsView();
            tabPagePowershell = new System.Windows.Forms.TabPage();
            powershellCommandsView1 = new PE_Tools.Views.PowershellCommandsView();
            projectSelector = new PE_Tools.Views.UserControlProjectSelector();
            tabControl1.SuspendLayout();
            tabPageDatabases.SuspendLayout();
            tabPagePowershell.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageDatabases);
            tabControl1.Controls.Add(tabPagePowershell);
            tabControl1.Location = new System.Drawing.Point(0, 85);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1582, 564);
            tabControl1.TabIndex = 1;
            // 
            // tabPageDatabases
            // 
            tabPageDatabases.Controls.Add(databaseSettingsView1);
            tabPageDatabases.Location = new System.Drawing.Point(4, 29);
            tabPageDatabases.Name = "tabPageDatabases";
            tabPageDatabases.Padding = new System.Windows.Forms.Padding(3);
            tabPageDatabases.Size = new System.Drawing.Size(1574, 531);
            tabPageDatabases.TabIndex = 0;
            tabPageDatabases.Text = "Databases";
            tabPageDatabases.UseVisualStyleBackColor = true;
            // 
            // databaseSettingsView1
            // 
            databaseSettingsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            databaseSettingsView1.Location = new System.Drawing.Point(3, 3);
            databaseSettingsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            databaseSettingsView1.Name = "databaseSettingsView1";
            databaseSettingsView1.Size = new System.Drawing.Size(1568, 525);
            databaseSettingsView1.TabIndex = 0;
            // 
            // tabPagePowershell
            // 
            tabPagePowershell.Controls.Add(powershellCommandsView1);
            tabPagePowershell.Location = new System.Drawing.Point(4, 29);
            tabPagePowershell.Name = "tabPagePowershell";
            tabPagePowershell.Padding = new System.Windows.Forms.Padding(3);
            tabPagePowershell.Size = new System.Drawing.Size(1574, 531);
            tabPagePowershell.TabIndex = 1;
            tabPagePowershell.Text = "Powershell";
            tabPagePowershell.UseVisualStyleBackColor = true;
            // 
            // powershellCommandsView1
            // 
            powershellCommandsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            powershellCommandsView1.Location = new System.Drawing.Point(3, 3);
            powershellCommandsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            powershellCommandsView1.Name = "powershellCommandsView1";
            powershellCommandsView1.Size = new System.Drawing.Size(1568, 525);
            powershellCommandsView1.TabIndex = 0;
            // 
            // projectSelector
            // 
            projectSelector.Location = new System.Drawing.Point(5, 5);
            projectSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            projectSelector.Name = "projectSelector";
            projectSelector.Size = new System.Drawing.Size(564, 75);
            projectSelector.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1582, 649);
            Controls.Add(projectSelector);
            Controls.Add(tabControl1);
            Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "PE Tools";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageDatabases.ResumeLayout(false);
            tabPagePowershell.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Views.UserControlProjectSelector projectSelector;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDatabases;
        private System.Windows.Forms.TabPage tabPagePowershell;
        private Views.DatabaseSettingsView databaseSettingsView1;
        private Views.PowershellCommandsView powershellCommandsView1;
    }
}