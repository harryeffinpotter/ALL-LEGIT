using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Collections;

namespace ALL_LEGIT
{
    public partial class MainWindow : Form
    {
        public static string APIKEY;
        public static string apiNAME;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DownloadDir == null || Properties.Settings.Default.DownloadDir.Length < 3)
            {
                Properties.Settings.Default.DownloadDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads\\AllLegit Downloads";
                Properties.Settings.Default.Save();
                if (!Directory.Exists(Properties.Settings.Default.DownloadDir))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.DownloadDir);
                }
            }
            DownloadDir.Text = Properties.Settings.Default.DownloadDir;
            await ConnectViaAPIAsync();
            while (!loginsuccess)
            {
                connectedLbl.Text = "Not Connected";
                connectedLbl.ForeColor = Color.HotPink;
            }
            if (loginsuccess)
            {
                connectedLbl.Text = "Connected!";
                connectedLbl.ForeColor = Color.LightGreen;
            }
        }

        public static dynamic getJson(string requestURL)
        {
            var client = new RestClient($"https://api.alldebrid.com/v4/");
            var request = new RestRequest(requestURL, Method.Get);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var queryResult = client.Execute(request);
            var obj = JsonConvert.DeserializeObject<dynamic>(queryResult.Content);
            return obj;
        }
        public static bool loginsuccess = false;
        public static async Task ConnectViaAPIAsync()
        {

            apiNAME = Properties.Settings.Default.ApiNAME;
            APIKEY = Properties.Settings.Default.ApiKEY;
            if (!String.IsNullOrWhiteSpace(apiNAME) || !String.IsNullOrWhiteSpace(APIKEY))
            {
                apiNAME = Properties.Settings.Default.ApiNAME;
                APIKEY = Properties.Settings.Default.ApiKEY;
                var auth = getJson($"user?agent={apiNAME}&apikey={APIKEY}");
                if (!auth.ToString().Contains("AUTH"))
                {
                    loginsuccess = true;
                }
                else
                {
                    MessageBox.Show("Previously set API key no longer working... you must reconnect!");
                }
            }

            if (!loginsuccess)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 1000);
                apiNAME = $"AllLegit{randomNumber}";
                Properties.Settings.Default.ApiNAME = apiNAME;
                Properties.Settings.Default.Save();
                var obj = getJson($"pin/get?agent={apiNAME}");

                Process.Start(obj.data.user_url.ToString());
                string CheckURL = obj.data.check_url.ToString();
                obj = getJson(CheckURL);
                bool Activated;
                Activated = bool.Parse(obj.data.activated.ToString());
                while (!Activated)
                {
                    obj = getJson(CheckURL);
                    Activated = bool.Parse(obj.data.activated.ToString());
                    await Task.Delay(100);
                }

                if (Activated)
                {
                    obj = getJson(CheckURL);
                    APIKEY = obj.data.apikey.ToString();
                    Properties.Settings.Default.ApiKEY = APIKEY;
                    Properties.Settings.Default.Save();
                }

                var auth = getJson($"user?agent={apiNAME}&apikey={APIKEY}");
                if (!auth.ToString().Contains("AUTH"))
                {
                    loginsuccess = true;
                }
                else
                {
                    MessageBox.Show("Previously set API key no longer working... you must reconnect!");
                }
            }


        }
        private void downloadFiles(string URL, string FILENAME)
        {
            string DL = Properties.Settings.Default.DownloadDir + "\\" + FILENAME;
            if (File.Exists(DL))
            {

                    File.Delete(DL);
                
            }
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += (s, e) =>
            {
                dlProg.Value = e.ProgressPercentage;
            };
            webClient.DownloadFileCompleted += (s, e) =>
            {
                dlProg.Visible = false;
                foreach (ListViewItem item in listView1.Items)
                {
                if (item.SubItems[1].Text.Equals(URL))
                    {
                        listView1.Items.Remove(item);
                    }
                }
            };
            webClient.DownloadFileAsync(new Uri(URL),
                $"{DL}");


        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                string pasted = Clipboard.GetText();
                if (pasted.StartsWith("magnet"))
                {
                    var obj = getJson($"magnet/upload?agent={apiNAME}&apikey={APIKEY}&magnets[]={pasted}");
                    string magnetID = obj.data.magnets[0].id.ToString();
                    obj = getJson($"magnet/status?agent={apiNAME}&apikey={APIKEY}&id={magnetID}");
                    foreach (var key in obj.data.magnets.links)
                    {
         
                        var result = getJson($"link/unlock?agent={apiNAME}&apikey={APIKEY}&link={key.link}");
                        string unlockedLink = result.data.link.ToString();
                        listView1.Items.Add(new ListViewItem(new string[] {key.filename.ToString(), unlockedLink}));
                    }
                    listView1.Update();
                    foreach (ListViewItem item in listView1.Items)
                    {
                        item.Checked = true;
                    }
                    listView1.Update();

                }
            }
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void startDownloads_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    dlProg.Value = 0;
           
                    if (item.Checked)
                    {
                        DownloadingText.Text = $"Downloading {item.SubItems[0].Text}...";
                        downloadFiles(item.SubItems[1].Text, item.SubItems[0].Text);
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select items to download or hit clear.");
            }
        }

        private void CopyLinks_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                string forclip = "";
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Checked)
                    {
                        var result = getJson($"link/unlock?agent={apiNAME}&apikey={APIKEY}&link={item.SubItems[1].Text}");
                        forclip += result.data.link.ToString() + "\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select items to download or hit clear.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void SetDLDIR_Click(object sender, EventArgs e)
        {
            FolderSelectDialog folderSelectDialog = new FolderSelectDialog();
            folderSelectDialog.Title = "Select All Legit download directory...";
            if (Properties.Settings.Default.DownloadDir != null)
                folderSelectDialog.InitialDirectory = Properties.Settings.Default.DownloadDir;
            if (folderSelectDialog.Show(Handle))
            {
                Properties.Settings.Default.DownloadDir = folderSelectDialog.FileName;
                Properties.Settings.Default.Save();
            }
            DownloadDir.Text = Properties.Settings.Default.DownloadDir;
        }
    }
}
