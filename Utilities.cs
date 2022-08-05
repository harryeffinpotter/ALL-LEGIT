using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SevenZip;
using SharpCompress;

namespace ALL_LEGIT
{
    class Utilities
    {
        public static void ExtractFile2(string sourceArchive, string destination)
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
            catch
            {
                MessageBox.Show("Unable to extract updated files. If you have WINRAR try uninstalling it then trying again! If you have not installed FFAIO since version 2.0.13 then ");
            }
        }
        public static string FailedExtract = "";
        public static void GetMissingFiles()
        {

            var client = new WebClient();
            string _bin = $"{Environment.CurrentDirectory}\\_bin";
            string config = $"{Environment.CurrentDirectory}\\All.Legit.exe.config";
             
            if (!File.Exists($"{_bin}\\transmission-show.exe"))
            {
                client.DownloadFile("https://github.com/harryeffinpotter/ALL-LEGIT/raw/main/_bin.7z", "_bin.7z");
                if (Directory.Exists(_bin))
                {
                    Directory.Delete(_bin, true);
                    Directory.CreateDirectory(_bin);
                }
                ExtractFile2(Environment.CurrentDirectory + "\\_bin.7z", _bin);
                File.Delete(Environment.CurrentDirectory + "\\_bin\\_bin.7z");
            }
        }
        public static string get_parent_dir_path(string path)
        {
            // notice that i used two separators windows style "\\" and linux "/" (for bad formed paths)
            // We make sure to remove extra unneeded characters.
            int index = path.Trim('/', '\\').LastIndexOfAny(new char[] { '\\', '/' });

            // now if index is >= 0 that means we have at least one parent directory, otherwise the given path is the root most.
            if (index >= 0)
                return path.Remove(index);
            else
                return "";
        }
        public static bool IsExtracting = false;
        public static async void ExtractFile(string sourceArchive, string destination)
        {
            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }
            string[] files = Directory.GetFiles(destination);

            System.Diagnostics.Process x2 = new System.Diagnostics.Process();
            ProcessStartInfo pro = new ProcessStartInfo();
            pro.WindowStyle = ProcessWindowStyle.Hidden;
            pro.UseShellExecute = false;
            pro.CreateNoWindow = true;
            pro.RedirectStandardError = true;
            pro.RedirectStandardOutput = true;
            pro.FileName = $"{Environment.CurrentDirectory}\\7z.exe";
            string Error = null;
            string[] PWArray = MainWindow.PWLIST.Split(';');
            int fails = 0;
            foreach (string PW in PWArray)
            {
                bool success = false;
                try
                {
                    pro.Arguments = string.Format("x \"{0}\" -aoa -o\"{1}\"", sourceArchive, destination) + $" -p\"{PW}\"";
                    x2.StartInfo = pro;
                    IsExtracting = true;
                    x2.Start();
                    Error = x2.StandardError.ReadToEnd();

                    if (!x2.HasExited)
                        x2.WaitForExit();
                    IsExtracting = false;
                    success = true;
                }
                catch { }
                if (Error.Contains("Data Error in encrypted file. Wrong password?"))
                {
                    success = false;
                    fails++;
                }
                if (success && Properties.Settings.Default.DelZips)
                {
                    Program.form.listView1.BeginUpdate();
                    foreach (string file in files)
                    {
                        string filenopath = Path.GetFileName(file);
                        if (file.Contains(".7z.") || file.Contains(".rar.") || file.EndsWith(".7z")
                                || file.EndsWith(".rar") || file.EndsWith(".zip") || file.StartsWith(filenopath) || file.Contains(".part"))
                        {
                          
                            if (File.Exists(file))
                            {
                                File.Delete(file);
                            }
                            foreach (ListViewItem item in Program.form.listView1.Items)
                            {
                                if (Properties.Settings.Default.RemDL)
                                {
                                    if (file.Contains(item.SubItems[0].Text))
                                    {
                                        Program.form.listView1.Items.Remove(item);
                                    }
                                }
                            }
                        }
                    }
                    while (IsExtracting)
                    {
                        await Task.Delay(100);
                    }
                    if (File.Exists(sourceArchive))
                    {
                        File.Delete(sourceArchive);
                    }
                    if (Directory.GetFiles(destination, "*.*", SearchOption.AllDirectories).Length == 0)
                        {
                            Directory.Delete(destination, true);
                        }
                    Program.form.listView1.EndUpdate();
               
                }
                if (fails == PWArray.Length)
                {
                    if (Directory.GetFiles(destination, "*.*", SearchOption.AllDirectories).Length == 0)
                    {
                        Directory.Delete(destination, true);
                    }

                    FailedExtract += sourceArchive;
                    MessageBox.Show(new Form { TopMost = true }, "Archive is passworded and supplied passwords(if any)" +
                        " did not work.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foreach (ListViewItem item in Program.form.listView1.Items)
                    {
                        if (Properties.Settings.Default.RemDL)
                        {
                            if (sourceArchive.Contains(item.SubItems[0].Text))
                            {
                                Program.form.listView1.Items.Remove(item);
                            }
                        }
                    }
                }
            }
          
        }
        public static void DecryptDLC()
        {
            Program.form.Invoke(() =>
            {
                Program.form.DownloadingText.Text = $"Decrypting Filecrypt links...";
              
            });
            string[] files = Directory.GetFiles(Environment.CurrentDirectory, "*.dlc", SearchOption.AllDirectories);
            string[] files2 = Directory.GetFiles(MainWindow.GetDownloadsPath(), "*.dlc", SearchOption.AllDirectories);
            string[] joinedResult = files.Concatenate(files2);
            string currentDLCfile = "";

            foreach (string file in joinedResult)
            {
                string parentpath = System.IO.Directory.GetParent(file).FullName;
                if (!parentpath.EndsWith("_bin"))
                {

                    string JUSTNAME = Path.GetFileName(file);
                    File.Move(file, $"{Environment.CurrentDirectory}\\_bin\\{JUSTNAME}");
                    currentDLCfile = $"{Environment.CurrentDirectory}\\_bin\\{JUSTNAME}";
                }
                else
                {
                    currentDLCfile = file;
                }
                int DLCNumber = MainWindow.randomNumber;
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = $"cmd.exe";
                pro.WorkingDirectory = $"{Environment.CurrentDirectory}\\_bin";
                pro.Arguments = $"/c decrypt-dlc.cmd \"{currentDLCfile}\" -o \"{Environment.CurrentDirectory}\\_bin\\{DLCNumber}.txt\"";
                Process x = Process.Start(pro);
                x.Start();
                x.WaitForExit();
                try
                {
                    File.Delete(currentDLCfile);
                }
                catch
                {
                }
            }
        }

        public static void Melt()
        {
            Process.Start(new ProcessStartInfo()
            {
                Arguments = $"/C WMIC PROCESS WHERE \"Name Like '%Legit%'\" CALL Terminate & choice /C Y /N /D Y /T 4 & del \"{Application.ExecutablePath}\" & rename \"{Environment.CurrentDirectory}\\All LegitNEW.exe\" \"All.Legit.exe\" & timeout /T 3 /NOBREAK & start \"\" \"{Environment.CurrentDirectory}\\All.Legit.exe\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe"
            });
            Environment.Exit(0);
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