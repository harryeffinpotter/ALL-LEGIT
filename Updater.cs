using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.RightsManagement;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace ALL_LEGIT
{
    class Updater
    {
        public static string AppName { get; set; }
        public static string Repostory { get; set; }

        private static string RawGitHubUrl = "https://raw.githubusercontent.com/harryeffinpotter/ALL-LEGIT";
        private static string GitHubUrl;

        static readonly public string LocalVersion = "1.2.0";
        public static string currentVersion = "";
        public static string currentHFVersion = "";
        public static string changelog = "";

        //Check if there is a new version of the sideloader
        private static bool IsUpdateAvailable()
        {
            HttpClient client = new HttpClient();
            try
            {
                currentVersion = client.GetStringAsync($"{RawGitHubUrl}/master/version").Result;
                currentVersion = currentVersion.Trim();
                client.Dispose();
            }
            catch { return false; }

            int CurrentVer;
            int.TryParse(Utilities.KeepOnlyNumbers(currentVersion), out CurrentVer);
            int LocalVer;
            int.TryParse(Utilities.KeepOnlyNumbers(LocalVersion), out LocalVer);
            return LocalVer < CurrentVer;
        }
        public static bool UpdateNotAvailable = false;
        //Call this to ask the user if they want to update
        public static void Update()
        {
            RawGitHubUrl = $"https://raw.githubusercontent.com/harryeffinpotter/ALL-LEGIT";
            GitHubUrl = $"https://github.com/harryeffinpotter/ALL-LEGIT";
            if (IsUpdateAvailable())
            {
                if (Properties.Settings.Default.AutoUpdate)
                {
                    doUpdate();
                }
                else
                {
                   DialogResult diag = MessageBox.Show(new Form { TopMost = true }, "Update is available, would you like to update now?", "Update now?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diag == DialogResult.Yes)
                    {
                        doUpdate();
                    }
                }
            }
            else
            {
                UpdateNotAvailable = true;
            }
        }

        //If the user wants to update
        public static void doUpdate()
        {
            try
            {
                var fileClient = new WebClient();
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                fileClient.DownloadFile($"https://github.com/harryeffinpotter/ALL-LEGIT/raw/master/All.Legit.exe", $"All LegitNEW.exe");
                fileClient.Dispose();

                string config = $"{Environment.CurrentDirectory}\\All.Legit.exe.config";
                if (File.Exists(config))
                {
                    config.FileRecycle();
                }
                fileClient.DownloadFile($"https://github.com/harryeffinpotter/ALL-LEGIT/raw/master/All.Legit.exe.config", $"All.Legit.exe.config");
                fileClient.Dispose();
                Program.form.ALTrayIcon.Icon.Dispose();
                Program.form.ALTrayIcon.Dispose();
                //Delete current version
                ALL_LEGIT.Utilities.Melt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
