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

        public static void DecryptDLC(MainWindow mainWindow)
        {     

            string[] files = Directory.GetFiles(Environment.CurrentDirectory, "*.dlc", SearchOption.AllDirectories);
            string[] files2 = Directory.GetFiles(MainWindow.GetDownloadsPath(), "*.dlc",SearchOption.AllDirectories);
            string[] joinedResult = files.Concatenate(files2);
            mainWindow.Text = "";
        
            foreach (string file in joinedResult)
            {
                int DLCNumber = MainWindow.randomNumber;
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = $"cmd.exe";
                pro.WorkingDirectory = $"{Environment.CurrentDirectory}\\_bin";
                pro.Arguments = $"/c decrypt-dlc.cmd \"{file}\" -o \"{Environment.CurrentDirectory}\\_bin\\{DLCNumber}.txt\"";
               Process  x = Process.Start(pro);
                x.WaitForExit();
                try
                {
                    File.Delete(file);
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
public static class Extension
{
    public static T[] Concatenate<T>(this T[] first, T[] second)
    {
        if (first == null)
        {
            return second;
        }
        if (second == null)
        {
            return first;
        }

        return first.Concat(second).ToArray();
    }
}