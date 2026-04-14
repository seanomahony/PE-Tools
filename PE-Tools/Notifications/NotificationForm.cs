using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using NLog;

namespace PE_Tools.Notifications
{
    /// <summary>
    /// A borderless, themed notification toast form that displays read-only messages.
    /// </summary>
    internal sealed class NotificationForm : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly Label _messageLabel;
        private readonly Timer _fadeOutTimer;
        private readonly Timer _closeTimer;
        private readonly int _durationSeconds;
        private double _opacity;
        private bool _isClosing;

        private const int Padding = 12;
        private const int CornerRadius = 8;
        private const int MaxWidth = 350;
        private const int MinHeight = 60;
        private const int FadeInSteps = 10;
        private const int FadeOutSteps = 10;
        private const int FadeIntervalMs = 20;        
        private static readonly Font BodyFont = new Font("Segoe UI", 9.75F, FontStyle.Regular);

        public NotificationForm(string message, int durationSeconds)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be null or empty.", nameof(message));
            }

            if (durationSeconds < 1)
            {
                throw new ArgumentException("Duration must be at least 1 second.", nameof(durationSeconds));
            }

            _durationSeconds = durationSeconds;
            _opacity = 0;
            _isClosing = false;

            // Form setup
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            ShowInTaskbar = false;
            TopMost = true;
            Opacity = 0;

            // Message label
            _messageLabel = new Label
            {
                AutoSize = false,
                Text = message,
                Font = BodyFont,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent,
                Padding = new Padding(Padding),
                MaximumSize = new Size(MaxWidth - (Padding * 2), 0)
            };

            // Measure text and size the form
            using (Graphics g = CreateGraphics())
            {
                SizeF textSize = g.MeasureString(message, _messageLabel.Font, MaxWidth - (Padding * 2));
                int width = Math.Min(MaxWidth, (int)textSize.Width + (Padding * 2));
                int height = Math.Max(MinHeight, (int)textSize.Height + (Padding * 2));
                
                ClientSize = new Size(width, height);
                _messageLabel.Size = new Size(width, height);
            }

            Controls.Add(_messageLabel);

            // Set up region for rounded corners
            UpdateRegion();

            // Timer for fade-out animation
            _fadeOutTimer = new Timer
            {
                Interval = FadeIntervalMs
            };
            _fadeOutTimer.Tick += FadeOutTimer_Tick;

            // Timer to trigger close after duration
            _closeTimer = new Timer
            {
                Interval = _durationSeconds * 1000
            };
            _closeTimer.Tick += CloseTimer_Tick;

            Logger.Debug("NotificationForm created with message: {0}, duration: {1}s", message, durationSeconds);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FadeIn();
            _closeTimer.Start();
            Logger.Debug("NotificationForm shown and fade-in started.");
        }

        private void FadeIn()
        {
            Timer fadeInTimer = new Timer { Interval = FadeIntervalMs };
            int steps = 0;

            fadeInTimer.Tick += (s, e) =>
            {
                steps++;
                _opacity = Math.Min(1.0, (double)steps / FadeInSteps);
                Opacity = _opacity;

                if (steps >= FadeInSteps)
                {
                    fadeInTimer.Stop();
                    fadeInTimer.Dispose();
                }
            };

            fadeInTimer.Start();
        }

        private void CloseTimer_Tick(object? sender, EventArgs e)
        {
            _closeTimer.Stop();
            BeginClose();
        }

        public void BeginClose()
        {
            if (_isClosing)
            {
                return;
            }

            _isClosing = true;
            _closeTimer.Stop();
            _fadeOutTimer.Start();
            Logger.Debug("NotificationForm beginning close (fade-out).");
        }

        private void FadeOutTimer_Tick(object? sender, EventArgs e)
        {
            _opacity -= 1.0 / FadeOutSteps;
            if (_opacity <= 0)
            {
                _opacity = 0;
                Opacity = 0;
                _fadeOutTimer.Stop();
                Logger.Debug("NotificationForm fade-out complete, closing.");
                Close();
            }
            else
            {
                Opacity = _opacity;
            }
        }

        private void UpdateRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseFigure();
            Region = new Region(path);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw border
            using (Pen borderPen = new Pen(Color.Black, 1))
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                path.AddArc(Width - CornerRadius - 1, 0, CornerRadius, CornerRadius, 270, 90);
                path.AddArc(Width - CornerRadius - 1, Height - CornerRadius - 1, CornerRadius, CornerRadius, 0, 90);
                path.AddArc(0, Height - CornerRadius - 1, CornerRadius, CornerRadius, 90, 90);
                path.CloseFigure();
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(borderPen, path);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _fadeOutTimer?.Dispose();
                _closeTimer?.Dispose();
                _messageLabel?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
