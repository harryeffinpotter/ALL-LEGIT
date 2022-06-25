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
                if (ex.ToString().Contains("assword"))
                {
                    if (!String.IsNullOrEmpty(MainWindow.PWLIST))
                    {
                        string[] PWArray = MainWindow.PWLIST.Split(';');
                        foreach (string PW in PWArray)
                        {
                            ProcessStartInfo pro = new ProcessStartInfo();
                            pro.WindowStyle = ProcessWindowStyle.Hidden;
                            pro.FileName = $"{Environment.CurrentDirectory}\\7z.exe";
                            pro.Arguments = string.Format($"x \"{{}}\" -y -o\"{{1}}\" -p\"{PW}\"", sourceArchive, destination);
                            Process x = Process.Start(pro);
                            if (!x.HasExited)
                                x.WaitForExit();
                        }
                    }
                }
                MessageBox.Show("Zip is passworded, please enter password in passwords textbox!");
            }
        }

        public static void DecryptDLC()
        {
            int DLCNumber = 0;
            string[] files = Directory.GetFiles($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads", "*.dlc", SearchOption.TopDirectoryOnly);
     
                foreach (string file in files)
            {
                string filename = Path.GetFileName(file);
                File.Move(file, $"{Environment.CurrentDirectory}\\_bin\\{filename}");
                ProcessStartInfo pro = new ProcessStartInfo();
                    pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = $"cmd.exe";
                pro.WorkingDirectory = $"{Environment.CurrentDirectory}\\_bin";
                pro.Arguments = $"/c decrypt-dlc.cmd {filename} -o urls{DLCNumber}.txt";
                Process x = Process.Start(pro);
                x.WaitForExit();    
                DLCNumber++;
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


