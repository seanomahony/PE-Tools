using System.Drawing;
using System.Windows.Forms;

namespace PE_Tools.Theme
{
    /// <summary>
    /// Provides consistent styling across the application using a modern dark theme.
    /// </summary>
    public static class ThemeHelper
    {
        // Primary colors
        public static readonly Color PrimaryBackground = Color.FromArgb(30, 30, 30);
        public static readonly Color SecondaryBackground = Color.FromArgb(45, 45, 48);
        public static readonly Color TertiaryBackground = Color.FromArgb(62, 62, 66);
        
        // Accent colors
        public static readonly Color AccentBlue = Color.FromArgb(0, 122, 204);
        public static readonly Color AccentGreen = Color.FromArgb(87, 166, 74);
        public static readonly Color AccentOrange = Color.FromArgb(202, 81, 0);
        public static readonly Color AccentRed = Color.FromArgb(232, 17, 35);
        
        // Text colors
        public static readonly Color PrimaryText = Color.FromArgb(241, 241, 241);
        public static readonly Color SecondaryText = Color.FromArgb(170, 170, 170);
        public static readonly Color DisabledText = Color.FromArgb(100, 100, 100);
        
        // Console/Output colors
        public static readonly Color ConsoleBackground = Color.FromArgb(12, 12, 12);
        public static readonly Color ConsoleText = Color.FromArgb(204, 204, 204);
        
        // Border colors
        public static readonly Color BorderColor = Color.FromArgb(67, 67, 70);
        public static readonly Color FocusBorderColor = AccentBlue;

        // Fonts
        public static readonly Font TitleFont = new("Segoe UI Semibold", 14F, FontStyle.Regular);
        public static readonly Font HeaderFont = new("Segoe UI Semibold", 11F, FontStyle.Regular);
        public static readonly Font BodyFont = new("Segoe UI", 9.75F, FontStyle.Regular);
        public static readonly Font ConsoleFont = new("Cascadia Code", 10F, FontStyle.Regular);
        public static readonly Font ConsoleFontFallback = new("Consolas", 10F, FontStyle.Regular);

        /// <summary>
        /// Applies the dark theme to a Form.
        /// </summary>
        public static void ApplyTheme(Form form)
        {
            form.BackColor = PrimaryBackground;
            form.ForeColor = PrimaryText;
            form.Font = BodyFont;
            
            ApplyThemeToControls(form.Controls);
        }

        /// <summary>
        /// Applies the dark theme to a UserControl.
        /// </summary>
        public static void ApplyTheme(UserControl control)
        {
            control.BackColor = PrimaryBackground;
            control.ForeColor = PrimaryText;
            control.Font = BodyFont;
            
            ApplyThemeToControls(control.Controls);
        }

