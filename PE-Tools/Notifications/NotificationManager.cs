using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NLog;

namespace PE_Tools.Notifications
{
    /// <summary>
    /// Manages the display of toast-style notifications within the application window.
    /// Thread-safe and supports stacking up to a configurable number of notifications.
    /// </summary>
    public static class NotificationManager
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static readonly object _lock = new object();
        private static readonly List<NotificationForm> _activeNotifications = new List<NotificationForm>();
        
        private const int MaxNotifications = 3;
        private const int NotificationSpacing = 10;
        private const int BottomMargin = 20;
        private const int RightMargin = 20;
        private const int AnimationSteps = 10;
        private const int AnimationIntervalMs = 20;

        private static Form? _parentForm;

        /// <summary>
        /// Initializes the notification manager with the parent form.
        /// Must be called before showing any notifications.
        /// </summary>
        /// <param name="parentForm">The main application form.</param>
        public static void Initialize(Form parentForm)
        {
            if (parentForm == null)
            {
                throw new ArgumentNullException(nameof(parentForm));
            }

            lock (_lock)
            {
                _parentForm = parentForm;
                Logger.Info("NotificationManager initialized with parent form: {0}", parentForm.Name);
            }
        }

        /// <summary>
        /// Shows a notification toast in the bottom-right corner of the application window.
        /// </summary>
        /// <param name="message">The message to display.</param>
        /// <param name="durationSeconds">Optional duration in seconds. If null, uses the default from settings.</param>
        public static void Show(string message, int? durationSeconds = null)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                Logger.Warn("Attempted to show notification with empty message.");
                return;
            }

            int duration = durationSeconds ?? SettingsManager.GetNotificationDuration();
            
            Logger.Info("Showing notification: {0} (duration: {1}s)", message, duration);

            // Ensure we're on the UI thread
            if (_parentForm?.InvokeRequired == true)
            {
                _parentForm.BeginInvoke(new Action(() => ShowInternal(message, duration)));
            }
            else
            {
                ShowInternal(message, duration);
            }
        }

        private static void ShowInternal(string message, int durationSeconds)
        {
            lock (_lock)
            {
                if (_parentForm == null)
                {
                    Logger.Error("NotificationManager not initialized. Call Initialize() before showing notifications.");
                    return;
                }

                // Remove oldest notification if we're at max capacity
                if (_activeNotifications.Count >= MaxNotifications)
                {
                    var oldest = _activeNotifications[0];
                    _activeNotifications.RemoveAt(0);
                    oldest.BeginClose();
                    Logger.Debug("Removed oldest notification to make room for new one.");
                }

                // Create and position the new notification
                var notification = new NotificationForm(message, durationSeconds);
                notification.FormClosed += Notification_FormClosed;
                
                _activeNotifications.Add(notification);

                // Position at bottom-right of parent form
                PositionNotifications(slideIn: true);
                
                notification.Show(_parentForm);
            }
        }

        private static void Notification_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender is NotificationForm closedNotification)
            {
                lock (_lock)
                {
                    _activeNotifications.Remove(closedNotification);
                    Logger.Debug("Notification closed. Active count: {0}", _activeNotifications.Count);
                    
                    // Reposition remaining notifications smoothly
                    PositionNotifications(slideIn: false);
                }
                
                closedNotification.FormClosed -= Notification_FormClosed;
            }
        }

        private static void PositionNotifications(bool slideIn)
        {
            if (_parentForm == null || _activeNotifications.Count == 0)
            {
                return;
            }

            int currentY = _parentForm.ClientSize.Height - BottomMargin;

            // Position from bottom to top
            for (int i = _activeNotifications.Count - 1; i >= 0; i--)
            {
                var notification = _activeNotifications[i];
                
                currentY -= notification.Height;
                
                int targetX = _parentForm.ClientSize.Width - notification.Width - RightMargin;
                int targetY = currentY;

                // Convert to screen coordinates
                Point targetLocation = _parentForm.PointToScreen(new Point(targetX, targetY));

                if (slideIn && i == _activeNotifications.Count - 1)
                {
                    // New notification: slide in from right
                    Point startLocation = new Point(targetLocation.X + notification.Width, targetLocation.Y);
                    notification.Location = startLocation;
                    AnimateToPosition(notification, targetLocation);
                }
                else
                {
                    // Existing notification: smooth move to new position
                    if (notification.Location != targetLocation)
                    {
                        AnimateToPosition(notification, targetLocation);
                    }
                    else
                    {
                        notification.Location = targetLocation;
                    }
                }

                currentY -= NotificationSpacing;
            }
        }

        private static void AnimateToPosition(NotificationForm notification, Point targetLocation)
        {
            Point startLocation = notification.Location;
            int steps = AnimationSteps;
            int currentStep = 0;

            Timer animationTimer = new Timer { Interval = AnimationIntervalMs };
            
            animationTimer.Tick += (s, e) =>
            {
                currentStep++;
                double progress = (double)currentStep / steps;
                
                int x = (int)(startLocation.X + (targetLocation.X - startLocation.X) * progress);
                int y = (int)(startLocation.Y + (targetLocation.Y - startLocation.Y) * progress);
                
                notification.Location = new Point(x, y);

                if (currentStep >= steps)
                {
                    notification.Location = targetLocation;
                    animationTimer.Stop();
                    animationTimer.Dispose();
                }
            };

            animationTimer.Start();
        }

        /// <summary>
        /// Closes all active notifications immediately.
        /// </summary>
        public static void CloseAll()
        {
            lock (_lock)
            {
                Logger.Info("Closing all notifications. Count: {0}", _activeNotifications.Count);
                
                var toClose = _activeNotifications.ToList();
                _activeNotifications.Clear();
                
                foreach (var notification in toClose)
                {
                    notification.BeginClose();
                }
            }
        }
    }
}
