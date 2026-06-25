using PE_Tools.Notifications;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PE_Tools
{
    public partial class Form1 : Form
    {
        private static Color SidebarBg       => AppTheme.SidebarBg;
        private static Color SidebarHover    => AppTheme.SidebarHover;
        private static Color SidebarActive   => AppTheme.SidebarActive;
        private static Color SidebarAccent   => AppTheme.SidebarAccent;
        private static Color SidebarFgNormal => AppTheme.SidebarFgNormal;
        private static Color SidebarFgActive => AppTheme.SidebarFgActive;

        private bool sidebarCollapsing = false;
        private bool sidebarExpanding = false;
        private int sidebarTargetWidth = 200;
        private int sidebarCollapsedWidth = 20;
        private List<(Button Button, Control View)> _navEntries = new List<(Button, Control)>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NotificationManager.Initialize(this);

            // load images from resources at runtime (designer will not execute this)
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
                // ignore if resources missing
            }

            _navEntries = new List<(Button, Control)>
            {
                (btnDatabases,  databaseSettingsView1),
                (btnPowerShell, powershellCommandsView1),
                (btnKubectl,    kubectlCommandsView1),
                (btnSettings,   appSettingsView1),
            };

            foreach (var entry in _navEntries)
            {
                entry.Button.Paint += NavButton_Paint;
            }

            if (IsFirstRun())
            {
                ShowView(appSettingsView1);
                HighlightButton(btnSettings);
            }
            else
            {
                ShowView(databaseSettingsView1);
                HighlightButton(btnDatabases);
            }
        }

        private static bool IsFirstRun()
        {
            return string.IsNullOrWhiteSpace(SettingsManager.GetDevelopmentFolder())
                || string.IsNullOrWhiteSpace(SettingsManager.GetDatabaseConnectionString());
        }

        private void ShowView(Control view)
        {
            foreach (var entry in _navEntries)
            {
                if (entry.View != null)
                {
                    entry.View.Visible = (entry.View == view);
                }
            }
        }

        private void btnDatabases_Click(object sender, EventArgs e)
        {
            ShowView(databaseSettingsView1);
            HighlightButton(btnDatabases);
        }

        private void btnPowerShell_Click(object sender, EventArgs e)
        {
            ShowView(powershellCommandsView1);
            HighlightButton(btnPowerShell);
        }

        private void btnKubectl_Click(object sender, EventArgs e)
        {
            ShowView(kubectlCommandsView1);
            HighlightButton(btnKubectl);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowView(appSettingsView1);
            HighlightButton(btnSettings);
        }

        private void HighlightButton(Button selected)
        {
            foreach (var entry in _navEntries)
            {
                if (entry.Button == null)
                {
                    continue;
                }

                if (entry.Button == selected)
                {
                    entry.Button.BackColor = SidebarActive;
                    entry.Button.ForeColor = SidebarFgActive;
                }
                else
                {
                    entry.Button.BackColor = SidebarBg;
                    entry.Button.ForeColor = SidebarFgNormal;
                }
                entry.Button.Invalidate();
            }
        }

        private void NavButton_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is Button btn && btn.BackColor == SidebarActive)
            {
                using var brush = new SolidBrush(SidebarAccent);
                e.Graphics.FillRectangle(brush, 0, 0, 3, btn.Height);
            }
        }

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            if (mainSplitContainer != null)
            {
                // start animated collapse/expand
                if (mainSplitContainer.Panel1Collapsed == true)
                {
                    mainSplitContainer.Panel1Collapsed = false;
                    mainSplitContainer.SplitterDistance = sidebarCollapsedWidth;
                    sidebarExpanding = true;
                    sidebarCollapsing = false;
                    if (btnShowSidebar != null)
                    {
                        btnShowSidebar.Visible = false;
                    }
                    if (sidebarTimer != null)
                    {
                        sidebarTimer.Start();
                    }
                    if (btnToggleSidebar != null)
                    {
                        btnToggleSidebar.Text = "‹ collapse";
                    }
                }
                else
                {
                    sidebarTargetWidth = mainSplitContainer.SplitterDistance;
                    sidebarCollapsing = true;
                    sidebarExpanding = false;
                    if (sidebarTimer != null)
                    {
                        sidebarTimer.Start();
                    }
                    if (btnToggleSidebar != null)
                    {
                        btnToggleSidebar.Text = "› expand";
                    }
                }
            }
        }

        private void sidebarTimer_Tick(object? sender, EventArgs e)
        {
            if (mainSplitContainer == null)
            {
                return;
            }

            int current = mainSplitContainer.SplitterDistance;
            if (sidebarCollapsing)
            {
                int next = current - 12;
                if (next <= sidebarCollapsedWidth)
                {
                    next = sidebarCollapsedWidth;
                    sidebarCollapsing = false;
                    mainSplitContainer.Panel1Collapsed = true;
                    if (btnShowSidebar != null)
                    {
                        btnShowSidebar.Visible = true;
                    }
                    if (sidebarTimer != null)
                    {
                        sidebarTimer.Stop();
                    }
                }
                mainSplitContainer.SplitterDistance = next;
            }
            else if (sidebarExpanding)
            {
                // ensure panel is visible while expanding
                if (mainSplitContainer.Panel1Collapsed == true)
                {
                    mainSplitContainer.Panel1Collapsed = false;
                }
                int next = current + 12;
                if (next >= sidebarTargetWidth)
                {
                    next = sidebarTargetWidth;
                    sidebarExpanding = false;
                    if (sidebarTimer != null)
                    {
                        sidebarTimer.Stop();
                    }
                }
                mainSplitContainer.SplitterDistance = next;
            }
        }

        private void btnSidebarButton_MouseEnter(object? sender, EventArgs e)
        {
            var b = sender as Button;
            if (b != null && b.BackColor != SidebarActive)
            {
                b.BackColor = SidebarHover;
                b.ForeColor = SidebarFgActive;
            }
        }

        private void btnSidebarButton_MouseLeave(object? sender, EventArgs e)
        {
            var b = sender as Button;
            if (b != null && b.BackColor != SidebarActive)
            {
                b.BackColor = SidebarBg;
                b.ForeColor = SidebarFgNormal;
            }
        }

        private void btnSidebarButton_MouseDown(object? sender, MouseEventArgs e)
        {
            var b = sender as Button;
            if (b != null)
            {
                b.BackColor = SidebarAccent;
                b.ForeColor = SidebarFgActive;
            }
        }

        private void btnSidebarButton_MouseUp(object? sender, MouseEventArgs e)
        {
            var b = sender as Button;
            if (b != null && b.BackColor == SidebarAccent)
            {
                b.BackColor = SidebarHover;
            }
        }

        private void btnShowSidebar_Click(object sender, EventArgs e)
        {
            if (mainSplitContainer != null)
            {
                mainSplitContainer.Panel1Collapsed = false;
                mainSplitContainer.SplitterDistance = sidebarCollapsedWidth;
                sidebarExpanding = true;
                sidebarCollapsing = false;

                if (btnShowSidebar != null)
                {
                    btnShowSidebar.Visible = false;
                }
                if (sidebarTimer != null)
                {
                    sidebarTimer.Start();
                }
                if (btnToggleSidebar != null)
                {
                    btnToggleSidebar.Text = "‹ collapse";
                }
            }
        }
    }
}
