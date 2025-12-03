using System;
using System.Windows.Forms;
using NLog;

namespace PE_Tools
{
    public static class LoggingBootstrap
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static void Initialize()
        {
            try
            {
                LogManager.LoadConfiguration("NLog.config");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to load NLog configuration: {ex}");
            }

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                var ex = e.ExceptionObject as Exception;
                Logger.Fatal(ex, "Unhandled exception (AppDomain)");
            };

            Application.ThreadException += (s, e) =>
            {
                Logger.Fatal(e.Exception, "Unhandled UI thread exception");
            };

            Logger.Info("Logging initialized");
        }
    }
}
