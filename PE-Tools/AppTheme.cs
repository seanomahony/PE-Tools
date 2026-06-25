using System.Drawing;

namespace PE_Tools
{
    internal static class AppTheme
    {
        // Sidebar (dark)
        internal static readonly Color SidebarBg       = Color.FromArgb(37, 37, 38);
        internal static readonly Color SidebarHover    = Color.FromArgb(45, 45, 48);
        internal static readonly Color SidebarActive   = Color.FromArgb(55, 55, 61);
        internal static readonly Color SidebarAccent   = Color.FromArgb(0, 122, 204);
        internal static readonly Color SidebarFgNormal = Color.FromArgb(204, 204, 204);
        internal static readonly Color SidebarFgActive = Color.White;

        // Content area (light)
        internal static readonly Color ContentBg      = Color.FromArgb(243, 243, 243);
        internal static readonly Color InputBg        = Color.White;
        internal static readonly Color InputFg        = Color.FromArgb(30, 30, 30);
        internal static readonly Color LabelHeadingFg = Color.FromArgb(37, 37, 38);
        internal static readonly Color LabelSectionFg = Color.FromArgb(97, 97, 97);

        // Content buttons
        internal static readonly Color BtnPrimaryBg    = Color.FromArgb(0, 122, 204);
        internal static readonly Color BtnPrimaryFg    = Color.White;
        internal static readonly Color BtnPrimaryHover = Color.FromArgb(24, 142, 222);

        internal static readonly Color BtnSecondaryBg    = Color.FromArgb(72, 72, 74);
        internal static readonly Color BtnSecondaryFg    = Color.White;
        internal static readonly Color BtnSecondaryHover = Color.FromArgb(90, 90, 92);

        internal static readonly Color BtnDangerBg    = Color.FromArgb(180, 40, 40);
        internal static readonly Color BtnDangerFg    = Color.White;
        internal static readonly Color BtnDangerHover = Color.FromArgb(200, 60, 60);

        // Output / terminal areas
        internal static readonly Color TerminalBg = Color.FromArgb(30, 30, 30);
        internal static readonly Color TerminalFg = Color.FromArgb(204, 204, 204);
        internal static readonly Font  TerminalFont = new Font("Consolas", 10F);
    }
}
