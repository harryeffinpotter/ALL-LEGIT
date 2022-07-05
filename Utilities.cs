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
    public class Utilities
    {

        public void ExtractFile(string sourceArchive, string destination)
        {
            string basename = "";
            bool rar = false;
            if (sourceArchive.EndsWith(".rar"))
            {
                basename = Path.GetFileNameWithoutExtension(sourceArchive);
                basename = Path.GetFileNameWithoutExtension(basename);
            } 
            else
            {
                basename = Path.GetFileNameWithoutExtension(sourceArchive);
            }
         

            ProcessStartInfo pro = new ProcessStartInfo();
            pro.WindowStyle = ProcessWindowStyle.Hidden;
            pro.UseShellExecute = false;
            pro.CreateNoWindow = true;
            pro.RedirectStandardError = true;
            pro.RedirectStandardOutput = true;
            pro.FileName = $"{Environment.CurrentDirectory}\\7z.exe";

            if (!String.IsNullOrEmpty(Properties.Settings.Default.ZipPWS))
            {
                string[] PWArray = MainWindow.PWLIST.Split(';');
                int PWArrCount = PWArray.Length;
                int fails = 0;
                foreach (string PW in PWArray)
                {
                    bool success = false;
                    try
                    {

                        pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sourceArchive, destination) + $" -p\"{PW}\"";
                        Process x2 = Process.Start(pro);
                        if (!x2.HasExited)
                            x2.WaitForExit();
                        success = true;
                    }
                    catch (Exception ex2)
                    {
                        if (ex2.Message.Contains("Data Error in encrypted file. Wrong password?"))
                        {
                            success = false;
                            fails++;
                        }
                    }
                    if (success && Properties.Settings.Default.DelZips)
                    {
                        if (File.Exists(sourceArchive))
                        {
                            File.Delete(sourceArchive);
                        }
                        string[] files = Directory.GetFiles(destination);
                        MainWindow.listView1.BeginUpdate();
                        foreach (string file in files)
                        {
                            if (file.Contains(basename) && !String.IsNullOrEmpty(basename))
                            {
                                if (File.Exists(file))
                                {
                                    File.Delete(file);
                                }
                            }
                            foreach (ListViewItem item in MainWindow.listView1.Items)
                            {
                                if (file.Contains(item.SubItems[0].Text))
                                { 
                                    MainWindow.listView1.Items.Remove(item);

                                }
                            }
                        }
                        MainWindow.listView1.EndUpdate();
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









        public static void DecryptDLC()
        {

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