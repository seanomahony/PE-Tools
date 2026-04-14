using PE_Tools.Notifications;
using System;
using System.Windows.Forms;

namespace PE_Tools
{
    public partial class Form1 : Form
    {
        private bool sidebarCollapsing = false;
        private bool sidebarExpanding = false;
        private int sidebarTargetWidth = 200;
        private int sidebarCollapsedWidth = 28;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the notification manager
            NotificationManager.Initialize(this);
            // initial highlight
            HighlightButton(btnDatabases);
        }

        private void ShowView(Control view)
        {
            // hide all views first
            if (databaseSettingsView1 != null)
            {
                databaseSettingsView1.Visible = false;
            }

            if (powershellCommandsView1 != null)
            {
                powershellCommandsView1.Visible = false;
            }

            if (kubectlCommandsView1 != null)
            {
                kubectlCommandsView1.Visible = false;
            }

            if (appSettingsView1 != null)
            {
                appSettingsView1.Visible = false;
            }

            if (view != null)
            {
                view.Visible = true;
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
            // simple highlight: reset all and set BackColor for selected
            if (btnDatabases != null)
            {
                btnDatabases.BackColor = System.Drawing.SystemColors.Control;
            }

            if (btnPowerShell != null)
            {
                btnPowerShell.BackColor = System.Drawing.SystemColors.Control;
            }

            if (btnKubectl != null)
            {
                btnKubectl.BackColor = System.Drawing.SystemColors.Control;
            }

            if (btnSettings != null)
            {
                btnSettings.BackColor = System.Drawing.SystemColors.Control;
            }

            if (selected != null)
            {
                selected.BackColor = System.Drawing.SystemColors.ActiveCaption;
                selected.FlatAppearance.BorderSize = 1;
                selected.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
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
                        btnToggleSidebar.Text = "<<";
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
                        btnToggleSidebar.Text = ">>";
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
            if (b != null)
            {
                b.BackColor = System.Drawing.SystemColors.ControlLight;
            }
        }

        private void btnSidebarButton_MouseLeave(object? sender, EventArgs e)
        {
            var b = sender as Button;
            if (b != null)
            {
                // if this is the selected button, keep ActiveCaption
                if (b.BackColor != System.Drawing.SystemColors.ActiveCaption)
                {
                    b.BackColor = System.Drawing.SystemColors.Control;
                }
            }
        }

        private void btnSidebarButton_MouseDown(object? sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
                button.BackColor = System.Drawing.SystemColors.Highlight;
            }
        }

        private void btnSidebarButton_MouseUp(object? sender, MouseEventArgs e)
        {
            var b = sender as Button;
            if (b != null)
            {
                // restore highlight for selected button
                if (b.BackColor == System.Drawing.SystemColors.Highlight)
                {
                    b.BackColor = System.Drawing.SystemColors.ActiveCaption;
                }
                b.FlatAppearance.BorderSize = 0;
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
                    btnToggleSidebar.Text = "<<";
                }
            }
        }
    }
}
