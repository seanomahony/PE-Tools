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
            lblFoldersSection = new System.Windows.Forms.Label();
            lstFolders = new System.Windows.Forms.ListBox();
            txtNewFolder = new System.Windows.Forms.TextBox();
            btnAddFolder = new System.Windows.Forms.Button();
            btnRemoveFolder = new System.Windows.Forms.Button();
            btnBrowseFolder = new System.Windows.Forms.Button();
            lblConnectionSection = new System.Windows.Forms.Label();
            txtConnectionString = new System.Windows.Forms.TextBox();
            btnTestConnection = new System.Windows.Forms.Button();
            lblConfigPathsSection = new System.Windows.Forms.Label();
            lblC1ConfigPath = new System.Windows.Forms.Label();
            txtC1ConfigPath = new System.Windows.Forms.TextBox();
            lblDocConfigPath = new System.Windows.Forms.Label();
            txtDocConfigPath = new System.Windows.Forms.TextBox();
            btnSaveAll = new System.Windows.Forms.Button();
            panelFolders = new System.Windows.Forms.Panel();
            panelConnection = new System.Windows.Forms.Panel();
            panelConfigPaths = new System.Windows.Forms.Panel();
            panelFolders.SuspendLayout();
            panelConnection.SuspendLayout();
            panelConfigPaths.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(16, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(150, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Application Settings";
            // 
            // panelFolders
            // 
            panelFolders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelFolders.Controls.Add(lblFoldersSection);
            panelFolders.Controls.Add(lstFolders);
            panelFolders.Controls.Add(txtNewFolder);
            panelFolders.Controls.Add(btnBrowseFolder);
            panelFolders.Controls.Add(btnAddFolder);
            panelFolders.Controls.Add(btnRemoveFolder);
            panelFolders.Location = new System.Drawing.Point(16, 50);
            panelFolders.Name = "panelFolders";
            panelFolders.Size = new System.Drawing.Size(600, 200);
            panelFolders.TabIndex = 1;
            // 
            // lblFoldersSection
            // 
            lblFoldersSection.AutoSize = true;
            lblFoldersSection.Location = new System.Drawing.Point(0, 0);
            lblFoldersSection.Name = "lblFoldersSection";
            lblFoldersSection.Size = new System.Drawing.Size(100, 17);
            lblFoldersSection.TabIndex = 0;
            lblFoldersSection.Text = "Project Folders";
            // 
            // lstFolders
            // 
            lstFolders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstFolders.FormattingEnabled = true;
            lstFolders.ItemHeight = 17;
            lstFolders.Location = new System.Drawing.Point(0, 25);
            lstFolders.Name = "lstFolders";
            lstFolders.Size = new System.Drawing.Size(490, 106);
            lstFolders.TabIndex = 1;
            lstFolders.SelectedIndexChanged += lstFolders_SelectedIndexChanged;
            // 
            // txtNewFolder
            // 
            txtNewFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNewFolder.Location = new System.Drawing.Point(0, 145);
            txtNewFolder.Name = "txtNewFolder";
            txtNewFolder.PlaceholderText = "Enter folder path or browse...";
            txtNewFolder.Size = new System.Drawing.Size(380, 25);
            txtNewFolder.TabIndex = 2;
            txtNewFolder.TextChanged += txtNewFolder_TextChanged;
            txtNewFolder.KeyPress += txtNewFolder_KeyPress;
            // 
            // btnBrowseFolder
            // 
            btnBrowseFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnBrowseFolder.Location = new System.Drawing.Point(390, 143);
            btnBrowseFolder.Name = "btnBrowseFolder";
            btnBrowseFolder.Size = new System.Drawing.Size(100, 32);
            btnBrowseFolder.TabIndex = 3;
            btnBrowseFolder.Text = "Browse...";
            btnBrowseFolder.Click += btnBrowseFolder_Click;
            // 
            // btnAddFolder
            // 
            btnAddFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddFolder.Location = new System.Drawing.Point(500, 25);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Size = new System.Drawing.Size(100, 32);
            btnAddFolder.TabIndex = 4;
            btnAddFolder.Text = "Add";
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // btnRemoveFolder
            // 
            btnRemoveFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRemoveFolder.Location = new System.Drawing.Point(500, 65);
            btnRemoveFolder.Name = "btnRemoveFolder";
            btnRemoveFolder.Size = new System.Drawing.Size(100, 32);
            btnRemoveFolder.TabIndex = 5;
            btnRemoveFolder.Text = "Remove";
            btnRemoveFolder.Click += btnRemoveFolder_Click;
            // 
            // panelConnection
            // 
            panelConnection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelConnection.Controls.Add(lblConnectionSection);
            panelConnection.Controls.Add(txtConnectionString);
            panelConnection.Controls.Add(btnTestConnection);
            panelConnection.Location = new System.Drawing.Point(16, 260);
            panelConnection.Name = "panelConnection";
            panelConnection.Size = new System.Drawing.Size(600, 80);
            panelConnection.TabIndex = 2;
            // 
            // lblConnectionSection
            // 
            lblConnectionSection.AutoSize = true;
            lblConnectionSection.Location = new System.Drawing.Point(0, 0);
            lblConnectionSection.Name = "lblConnectionSection";
            lblConnectionSection.Size = new System.Drawing.Size(180, 17);
            lblConnectionSection.TabIndex = 0;
            lblConnectionSection.Text = "Database Connection String";
            // 
            // txtConnectionString
            // 
            txtConnectionString.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtConnectionString.Location = new System.Drawing.Point(0, 25);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.PlaceholderText = "server=localhost;Integrated Security=True;Pooling=True;";
            txtConnectionString.Size = new System.Drawing.Size(480, 25);
            txtConnectionString.TabIndex = 1;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnTestConnection.Location = new System.Drawing.Point(490, 23);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new System.Drawing.Size(110, 32);
            btnTestConnection.TabIndex = 2;
            btnTestConnection.Text = "Test Connection";
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // panelConfigPaths
            // 
            panelConfigPaths.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelConfigPaths.Controls.Add(lblConfigPathsSection);
            panelConfigPaths.Controls.Add(lblC1ConfigPath);
            panelConfigPaths.Controls.Add(txtC1ConfigPath);
            panelConfigPaths.Controls.Add(lblDocConfigPath);
            panelConfigPaths.Controls.Add(txtDocConfigPath);
            panelConfigPaths.Location = new System.Drawing.Point(16, 350);
            panelConfigPaths.Name = "panelConfigPaths";
            panelConfigPaths.Size = new System.Drawing.Size(600, 130);
            panelConfigPaths.TabIndex = 3;
            // 
            // lblConfigPathsSection
            // 
            lblConfigPathsSection.AutoSize = true;
            lblConfigPathsSection.Location = new System.Drawing.Point(0, 0);
            lblConfigPathsSection.Name = "lblConfigPathsSection";
            lblConfigPathsSection.Size = new System.Drawing.Size(140, 17);
            lblConfigPathsSection.TabIndex = 0;
            lblConfigPathsSection.Text = "Configuration File Paths";
            // 
            // lblC1ConfigPath
            // 
            lblC1ConfigPath.AutoSize = true;
            lblC1ConfigPath.Location = new System.Drawing.Point(0, 30);
            lblC1ConfigPath.Name = "lblC1ConfigPath";
            lblC1ConfigPath.Size = new System.Drawing.Size(120, 17);
            lblC1ConfigPath.TabIndex = 1;
            lblC1ConfigPath.Text = "C1 Config Filename:";
            // 
            // txtC1ConfigPath
            // 
            txtC1ConfigPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtC1ConfigPath.Location = new System.Drawing.Point(0, 50);
            txtC1ConfigPath.Name = "txtC1ConfigPath";
            txtC1ConfigPath.Size = new System.Drawing.Size(600, 25);
            txtC1ConfigPath.TabIndex = 2;
            // 
            // lblDocConfigPath
            // 
            lblDocConfigPath.AutoSize = true;
            lblDocConfigPath.Location = new System.Drawing.Point(0, 85);
            lblDocConfigPath.Name = "lblDocConfigPath";
            lblDocConfigPath.Size = new System.Drawing.Size(130, 17);
            lblDocConfigPath.TabIndex = 3;
            lblDocConfigPath.Text = "Doc Config Filename:";
            // 
            // txtDocConfigPath
            // 
            txtDocConfigPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDocConfigPath.Location = new System.Drawing.Point(0, 105);
            txtDocConfigPath.Name = "txtDocConfigPath";
            txtDocConfigPath.Size = new System.Drawing.Size(600, 25);
            txtDocConfigPath.TabIndex = 4;
            // 
            // btnSaveAll
            // 
            btnSaveAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSaveAll.Location = new System.Drawing.Point(496, 490);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new System.Drawing.Size(120, 36);
            btnSaveAll.TabIndex = 4;
            btnSaveAll.Text = "Save All Settings";
            btnSaveAll.Click += btnSaveAll_Click;
            // 
            // AppSettingsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblTitle);
            Controls.Add(panelFolders);
            Controls.Add(panelConnection);
            Controls.Add(panelConfigPaths);
            Controls.Add(btnSaveAll);
            Name = "AppSettingsView";
            Padding = new System.Windows.Forms.Padding(8);
            Size = new System.Drawing.Size(640, 540);
            Load += AppSettingsView_Load;
            panelFolders.ResumeLayout(false);
            panelFolders.PerformLayout();
            panelConnection.ResumeLayout(false);
            panelConnection.PerformLayout();
            panelConfigPaths.ResumeLayout(false);
            panelConfigPaths.PerformLayout();
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
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Panel panelFolders;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Panel panelConfigPaths;
    }
}