        /// <summary>
        /// Recursively applies theme to all controls.
        /// </summary>
        public static void ApplyThemeToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                ApplyThemeToControl(control);
                
                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls);
                }
            }
        }

        /// <summary>
        /// Applies theme to a specific control based on its type.
        /// </summary>
        public static void ApplyThemeToControl(Control control)
        {
            control.ForeColor = PrimaryText;

            switch (control)
            {
                case Button button:
                    StyleButton(button);
                    break;
                case TextBox textBox:
                    StyleTextBox(textBox);
                    break;
                case RichTextBox richTextBox:
                    StyleRichTextBox(richTextBox);
                    break;
                case ComboBox comboBox:
                    StyleComboBox(comboBox);
                    break;
                case Label label:
                    StyleLabel(label);
                    break;
                case GroupBox groupBox:
                    StyleGroupBox(groupBox);
                    break;
                case TabControl tabControl:
                    StyleTabControl(tabControl);
                    break;
                case TabPage tabPage:
                    StyleTabPage(tabPage);
                    break;
                case Panel panel:
                    StylePanel(panel);
                    break;
            }
        }

        /// <summary>
        /// Styles a button with a modern flat appearance.
        /// </summary>
        public static void StyleButton(Button button, ButtonStyle style = ButtonStyle.Default)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.Cursor = Cursors.Hand;
            button.Font = BodyFont;
            
            // Ensure minimum height for readable text
            if (button.Height < 32)
            {
                button.Height = 32;
            }

            switch (style)
            {
                case ButtonStyle.Primary:
                    button.BackColor = AccentBlue;
                    button.ForeColor = Color.White;
                    button.FlatAppearance.BorderColor = AccentBlue;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 151, 234);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 102, 170);
                    break;
                case ButtonStyle.Success:
                    button.BackColor = AccentGreen;
                    button.ForeColor = Color.White;
                    button.FlatAppearance.BorderColor = AccentGreen;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 186, 94);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(67, 146, 54);
                    break;
                case ButtonStyle.Danger:
                    button.BackColor = AccentRed;
                    button.ForeColor = Color.White;
                    button.FlatAppearance.BorderColor = AccentRed;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 47, 65);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 17, 35);
                    break;
                case ButtonStyle.Warning:
                    button.BackColor = AccentOrange;
                    button.ForeColor = Color.White;
                    button.FlatAppearance.BorderColor = AccentOrange;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 101, 20);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(162, 61, 0);
                    break;
                default:
                    button.BackColor = SecondaryBackground;
                    button.ForeColor = PrimaryText;
                    button.FlatAppearance.BorderColor = BorderColor;
                    button.FlatAppearance.MouseOverBackColor = TertiaryBackground;
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 82, 86);
                    break;
            }
        }

        /// <summary>
        /// Styles a TextBox for console-like output.
        /// </summary>
        public static void StyleTextBox(TextBox textBox, bool isConsole = false)
        {
            textBox.BorderStyle = BorderStyle.FixedSingle;
            
            if (isConsole)
            {
                textBox.BackColor = ConsoleBackground;
                textBox.ForeColor = ConsoleText;
                textBox.Font = IsFontInstalled("Cascadia Code") ? ConsoleFont : ConsoleFontFallback;
            }
            else
            {
                textBox.BackColor = SecondaryBackground;
                textBox.ForeColor = PrimaryText;
                textBox.Font = BodyFont;
            }
        }

        /// <summary>
        /// Styles a RichTextBox.
        /// </summary>
        public static void StyleRichTextBox(RichTextBox richTextBox, bool isConsole = false)
        {
            richTextBox.BorderStyle = BorderStyle.None;
            
            if (isConsole)
            {
                richTextBox.BackColor = ConsoleBackground;
                richTextBox.ForeColor = ConsoleText;
                richTextBox.Font = IsFontInstalled("Cascadia Code") ? ConsoleFont : ConsoleFontFallback;
            }
            else
            {
                richTextBox.BackColor = SecondaryBackground;
                richTextBox.ForeColor = PrimaryText;
                richTextBox.Font = BodyFont;
            }
        }

        /// <summary>
        /// Styles a ComboBox.
        /// </summary>
        public static void StyleComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = SecondaryBackground;
            comboBox.ForeColor = PrimaryText;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.Font = BodyFont;
        }

        /// <summary>
        /// Styles a Label.
        /// </summary>
        public static void StyleLabel(Label label)
        {
            label.ForeColor = PrimaryText;
            label.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Styles a GroupBox.
        /// </summary>
        public static void StyleGroupBox(GroupBox groupBox)
        {
            groupBox.ForeColor = SecondaryText;
            groupBox.BackColor = PrimaryBackground;
            groupBox.Font = HeaderFont;
        }

        /// <summary>
        /// Styles a TabControl.
        /// </summary>
        public static void StyleTabControl(TabControl tabControl)
        {
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.DrawItem += TabControl_DrawItem;
        }

        /// <summary>
        /// Styles a TabPage.
        /// </summary>
        public static void StyleTabPage(TabPage tabPage)
        {
            tabPage.BackColor = PrimaryBackground;
            tabPage.ForeColor = PrimaryText;
        }

        /// <summary>
        /// Styles a Panel.
        /// </summary>
        public static void StylePanel(Panel panel)
        {
            panel.BackColor = PrimaryBackground;
        }

        /// <summary>
        /// Custom draw handler for TabControl tabs.
        /// </summary>
        private static void TabControl_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (sender is not TabControl tabControl) return;
            
            var tabPage = tabControl.TabPages[e.Index];
            var tabRect = tabControl.GetTabRect(e.Index);
            
            var isSelected = e.Index == tabControl.SelectedIndex;
            
            using var backBrush = new SolidBrush(isSelected ? SecondaryBackground : TertiaryBackground);
            e.Graphics.FillRectangle(backBrush, tabRect);
            
            if (isSelected)
            {
                using var accentPen = new Pen(AccentBlue, 2);
                e.Graphics.DrawLine(accentPen, tabRect.Left, tabRect.Bottom - 1, tabRect.Right, tabRect.Bottom - 1);
            }
            
            var textColor = isSelected ? PrimaryText : SecondaryText;
            TextRenderer.DrawText(e.Graphics, tabPage.Text, BodyFont, tabRect, textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        /// <summary>
        /// Checks if a font is installed on the system.
        /// </summary>
        private static bool IsFontInstalled(string fontName)
        {
            using var testFont = new Font(fontName, 10F, FontStyle.Regular);
            return testFont.Name.Equals(fontName, System.StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Creates a styled GroupBox with a title.
        /// </summary>
        public static GroupBox CreateGroupBox(string title, int x, int y, int width, int height)
        {
            var groupBox = new GroupBox
            {
                Text = title,
                Location = new Point(x, y),
                Size = new Size(width, height),
                ForeColor = SecondaryText,
                BackColor = PrimaryBackground,
                Font = HeaderFont,
                Padding = new Padding(10)
            };
            return groupBox;
        }
    }

    /// <summary>
    /// Button style variants.
    /// </summary>
    public enum ButtonStyle
    {
        Default,
        Primary,
        Success,
        Danger,
        Warning
    }
}
