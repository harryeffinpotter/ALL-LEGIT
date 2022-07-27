using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace ALL_LEGIT
{
    class Updater
    {
        public static string AppName { get; set; }
        public static string Repostory { get; set; }
        private static string RawGitHubUrl;
        private static string GitHubUrl;

        static readonly public string LocalVersion = "1.0.3";
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
                currentVersion = currentVersion.Trim('\n');
                currentVersion = currentVersion.Trim('\r');
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
                fileClient.DownloadFile($"https://github.com/harryeffinpotter/ALL-LEGIT/blob/master/bin/All.Legit.exe", $"All LegitNEW.exe");
                fileClient.Dispose();
                Program.form.ALTrayIcon.Icon.Dispose();
                Program.form.ALTrayIcon.Dispose();
                //Delete current version
                ALL_LEGIT.Utilities.Melt();
            }
            catch { }
        }
    }
}
