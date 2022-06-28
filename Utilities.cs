using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpCompress;

namespace ALL_LEGIT
{
    class Utilities
    {

        public static void ExtractFile(string sourceArchive, string destination)
        {
            try
            {
                if (!File.Exists(Environment.CurrentDirectory + "\\7z.exe") || !File.Exists(Environment.CurrentDirectory + "\\7z.dll"))
                {
                    WebClient client = new WebClient();
                    client.DownloadFile("https://github.com/harryeffinpotter/-Loader/raw/main/7z.exe", "7z.exe");
                    client.DownloadFile("https://github.com/harryeffinpotter/-Loader/raw/main/7z.dll", "7z.dll");
                }
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = $"{Environment.CurrentDirectory}\\7z.exe";
                pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sourceArchive, destination);
                Process x = Process.Start(pro);
                if (!x.HasExited)
                    x.WaitForExit();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("assword"))
                {
                    if (!String.IsNullOrEmpty(Properties.Settings.Default.ZipPWS))
                    {
                        string[] PWArray = MainWindow.PWLIST.Split(';');
                        int PWArrCount = PWArray.Length;
                        int fails = 0;
                        foreach (string PW in PWArray)
                        {
                            try
                            {
                                ProcessStartInfo pro = new ProcessStartInfo();
                                pro.WindowStyle = ProcessWindowStyle.Hidden;
                                pro.FileName = $"{Environment.CurrentDirectory}\\7z.exe";
                                pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sourceArchive, destination) + $"-p\"{PW}\"";
                                Process x = Process.Start(pro);
                                if (!x.HasExited)
                                    x.WaitForExit();
                            }
                            catch (Exception ex2)
                            {
                               if (ex2.Message.Contains("assword"))
                                {
                                    fails++;
                                }
                            }
                        }
                        if (fails == PWArrCount)
                        {
                            MessageBox.Show("Archive is passworded and supplied passwords(if any) did not work.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Archive is password protected, add correct password to PW box to fix this.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                    }
                }
            }
        }

        public static void DecryptDLC()
        {
            int DLCNumber = MainWindow.CurrentDLC;
            string[] files = Directory.GetFiles(Environment.CurrentDirectory + "\\_bin", "*.dlc", SearchOption.TopDirectoryOnly);

            foreach (string file in files)
            {
                string filename = Path.GetFileName($"{Environment.CurrentDirectory}\\_bin\\{DLCNumber}.dlc");
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = $"cmd.exe";
                pro.WorkingDirectory = $"{Environment.CurrentDirectory}\\_bin";
                pro.Arguments = $"/c decrypt-dlc.cmd \"{filename}\" -o {DLCNumber}.txt";
                Process x = Process.Start(pro);
                x.WaitForExit();
                try
                {
                    File.Delete($"{Environment.CurrentDirectory}\\_bin\\{filename}");
                }
                catch
                {

                }
            }



        }

        public static string RemoveEverythingAfterFirst(string s, string removeMe)
        {
            int index = s.IndexOf(removeMe);
            if (index > 0)
                s = s.Substring(0, index);
            return s;
        }

        public static string RemoveEverythingAfterLast(string s, string removeMe)
        {
            int index = s.LastIndexOf(removeMe);
            if (index > 0)
                s = s.Substring(0, index);
            return s;
        }

        public static string RemoveEverythingBeforeFirst(string s, string removeMe)
        {
            int index = s.IndexOf(removeMe);
            if (index > 0)
                s = s.Substring(index);
            return s;
        }

        public static string KeepOnlyNumbers(string s)
        {
            string numbers = "0123456789";
            string a = "";
            foreach (char ch in s)
            {
                if (numbers.Contains(ch))
                {
                    a += ch;
                }
            }
            return a;
        }

        public static string RemoveEverythingBeforeLast(string s, string removeMe)
        {
            int index = s.LastIndexOf(removeMe);
            if (index > 0)
                s = s.Substring(index);
            return s;
        }
    }
}


