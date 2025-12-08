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
            tabPageSettings = new System.Windows.Forms.TabPage();
            appSettingsView1 = new PE_Tools.Views.AppSettingsView();
            projectSelector = new PE_Tools.Views.UserControlProjectSelector();
            tabControl1.SuspendLayout();
            tabPageDatabases.SuspendLayout();
            tabPagePowershell.SuspendLayout();
            tabPageSettings.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageDatabases);
            tabControl1.Controls.Add(tabPagePowershell);
            tabControl1.Controls.Add(tabPageSettings);
            tabControl1.Location = new System.Drawing.Point(12, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new System.Drawing.Point(12, 6);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1558, 547);
            tabControl1.TabIndex = 1;
            // 
            // tabPageDatabases
            // 
            tabPageDatabases.Controls.Add(databaseSettingsView1);
            tabPageDatabases.Location = new System.Drawing.Point(4, 35);
            tabPageDatabases.Name = "tabPageDatabases";
            tabPageDatabases.Padding = new System.Windows.Forms.Padding(8);
            tabPageDatabases.Size = new System.Drawing.Size(1550, 508);
            tabPageDatabases.TabIndex = 0;
            tabPageDatabases.Text = "Databases";
            // 
            // databaseSettingsView1
            // 
            databaseSettingsView1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            databaseSettingsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            databaseSettingsView1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            databaseSettingsView1.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            databaseSettingsView1.Location = new System.Drawing.Point(8, 8);
            databaseSettingsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            databaseSettingsView1.Name = "databaseSettingsView1";
            databaseSettingsView1.Padding = new System.Windows.Forms.Padding(8);
            databaseSettingsView1.Size = new System.Drawing.Size(1534, 492);
            databaseSettingsView1.TabIndex = 0;
            // 
            // tabPagePowershell
            // 
            tabPagePowershell.Controls.Add(powershellCommandsView1);
            tabPagePowershell.Location = new System.Drawing.Point(4, 35);
            tabPagePowershell.Name = "tabPagePowershell";
            tabPagePowershell.Padding = new System.Windows.Forms.Padding(8);
            tabPagePowershell.Size = new System.Drawing.Size(1550, 508);
            tabPagePowershell.TabIndex = 1;
            tabPagePowershell.Text = "PowerShell";
            // 
            // powershellCommandsView1
            // 
            powershellCommandsView1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            powershellCommandsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            powershellCommandsView1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            powershellCommandsView1.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            powershellCommandsView1.Location = new System.Drawing.Point(8, 8);
            powershellCommandsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            powershellCommandsView1.Name = "powershellCommandsView1";
            powershellCommandsView1.Padding = new System.Windows.Forms.Padding(8);
            powershellCommandsView1.Size = new System.Drawing.Size(1534, 492);
            powershellCommandsView1.TabIndex = 0;
            // 
            // tabPageSettings
            // 
            tabPageSettings.Controls.Add(appSettingsView1);
            tabPageSettings.Location = new System.Drawing.Point(4, 35);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new System.Windows.Forms.Padding(8);
            tabPageSettings.Size = new System.Drawing.Size(1550, 508);
            tabPageSettings.TabIndex = 2;
            tabPageSettings.Text = "Settings";
            // 
            // appSettingsView1
            // 
            appSettingsView1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            appSettingsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            appSettingsView1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            appSettingsView1.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            appSettingsView1.Location = new System.Drawing.Point(8, 8);
            appSettingsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            appSettingsView1.Name = "appSettingsView1";
            appSettingsView1.Padding = new System.Windows.Forms.Padding(8);
            appSettingsView1.Size = new System.Drawing.Size(1534, 492);
            appSettingsView1.TabIndex = 0;
            // 
            // projectSelector
            // 
            projectSelector.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            projectSelector.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            projectSelector.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            projectSelector.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            projectSelector.Location = new System.Drawing.Point(12, 12);
            projectSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            projectSelector.Name = "projectSelector";
            projectSelector.Padding = new System.Windows.Forms.Padding(4);
            projectSelector.Size = new System.Drawing.Size(1558, 70);
            projectSelector.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1582, 649);
            Controls.Add(projectSelector);
            Controls.Add(tabControl1);
            Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(1200, 600);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PE Tools";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageDatabases.ResumeLayout(false);
            tabPagePowershell.ResumeLayout(false);
            tabPageSettings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Views.UserControlProjectSelector projectSelector;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDatabases;
        private System.Windows.Forms.TabPage tabPagePowershell;
        private System.Windows.Forms.TabPage tabPageSettings;
        private Views.DatabaseSettingsView databaseSettingsView1;
        private Views.PowershellCommandsView powershellCommandsView1;
        private Views.AppSettingsView appSettingsView1;
    }
}