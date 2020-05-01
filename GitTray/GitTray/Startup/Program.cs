using System;
using System.Threading;
using System.Windows.Forms;

namespace GitTray.UI
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{#GitTray}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                try
                {
                    Application.Run(new GitTrayUI());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, ex.Message, @"Git Tray", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show(null, "GitTray is already running !", @"Git Tray", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
