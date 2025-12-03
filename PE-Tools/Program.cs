using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
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
    }
}
