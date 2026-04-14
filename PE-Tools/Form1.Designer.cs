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
            mainSplitContainer = new System.Windows.Forms.SplitContainer();
            btnToggleSidebar = new System.Windows.Forms.Button();
            btnDatabases = new System.Windows.Forms.Button();
            btnPowerShell = new System.Windows.Forms.Button();
            btnKubectl = new System.Windows.Forms.Button();
            btnSettings = new System.Windows.Forms.Button();
            btnShowSidebar = new System.Windows.Forms.Button();
            imageList1 = new System.Windows.Forms.ImageList();
            databaseSettingsView1 = new PE_Tools.Views.DatabaseSettingsView();
            powershellCommandsView1 = new PE_Tools.Views.PowershellCommandsView();
            kubectlCommandsView1 = new PE_Tools.Views.KubectlCommandsView();
            appSettingsView1 = new PE_Tools.Views.AppSettingsView();
            SuspendLayout();
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            mainSplitContainer.Name = "mainSplitContainer";
            // Panel1 = sidebar, Panel2 = content
            mainSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(8);
            mainSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(8);
            mainSplitContainer.Size = new System.Drawing.Size(1582, 750);
            mainSplitContainer.SplitterDistance = 200;
            mainSplitContainer.TabIndex = 0;
            // 
            // sidebarTimer
            // 
            sidebarTimer = new System.Windows.Forms.Timer();
            sidebarTimer.Interval = 15;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // btnDatabases
            // 
            btnDatabases.Dock = System.Windows.Forms.DockStyle.Top;
            btnDatabases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDatabases.FlatAppearance.BorderSize = 0;
            btnDatabases.ImageIndex = 0;
            btnDatabases.ImageList = imageList1;
            btnDatabases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDatabases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDatabases.Location = new System.Drawing.Point(8, 40);
            btnDatabases.Name = "btnDatabases";
            btnDatabases.Size = new System.Drawing.Size(184, 48);
            btnDatabases.TabIndex = 0;
            btnDatabases.Text = "&Databases";
            btnDatabases.UseVisualStyleBackColor = true;
            btnDatabases.Click += btnDatabases_Click;
            btnDatabases.MouseEnter += btnSidebarButton_MouseEnter;
            btnDatabases.MouseLeave += btnSidebarButton_MouseLeave;
            btnDatabases.MouseDown += btnSidebarButton_MouseDown;
            btnDatabases.MouseUp += btnSidebarButton_MouseUp;
            // 
            // btnPowerShell
            // 
            btnPowerShell.Dock = System.Windows.Forms.DockStyle.Top;
            btnPowerShell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPowerShell.FlatAppearance.BorderSize = 0;
            btnPowerShell.ImageIndex = 1;
            btnPowerShell.ImageList = imageList1;
            btnPowerShell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPowerShell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnPowerShell.Location = new System.Drawing.Point(8, 88);
            btnPowerShell.Name = "btnPowerShell";
            btnPowerShell.Size = new System.Drawing.Size(184, 48);
            btnPowerShell.TabIndex = 1;
            btnPowerShell.Text = "&PowerShell";
            btnPowerShell.UseVisualStyleBackColor = true;
            btnPowerShell.Click += btnPowerShell_Click;
            btnPowerShell.MouseEnter += btnSidebarButton_MouseEnter;
            btnPowerShell.MouseLeave += btnSidebarButton_MouseLeave;
            btnPowerShell.MouseDown += btnSidebarButton_MouseDown;
            btnPowerShell.MouseUp += btnSidebarButton_MouseUp;
            // 
            // btnKubectl
            // 
            btnKubectl.Dock = System.Windows.Forms.DockStyle.Top;
            btnKubectl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKubectl.FlatAppearance.BorderSize = 0;
            btnKubectl.ImageIndex = 2;
            btnKubectl.ImageList = imageList1;
            btnKubectl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnKubectl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnKubectl.Location = new System.Drawing.Point(8, 136);
            btnKubectl.Name = "btnKubectl";
            btnKubectl.Size = new System.Drawing.Size(184, 48);
            btnKubectl.TabIndex = 2;
            btnKubectl.Text = "&Kubectl";
            btnKubectl.UseVisualStyleBackColor = true;
            btnKubectl.Click += btnKubectl_Click;
            btnKubectl.MouseEnter += btnSidebarButton_MouseEnter;
            btnKubectl.MouseLeave += btnSidebarButton_MouseLeave;
            btnKubectl.MouseDown += btnSidebarButton_MouseDown;
            btnKubectl.MouseUp += btnSidebarButton_MouseUp;
            // 
            // btnSettings
            // 
            btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.ImageIndex = 3;
            btnSettings.ImageList = imageList1;
            btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSettings.Location = new System.Drawing.Point(8, 184);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new System.Drawing.Size(184, 48);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "&Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            btnSettings.MouseEnter += btnSidebarButton_MouseEnter;
            btnSettings.MouseLeave += btnSidebarButton_MouseLeave;
            btnSettings.MouseDown += btnSidebarButton_MouseDown;
            btnSettings.MouseUp += btnSidebarButton_MouseUp;

            // btnToggleSidebar
            // 
            btnToggleSidebar.Dock = System.Windows.Forms.DockStyle.Top;
            btnToggleSidebar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnToggleSidebar.Location = new System.Drawing.Point(8, 8);
            btnToggleSidebar.Name = "btnToggleSidebar";
            btnToggleSidebar.Size = new System.Drawing.Size(184, 32);
            btnToggleSidebar.TabIndex = 99;
            btnToggleSidebar.Text = "<<";
            btnToggleSidebar.UseVisualStyleBackColor = true;
            btnToggleSidebar.Click += btnToggleSidebar_Click;
            btnToggleSidebar.MouseEnter += btnSidebarButton_MouseEnter;
            btnToggleSidebar.MouseLeave += btnSidebarButton_MouseLeave;

            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageSize = new System.Drawing.Size(16, 16);
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // load custom images from resources (replace these names with actual resources)
            try
            {
                var rm = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                var img0 = ((System.Drawing.Image)(rm.GetObject("icon_databases")));
                var img1 = ((System.Drawing.Image)(rm.GetObject("icon_powershell")));
                var img2 = ((System.Drawing.Image)(rm.GetObject("icon_kubectl")));
                var img3 = ((System.Drawing.Image)(rm.GetObject("icon_settings")));
                if (img0 != null)
                {
                    imageList1.Images.Add(img0);
                }
                if (img1 != null)
                {
                    imageList1.Images.Add(img1);
                }
                if (img2 != null)
                {
                    imageList1.Images.Add(img2);
                }
                if (img3 != null)
                {
                    imageList1.Images.Add(img3);
                }
            }
            catch
            {
                // ignore and leave ImageList empty if resources missing
            }
            // 
            // (Panel2 of mainSplitContainer will hold content controls)
            // 
            // btnShowSidebar
            // 
            btnShowSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            btnShowSidebar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnShowSidebar.Location = new System.Drawing.Point(8, 8);
            btnShowSidebar.Name = "btnShowSidebar";
            btnShowSidebar.Size = new System.Drawing.Size(28, 32);
            btnShowSidebar.TabIndex = 100;
            btnShowSidebar.Text = ">>";
            btnShowSidebar.UseVisualStyleBackColor = true;
            btnShowSidebar.Visible = false;
            btnShowSidebar.Click += btnShowSidebar_Click;

            // databaseSettingsView1
            // 
            databaseSettingsView1.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            databaseSettingsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            databaseSettingsView1.Location = new System.Drawing.Point(8, 8);
            databaseSettingsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            databaseSettingsView1.Name = "databaseSettingsView1";
            databaseSettingsView1.Padding = new System.Windows.Forms.Padding(8);
            databaseSettingsView1.Size = new System.Drawing.Size(1366, 734);
            databaseSettingsView1.TabIndex = 0;
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
            powershellCommandsView1.Size = new System.Drawing.Size(1366, 734);
            powershellCommandsView1.TabIndex = 0;
            // 
            // kubectlCommandsView1
            // 
            kubectlCommandsView1.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            kubectlCommandsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            kubectlCommandsView1.Location = new System.Drawing.Point(8, 8);
            kubectlCommandsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            kubectlCommandsView1.Name = "kubectlCommandsView1";
            kubectlCommandsView1.Padding = new System.Windows.Forms.Padding(8);
            kubectlCommandsView1.Size = new System.Drawing.Size(1366, 734);
            kubectlCommandsView1.TabIndex = 0;
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
            appSettingsView1.Size = new System.Drawing.Size(1366, 734);
            appSettingsView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1582, 750);
            Controls.Add(mainSplitContainer);
            Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(1200, 600);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PE Tools";
            Load += Form1_Load;

            // Compose hierarchy
            mainSplitContainer.Panel1.Controls.Add(btnSettings);
            mainSplitContainer.Panel1.Controls.Add(btnKubectl);
            mainSplitContainer.Panel1.Controls.Add(btnPowerShell);
            mainSplitContainer.Panel1.Controls.Add(btnDatabases);
            mainSplitContainer.Panel1.Controls.Add(btnToggleSidebar);

            mainSplitContainer.Panel2.Controls.Add(appSettingsView1);
            mainSplitContainer.Panel2.Controls.Add(kubectlCommandsView1);
            mainSplitContainer.Panel2.Controls.Add(powershellCommandsView1);
            mainSplitContainer.Panel2.Controls.Add(databaseSettingsView1);
            mainSplitContainer.Panel2.Controls.Add(btnShowSidebar);

            // initial visibility
            databaseSettingsView1.Visible = true;
            powershellCommandsView1.Visible = false;
            kubectlCommandsView1.Visible = false;
            appSettingsView1.Visible = false;

            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Button btnToggleSidebar;
        private System.Windows.Forms.Button btnDatabases;
        private System.Windows.Forms.Button btnPowerShell;
        private System.Windows.Forms.Button btnKubectl;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnShowSidebar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Views.DatabaseSettingsView databaseSettingsView1;
        private Views.PowershellCommandsView powershellCommandsView1;
        private Views.AppSettingsView appSettingsView1;
        private Views.KubectlCommandsView kubectlCommandsView1;
    }
}