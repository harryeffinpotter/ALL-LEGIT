
using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALL_LEGIT
{
    internal static class Program
    {
        public static System.Threading.Mutex mutex;
        public static MainWindow form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool mutexCreated = false;
            mutex = new System.Threading.Mutex(false, "All Legit.exe", out mutexCreated);

            if (!mutexCreated)
            {
                MessageBox.Show(new Form { TopMost = true },"All Legit is already running!!! try again!", "Already Runing!", MessageBoxButtons.OK, MessageBoxIcon.Error)
;
                mutex.Close();
                Application.Exit();
                return;
            }
            try
            {

                // Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                form = new MainWindow();
                try
                {
                    Application.Run(form);
                } finally { Program.form.ALTrayIcon.Dispose(); }
                Application.Exit();

            }
            catch { }
        }

    }

}
