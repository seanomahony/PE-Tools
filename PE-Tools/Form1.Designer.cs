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
            tabPageKubectl = new System.Windows.Forms.TabPage();
            kubectlCommandsView1 = new PE_Tools.Views.KubectlCommandsView();
            tabPageSettings = new System.Windows.Forms.TabPage();
            appSettingsView1 = new PE_Tools.Views.AppSettingsView();
            tabControl1.SuspendLayout();
            tabPageDatabases.SuspendLayout();
            tabPagePowershell.SuspendLayout();
            tabPageKubectl.SuspendLayout();
            tabPageSettings.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageDatabases);
            tabControl1.Controls.Add(tabPagePowershell);
            tabControl1.Controls.Add(tabPageKubectl);
            tabControl1.Controls.Add(tabPageSettings);
            tabControl1.ItemSize = new System.Drawing.Size(100, 34);
            tabControl1.Location = new System.Drawing.Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1558, 726);
            tabControl1.TabIndex = 1;
            // 
            // tabPageDatabases
            // 
            tabPageDatabases.Controls.Add(databaseSettingsView1);
            tabPageDatabases.Location = new System.Drawing.Point(4, 38);
            tabPageDatabases.Name = "tabPageDatabases";
            tabPageDatabases.Padding = new System.Windows.Forms.Padding(8);
            tabPageDatabases.Size = new System.Drawing.Size(1550, 684);
            tabPageDatabases.TabIndex = 0;
            tabPageDatabases.Text = "Databases";
            // 
            // databaseSettingsView1
            // 
            databaseSettingsView1.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            databaseSettingsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            databaseSettingsView1.Location = new System.Drawing.Point(8, 8);
            databaseSettingsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            databaseSettingsView1.Name = "databaseSettingsView1";
            databaseSettingsView1.Padding = new System.Windows.Forms.Padding(8);
            databaseSettingsView1.Size = new System.Drawing.Size(1534, 668);
            databaseSettingsView1.TabIndex = 0;
            // 
            // tabPagePowershell
            // 
            tabPagePowershell.Controls.Add(powershellCommandsView1);
            tabPagePowershell.Location = new System.Drawing.Point(4, 38);
            tabPagePowershell.Name = "tabPagePowershell";
            tabPagePowershell.Padding = new System.Windows.Forms.Padding(8);
            tabPagePowershell.Size = new System.Drawing.Size(1550, 606);
            tabPagePowershell.TabIndex = 1;
            tabPagePowershell.Text = "PowerShell";
            // 
            // powershellCommandsView1
            // 
            powershellCommandsView1.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            powershellCommandsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            powershellCommandsView1.Location = new System.Drawing.Point(8, 8);
            powershellCommandsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            powershellCommandsView1.MinimumSize = new System.Drawing.Size(986, 397);
            powershellCommandsView1.Name = "powershellCommandsView1";
            powershellCommandsView1.Padding = new System.Windows.Forms.Padding(8);
            powershellCommandsView1.Size = new System.Drawing.Size(1534, 590);
            powershellCommandsView1.TabIndex = 0;
            // 
            // tabPageKubectl
            // 
            tabPageKubectl.Controls.Add(kubectlCommandsView1);
            tabPageKubectl.Location = new System.Drawing.Point(4, 38);
            tabPageKubectl.Name = "tabPageKubectl";
            tabPageKubectl.Padding = new System.Windows.Forms.Padding(8);
            tabPageKubectl.Size = new System.Drawing.Size(1550, 606);
            tabPageKubectl.TabIndex = 3;
            tabPageKubectl.Text = "Kubectl";
            // 
            // kubectlCommandsView1
            // 
            kubectlCommandsView1.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            kubectlCommandsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            kubectlCommandsView1.Location = new System.Drawing.Point(8, 8);
            kubectlCommandsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kubectlCommandsView1.Name = "kubectlCommandsView1";
            kubectlCommandsView1.Padding = new System.Windows.Forms.Padding(8);
            kubectlCommandsView1.Size = new System.Drawing.Size(1534, 590);
            kubectlCommandsView1.TabIndex = 0;
            // 
            // tabPageSettings
            // 
            tabPageSettings.Controls.Add(appSettingsView1);
            tabPageSettings.Location = new System.Drawing.Point(4, 38);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new System.Windows.Forms.Padding(8);
            tabPageSettings.Size = new System.Drawing.Size(1550, 606);
            tabPageSettings.TabIndex = 2;
            tabPageSettings.Text = "Settings";
            // 
            // appSettingsView1
            // 
            appSettingsView1.AutoScroll = true;
            appSettingsView1.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            appSettingsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            appSettingsView1.Location = new System.Drawing.Point(8, 8);
            appSettingsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            appSettingsView1.Name = "appSettingsView1";
            appSettingsView1.Padding = new System.Windows.Forms.Padding(8);
            appSettingsView1.Size = new System.Drawing.Size(1534, 590);
            appSettingsView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1582, 750);
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
            tabPageKubectl.ResumeLayout(false);
            tabPageSettings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDatabases;
        private System.Windows.Forms.TabPage tabPagePowershell;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageKubectl;
        private Views.DatabaseSettingsView databaseSettingsView1;
        private Views.PowershellCommandsView powershellCommandsView1;
        private Views.AppSettingsView appSettingsView1;
        private Views.KubectlCommandsView kubectlCommandsView1;
    }
}