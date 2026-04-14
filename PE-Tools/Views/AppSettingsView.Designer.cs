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
            lblDevelopmentFolder = new System.Windows.Forms.Label();
            txtDevelopmentFolder = new System.Windows.Forms.TextBox();
            btnBrowseDevFolder = new System.Windows.Forms.Button();
            btnBrowseC1 = new System.Windows.Forms.Button();
            btnBrowseDoc = new System.Windows.Forms.Button();
            panelNotifications = new System.Windows.Forms.Panel();
            btnTestNotification = new System.Windows.Forms.Button();
            lblNotificationSeconds = new System.Windows.Forms.Label();
            numNotificationDuration = new System.Windows.Forms.NumericUpDown();
            lblNotificationDuration = new System.Windows.Forms.Label();
            lblNotificationsSection = new System.Windows.Forms.Label();
            btnSaveAll = new System.Windows.Forms.Button();
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
            // panelConnection
            // 
            panelConnection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelConnection.Controls.Add(btnTestConnection);
            panelConnection.Controls.Add(txtConnectionString);
            panelConnection.Controls.Add(lblConnectionSection);
            panelConnection.Location = new System.Drawing.Point(16, 39);
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
            panelConfigPaths.Controls.Add(lblConfigPathsSection);
            panelConfigPaths.Controls.Add(lblC1ConfigPath);
            panelConfigPaths.Controls.Add(txtC1ConfigPath);
            panelConfigPaths.Controls.Add(btnBrowseC1);
            panelConfigPaths.Controls.Add(lblDocConfigPath);
            panelConfigPaths.Controls.Add(txtDocConfigPath);
            panelConfigPaths.Controls.Add(btnBrowseDoc);
            panelConfigPaths.Controls.Add(lblDevelopmentFolder);
            panelConfigPaths.Controls.Add(txtDevelopmentFolder);
            panelConfigPaths.Controls.Add(btnBrowseDevFolder);
            panelConfigPaths.Location = new System.Drawing.Point(16, 107);
            panelConfigPaths.Name = "panelConfigPaths";
            panelConfigPaths.Size = new System.Drawing.Size(768, 166);
            panelConfigPaths.TabIndex = 3;
            // 
            // txtDocConfigPath
            // 
            txtDocConfigPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDocConfigPath.Location = new System.Drawing.Point(3, 84);
            txtDocConfigPath.Name = "txtDocConfigPath";
            txtDocConfigPath.Size = new System.Drawing.Size(680, 23);
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
            // btnBrowseDoc
            // 
            btnBrowseDoc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnBrowseDoc.Location = new System.Drawing.Point(689, 82);
            btnBrowseDoc.Name = "btnBrowseDoc";
            btnBrowseDoc.Size = new System.Drawing.Size(74, 26);
            btnBrowseDoc.TabIndex = 5;
            btnBrowseDoc.Text = "Browse...";
            btnBrowseDoc.Click += btnBrowseDoc_Click;
            // 
            // txtC1ConfigPath
            // 
            txtC1ConfigPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtC1ConfigPath.Location = new System.Drawing.Point(3, 40);
            txtC1ConfigPath.Name = "txtC1ConfigPath";
            txtC1ConfigPath.Size = new System.Drawing.Size(680, 23);
            txtC1ConfigPath.TabIndex = 2;
            // 
            // btnBrowseC1
            // 
            btnBrowseC1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnBrowseC1.Location = new System.Drawing.Point(689, 38);
            btnBrowseC1.Name = "btnBrowseC1";
            btnBrowseC1.Size = new System.Drawing.Size(74, 26);
            btnBrowseC1.TabIndex = 3;
            btnBrowseC1.Text = "Browse...";
            btnBrowseC1.Click += btnBrowseC1_Click;
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
            // lblDevelopmentFolder
            // 
            lblDevelopmentFolder.AutoSize = true;
            lblDevelopmentFolder.Location = new System.Drawing.Point(3, 110);
            lblDevelopmentFolder.Name = "lblDevelopmentFolder";
            lblDevelopmentFolder.Size = new System.Drawing.Size(117, 15);
            lblDevelopmentFolder.TabIndex = 5;
            lblDevelopmentFolder.Text = "Development Folder:";
            // 
            // txtDevelopmentFolder
            // 
            txtDevelopmentFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDevelopmentFolder.Location = new System.Drawing.Point(3, 128);
            txtDevelopmentFolder.Name = "txtDevelopmentFolder";
            txtDevelopmentFolder.Size = new System.Drawing.Size(680, 23);
            txtDevelopmentFolder.TabIndex = 6;
            // 
            // btnBrowseDevFolder
            // 
            btnBrowseDevFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnBrowseDevFolder.Location = new System.Drawing.Point(689, 126);
            btnBrowseDevFolder.Name = "btnBrowseDevFolder";
            btnBrowseDevFolder.Size = new System.Drawing.Size(74, 26);
            btnBrowseDevFolder.TabIndex = 7;
            btnBrowseDevFolder.Text = "Browse...";
            btnBrowseDevFolder.Click += btnBrowseDevFolder_Click;
            // 
            // panelNotifications
            // 
            panelNotifications.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelNotifications.Controls.Add(btnTestNotification);
            panelNotifications.Controls.Add(lblNotificationSeconds);
            panelNotifications.Controls.Add(numNotificationDuration);
            panelNotifications.Controls.Add(lblNotificationDuration);
            panelNotifications.Controls.Add(lblNotificationsSection);
            panelNotifications.Location = new System.Drawing.Point(16, 279);
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
            btnSaveAll.Location = new System.Drawing.Point(644, 480);
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
            Controls.Add(lblTitle);
            Name = "AppSettingsView";
            Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            Size = new System.Drawing.Size(800, 524);
            Load += AppSettingsView_Load;
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
        private System.Windows.Forms.Label lblConnectionSection;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label lblConfigPathsSection;
        private System.Windows.Forms.Label lblC1ConfigPath;
        private System.Windows.Forms.TextBox txtC1ConfigPath;
        private System.Windows.Forms.Label lblDocConfigPath;
        private System.Windows.Forms.TextBox txtDocConfigPath;
        private System.Windows.Forms.Label lblDevelopmentFolder;
        private System.Windows.Forms.TextBox txtDevelopmentFolder;
        private System.Windows.Forms.Button btnBrowseDevFolder;
        private System.Windows.Forms.Button btnBrowseC1;
        private System.Windows.Forms.Button btnBrowseDoc;
        private System.Windows.Forms.Panel panelNotifications;
        private System.Windows.Forms.Label lblNotificationsSection;
        private System.Windows.Forms.Label lblNotificationDuration;
        private System.Windows.Forms.NumericUpDown numNotificationDuration;
        private System.Windows.Forms.Label lblNotificationSeconds;
        private System.Windows.Forms.Button btnTestNotification;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Panel panelConfigPaths;
    }
}
