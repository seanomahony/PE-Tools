namespace PE_Tools.Views
{
    partial class AppSettingsView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            panelFolders = new System.Windows.Forms.Panel();
            btnRemoveFolder = new System.Windows.Forms.Button();
            btnAddFolder = new System.Windows.Forms.Button();
            btnBrowseFolder = new System.Windows.Forms.Button();
            txtNewFolder = new System.Windows.Forms.TextBox();
            lstFolders = new System.Windows.Forms.ListBox();
            lblFoldersSection = new System.Windows.Forms.Label();
            panelConnection = new System.Windows.Forms.Panel();
            btnTestConnection = new System.Windows.Forms.Button();
            txtConnectionString = new System.Windows.Forms.TextBox();
            lblConnectionSection = new System.Windows.Forms.Label();
            panelConfigPaths = new System.Windows.Forms.Panel();
            txtDocConfigPath = new System.Windows.Forms.TextBox();
            lblDocConfigPath = new System.Windows.Forms.Label();
            txtC1ConfigPath = new System.Windows.Forms.TextBox();
            lblC1ConfigPath = new System.Windows.Forms.Label();
            lblConfigPathsSection = new System.Windows.Forms.Label();
            panelNotifications = new System.Windows.Forms.Panel();
            btnTestNotification = new System.Windows.Forms.Button();
            lblNotificationSeconds = new System.Windows.Forms.Label();
            numNotificationDuration = new System.Windows.Forms.NumericUpDown();
            lblNotificationDuration = new System.Windows.Forms.Label();
            lblNotificationsSection = new System.Windows.Forms.Label();
            btnSaveAll = new System.Windows.Forms.Button();
            panelFolders.SuspendLayout();
            panelConnection.SuspendLayout();
            panelConfigPaths.SuspendLayout();
            panelNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNotificationDuration).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(16, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(191, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Application Settings";
            // 
            // panelFolders
            // 
            panelFolders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelFolders.Controls.Add(btnRemoveFolder);
            panelFolders.Controls.Add(btnAddFolder);
            panelFolders.Controls.Add(btnBrowseFolder);
            panelFolders.Controls.Add(txtNewFolder);
            panelFolders.Controls.Add(lstFolders);
            panelFolders.Controls.Add(lblFoldersSection);
            panelFolders.Location = new System.Drawing.Point(16, 40);
            panelFolders.Name = "panelFolders";
            panelFolders.Size = new System.Drawing.Size(768, 137);
            panelFolders.TabIndex = 1;
            // 
            // btnRemoveFolder
            // 
            btnRemoveFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRemoveFolder.Location = new System.Drawing.Point(678, 53);
            btnRemoveFolder.Name = "btnRemoveFolder";
            btnRemoveFolder.Size = new System.Drawing.Size(85, 26);
            btnRemoveFolder.TabIndex = 5;
            btnRemoveFolder.Text = "Remove";
            btnRemoveFolder.Click += btnRemoveFolder_Click;
            // 
            // btnAddFolder
            // 
            btnAddFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddFolder.Location = new System.Drawing.Point(678, 21);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Size = new System.Drawing.Size(85, 26);
            btnAddFolder.TabIndex = 4;
            btnAddFolder.Text = "Add";
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // btnBrowseFolder
            // 
            btnBrowseFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnBrowseFolder.Location = new System.Drawing.Point(678, 105);
            btnBrowseFolder.Name = "btnBrowseFolder";
            btnBrowseFolder.Size = new System.Drawing.Size(85, 25);
            btnBrowseFolder.TabIndex = 3;
            btnBrowseFolder.Text = "Browse...";
            btnBrowseFolder.Click += btnBrowseFolder_Click;
            // 
            // txtNewFolder
            // 
            txtNewFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNewFolder.Location = new System.Drawing.Point(3, 107);
            txtNewFolder.Name = "txtNewFolder";
            txtNewFolder.PlaceholderText = "Enter folder path or browse...";
            txtNewFolder.Size = new System.Drawing.Size(579, 23);
            txtNewFolder.TabIndex = 2;
            txtNewFolder.TextChanged += txtNewFolder_TextChanged;
            txtNewFolder.KeyPress += txtNewFolder_KeyPress;
            // 
            // lstFolders
            // 
            lstFolders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstFolders.FormattingEnabled = true;
            lstFolders.Location = new System.Drawing.Point(3, 21);
            lstFolders.Name = "lstFolders";
            lstFolders.Size = new System.Drawing.Size(669, 79);
            lstFolders.TabIndex = 1;
            lstFolders.SelectedIndexChanged += lstFolders_SelectedIndexChanged;
            // 
            // lblFoldersSection
            // 
            lblFoldersSection.AutoSize = true;
            lblFoldersSection.Location = new System.Drawing.Point(3, 4);
            lblFoldersSection.Name = "lblFoldersSection";
            lblFoldersSection.Size = new System.Drawing.Size(85, 15);
            lblFoldersSection.TabIndex = 0;
            lblFoldersSection.Text = "Project Folders";
            // 
            // panelConnection
            // 
            panelConnection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelConnection.Controls.Add(btnTestConnection);
            panelConnection.Controls.Add(txtConnectionString);
            panelConnection.Controls.Add(lblConnectionSection);
            panelConnection.Location = new System.Drawing.Point(16, 185);
            panelConnection.Name = "panelConnection";
            panelConnection.Size = new System.Drawing.Size(768, 62);
            panelConnection.TabIndex = 2;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnTestConnection.Location = new System.Drawing.Point(648, 19);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new System.Drawing.Size(115, 26);
            btnTestConnection.TabIndex = 2;
            btnTestConnection.Text = "Test Connection";
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtConnectionString.Location = new System.Drawing.Point(3, 21);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.PlaceholderText = "server=localhost;Integrated Security=True;Pooling=True;";
            txtConnectionString.Size = new System.Drawing.Size(639, 23);
            txtConnectionString.TabIndex = 1;
            // 
            // lblConnectionSection
            // 
            lblConnectionSection.AutoSize = true;
            lblConnectionSection.Location = new System.Drawing.Point(3, 4);
            lblConnectionSection.Name = "lblConnectionSection";
            lblConnectionSection.Size = new System.Drawing.Size(154, 15);
            lblConnectionSection.TabIndex = 0;
            lblConnectionSection.Text = "Database Connection String";
            // 
            // panelConfigPaths
            // 
            panelConfigPaths.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelConfigPaths.Controls.Add(txtDocConfigPath);
            panelConfigPaths.Controls.Add(lblDocConfigPath);
            panelConfigPaths.Controls.Add(txtC1ConfigPath);
            panelConfigPaths.Controls.Add(lblC1ConfigPath);
            panelConfigPaths.Controls.Add(lblConfigPathsSection);
            panelConfigPaths.Location = new System.Drawing.Point(16, 256);
            panelConfigPaths.Name = "panelConfigPaths";
            panelConfigPaths.Size = new System.Drawing.Size(768, 110);
            panelConfigPaths.TabIndex = 3;
            // 
            // txtDocConfigPath
            // 
            txtDocConfigPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDocConfigPath.Location = new System.Drawing.Point(3, 84);
            txtDocConfigPath.Name = "txtDocConfigPath";
            txtDocConfigPath.Size = new System.Drawing.Size(760, 23);
            txtDocConfigPath.TabIndex = 4;
            // 
            // lblDocConfigPath
            // 
            lblDocConfigPath.AutoSize = true;
            lblDocConfigPath.Location = new System.Drawing.Point(3, 66);
            lblDocConfigPath.Name = "lblDocConfigPath";
            lblDocConfigPath.Size = new System.Drawing.Size(121, 15);
            lblDocConfigPath.TabIndex = 3;
            lblDocConfigPath.Text = "Doc Config Filename:";
            // 
            // txtC1ConfigPath
            // 
            txtC1ConfigPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtC1ConfigPath.Location = new System.Drawing.Point(3, 40);
            txtC1ConfigPath.Name = "txtC1ConfigPath";
            txtC1ConfigPath.Size = new System.Drawing.Size(760, 23);
            txtC1ConfigPath.TabIndex = 2;
            // 
            // lblC1ConfigPath
            // 
            lblC1ConfigPath.AutoSize = true;
            lblC1ConfigPath.Location = new System.Drawing.Point(3, 22);
            lblC1ConfigPath.Name = "lblC1ConfigPath";
            lblC1ConfigPath.Size = new System.Drawing.Size(114, 15);
            lblC1ConfigPath.TabIndex = 1;
            lblC1ConfigPath.Text = "C1 Config Filename:";
            // 
            // lblConfigPathsSection
            // 
            lblConfigPathsSection.AutoSize = true;
            lblConfigPathsSection.Location = new System.Drawing.Point(3, 4);
            lblConfigPathsSection.Name = "lblConfigPathsSection";
            lblConfigPathsSection.Size = new System.Drawing.Size(134, 15);
            lblConfigPathsSection.TabIndex = 0;
            lblConfigPathsSection.Text = "Configuration File Paths";
            // 
            // panelNotifications
            // 
            panelNotifications.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelNotifications.Controls.Add(btnTestNotification);
            panelNotifications.Controls.Add(lblNotificationSeconds);
            panelNotifications.Controls.Add(numNotificationDuration);
            panelNotifications.Controls.Add(lblNotificationDuration);
            panelNotifications.Controls.Add(lblNotificationsSection);
            panelNotifications.Location = new System.Drawing.Point(16, 375);
            panelNotifications.Name = "panelNotifications";
            panelNotifications.Size = new System.Drawing.Size(768, 62);
            panelNotifications.TabIndex = 4;
            // 
            // btnTestNotification
            // 
            btnTestNotification.Location = new System.Drawing.Point(690, 30);
            btnTestNotification.Name = "btnTestNotification";
            btnTestNotification.Size = new System.Drawing.Size(75, 25);
            btnTestNotification.TabIndex = 4;
            btnTestNotification.Text = "Test";
            btnTestNotification.Click += btnTestNotification_Click;
            // 
            // lblNotificationSeconds
            // 
            lblNotificationSeconds.AutoSize = true;
            lblNotificationSeconds.Location = new System.Drawing.Point(88, 35);
            lblNotificationSeconds.Name = "lblNotificationSeconds";
            lblNotificationSeconds.Size = new System.Drawing.Size(50, 15);
            lblNotificationSeconds.TabIndex = 3;
            lblNotificationSeconds.Text = "seconds";
            // 
            // numNotificationDuration
            // 
            numNotificationDuration.Location = new System.Drawing.Point(3, 34);
            numNotificationDuration.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numNotificationDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numNotificationDuration.Name = "numNotificationDuration";
            numNotificationDuration.Size = new System.Drawing.Size(75, 23);
            numNotificationDuration.TabIndex = 2;
            numNotificationDuration.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblNotificationDuration
            // 
            lblNotificationDuration.AutoSize = true;
            lblNotificationDuration.Location = new System.Drawing.Point(3, 16);
            lblNotificationDuration.Name = "lblNotificationDuration";
            lblNotificationDuration.Size = new System.Drawing.Size(138, 15);
            lblNotificationDuration.TabIndex = 1;
            lblNotificationDuration.Text = "Default Display Duration:";
            // 
            // lblNotificationsSection
            // 
            lblNotificationsSection.AutoSize = true;
            lblNotificationsSection.Location = new System.Drawing.Point(3, 0);
            lblNotificationsSection.Name = "lblNotificationsSection";
            lblNotificationsSection.Size = new System.Drawing.Size(75, 15);
            lblNotificationsSection.TabIndex = 0;
            lblNotificationsSection.Text = "Notifications";
            // 
            // btnSaveAll
            // 
            btnSaveAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSaveAll.Location = new System.Drawing.Point(644, 450);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new System.Drawing.Size(140, 31);
            btnSaveAll.TabIndex = 5;
            btnSaveAll.Text = "Save All Settings";
            btnSaveAll.Click += btnSaveAll_Click;
            // 
            // AppSettingsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btnSaveAll);
            Controls.Add(panelNotifications);
            Controls.Add(panelConfigPaths);
            Controls.Add(panelConnection);
            Controls.Add(panelFolders);
            Controls.Add(lblTitle);
            Name = "AppSettingsView";
            Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            Size = new System.Drawing.Size(800, 494);
            Load += AppSettingsView_Load;
            panelFolders.ResumeLayout(false);
            panelFolders.PerformLayout();
            panelConnection.ResumeLayout(false);
            panelConnection.PerformLayout();
            panelConfigPaths.ResumeLayout(false);
            panelConfigPaths.PerformLayout();
            panelNotifications.ResumeLayout(false);
            panelNotifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNotificationDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFoldersSection;
        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.TextBox txtNewFolder;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnRemoveFolder;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.Label lblConnectionSection;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label lblConfigPathsSection;
        private System.Windows.Forms.Label lblC1ConfigPath;
        private System.Windows.Forms.TextBox txtC1ConfigPath;
        private System.Windows.Forms.Label lblDocConfigPath;
        private System.Windows.Forms.TextBox txtDocConfigPath;
        private System.Windows.Forms.Panel panelNotifications;
        private System.Windows.Forms.Label lblNotificationsSection;
        private System.Windows.Forms.Label lblNotificationDuration;
        private System.Windows.Forms.NumericUpDown numNotificationDuration;
        private System.Windows.Forms.Label lblNotificationSeconds;
        private System.Windows.Forms.Button btnTestNotification;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Panel panelFolders;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Panel panelConfigPaths;
    }
}
