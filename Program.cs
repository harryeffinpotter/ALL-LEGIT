
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
        public static MainWindow form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {

                // Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                form = new MainWindow();
                Application.Run(form);
                Application.Exit();

            }
            catch { }
        }

    }

}
