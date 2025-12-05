using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NLog;

namespace PE_Tools
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize logging as early as possible for a dev tool
            LoggingBootstrap.Initialize();
            var logger = LogManager.GetCurrentClassLogger();

            logger.Info("Application starting");
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                SetExceptionHandlers();
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, "Fatal exception in Main");
                throw;
            }
            finally
            {
                logger.Info("Application shutdown");
                LogManager.Shutdown();
            }
        }

        private static void SetExceptionHandlers()
        {
            var logger = LogManager.GetCurrentClassLogger();

            Application.ThreadException += (sender, args) =>
            {
                try
                {
                    // Log full exception details for diagnostics
                    logger.Error(args.Exception, "Unhandled UI thread exception");

                    MessageBox.Show($"An unexpected error occurred: {args.Exception.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception handlerEx)
                {
                    // Attempt to log handler failure, but swallow to avoid recursion
                    try
                    {
                        logger.Error(handlerEx, "Exception while handling UI thread exception");
                    }
                    catch { }
                }
            };

            // Global non-UI thread exception handler
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                try
                {
                    var ex = args.ExceptionObject as Exception;

                    // Log as fatal since this is an unhandled, potentially terminating exception
                    logger.Fatal(ex, "Unhandled non-UI thread exception. IsTerminating={0}", args.IsTerminating);

                    MessageBox.Show($"A fatal error occurred: {ex?.Message}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception handlerEx)
                {
                    // Attempt to log handler failure, but swallow to avoid recursion
                    try
                    {
                        logger.Error(handlerEx, "Exception while handling non-UI thread exception");
                    }
                    catch { }
                }
            };
        }
    }
}
