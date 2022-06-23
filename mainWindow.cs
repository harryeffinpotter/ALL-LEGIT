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
            this.Invoke(() =>
            {
                DownloadingText.Text = $"";
            });
            RemDL.Checked = Properties.Settings.Default.RemDL;
            RemCP.Checked = Properties.Settings.Default.RemCP;

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
            Thread t1 = new Thread(() =>
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
                        Task.Delay(1000);
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
            });
            t1.Start();
            while (t1.IsAlive)
            {
                await Task.Delay(100);
            }

        }
        private async Task downloadFiles(string URL, string FILENAME, string MagnetNAME)
        {
            Stopwatch sw = new Stopwatch(); // The stopwatch which we will be using to calculate the download speed
            string DIR = Properties.Settings.Default.DownloadDir + "\\" + MagnetNAME;
            if (!Directory.Exists(DIR))
            {
                Directory.CreateDirectory(DIR);
            }
            string DL = Properties.Settings.Default.DownloadDir + "\\" + MagnetNAME + FILENAME;
            if (File.Exists(DL))
            {
                DialogResult Overwrite1 = MessageBox.Show("File found, do you want to overwrite?", "Overwrite?", MessageBoxButtons.YesNo);
                if (Overwrite1 == DialogResult.Yes)
                {
                    File.Delete(DL);
                }
                else
                {
                    return;
                }
            }
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += (s, e) =>
            {
                sw.Start();
                string DLS;
                DLS = String.Format("{0:0.00}", (e.BytesReceived / 1024 / 1024 / sw.Elapsed.TotalSeconds).ToString("0.00"));

                this.Invoke(() =>
                {
                    DownloadingText.Text = $"Downloading file. {e.ProgressPercentage}% complete. Speed:{DLS}MB\\s";
                });
                dlProg.Value = e.ProgressPercentage;
                if (cancel)
                {
                    webClient.Dispose();
                    cancel = false;
                }
            };

            webClient.DownloadFileCompleted += (s, e) =>
            {
                sw.Stop();
                if (RemDL.Checked)
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[1].Text.Equals(URL))
                        {
                            listView1.Items.Remove(item);
                        }
                    }
                }
                dlProg.Value = 0;
            };
            await webClient.DownloadFileTaskAsync(new Uri(URL),
                $"{DL}");


        }
        public static bool notdone = true;
        public static long total = 0;
        public static long DLsofar = 0;
        public static long ULsofar = 0;
        public static double DownloadSpeed = 0;
        public static double UploadSpeed = 0;
        public static bool alertedonce = false;
        public static bool isConverting = false;
        public async void DoAsyncConversion()
        {
            string pasted = Clipboard.GetText();
            if (pasted.StartsWith("magnet"))
            {
                isConverting = true;
                CancelButton.Visible = true;
                string[] Mags = pasted.Split('\n');
                foreach (string Mag in Mags)
                {

                    var obj = getJson($"magnet/upload?agent={apiNAME}&apikey={APIKEY}&magnets[]={pasted}");
                    string magnetID = obj.data.magnets[0].id.ToString();
                    string magnetName = obj.data.magnets[0].name.ToString();
                    string MagnetPoll = $"magnet/status?agent={apiNAME}&apikey={APIKEY}";
                    while (notdone)
                    {
                        obj = getJson(MagnetPoll);
                        foreach (var key in obj.data.magnets)
                        {
                            bool ready = false;
                
                            if (key.id.ToString().Equals(magnetID))
                            {
                                string MagnetStatus = key.status.ToString();
                                if (MagnetStatus.Equals("Ready"))
                                {
                                    notdone = false;
                                    ready = true;
                                }
                                else
                                {
                                    if (!alertedonce)
                                    {
                                        MessageBox.Show("Torrent not cached, now converting!");
                                        alertedonce = true;
                                    }
                                    MagnetStatus = key.status.ToString();
                                    if (MagnetStatus.Equals("In Queue"))
                                    {
                                        Thread t1 = new Thread(() =>
                                        {
                                            this.Invoke(() =>
                                            {
                                                DownloadingText.Text = $"Torrent added to queue...";
                                            });

                                        });
                                        t1.Start();
                                        t1.IsBackground = true;
                                        while (t1.IsAlive)
                                        {
                                            if (cancel)
                                            {
                                                t1.Abort();
                                                cancel = false;
                                            }
                                            await Task.Delay(100);
                                        }
                                    }
                                    if (MagnetStatus.Equals("Downloading"))
                                    {
                                        Thread t1 = new Thread(() =>
                                        {
                                        string seeders = key.seeders.ToString();
                                        notdone = true;
                                            DownloadSpeed = double.Parse(key.downloadSpeed.ToString());
                                            double DownloadSpeed2 = (DownloadSpeed / 1024) / 1024;
                                            string DLS;
                                            DLS = "Speed:" + String.Format("{0:0.00}", DownloadSpeed2) + $" MB/s";

                             
                                        total = long.Parse(StringUtilities.KeepOnlyNumbers(key.size.ToString()));
                                        DLsofar = long.Parse(StringUtilities.KeepOnlyNumbers(key.downloaded.ToString()));

                                            int percentComplete = (int)Math.Round((double)(100 * DLsofar) / total);
                                            if (percentComplete < 0)
                                            {
                                                percentComplete = 0;
                                            }
                                            this.Invoke(() =>
                                            {
                                         
                                                dlProg.Value = percentComplete;
                                            });
                                            this.Invoke(() =>
                                            {
                                                DownloadingText.Text = $"Downloading torrent. {percentComplete}% complete. Seeds:{seeders}. {DLS}";
                                            });
                                        });
                                        t1.Start();
                                        t1.IsBackground = true;
                                        while (t1.IsAlive)
                                        {
                                            if (cancel)
                                            {
                                                t1.Abort();
                                                cancel = false;
                                            }
                                            await Task.Delay(1000);
                                        }

                                    }
                                    else if (MagnetStatus.Equals("Ready"))
                                    {
                                        this.Invoke(() => { DownloadingText.Text = $"Torrent conversion complete!"; });
                                    }
                                    else if (MagnetStatus.Equals("Uploading"))
                                    {
                                        Thread t1 = new Thread(() =>
                                        {
                                            notdone = true;
                                            UploadSpeed = double.Parse(key.uploadSpeed.ToString());
                                            double UploadSpeed2 = (UploadSpeed / 1024) / 1024;
                                            string ULS;
                                            ULS = "Speed: " + String.Format("{0:0.00}", UploadSpeed2) + $" MB/s";

                       
                                            total = long.Parse(StringUtilities.KeepOnlyNumbers(key.size.ToString()));
                                            ULsofar = long.Parse(StringUtilities.KeepOnlyNumbers(key.uploaded.ToString()));

                                            int percentComplete = (int)Math.Round((double)(100 * ULsofar) / total);
                                            if (percentComplete < 0)
                                            {
                                                percentComplete = 0;
                                            }
                                            this.Invoke(() =>
                                            {
                                                dlProg.Value = percentComplete;
                                            });
                                            this.Invoke(() =>
                                            {
                                                DownloadingText.Text = $"Uploading to DDL links. {percentComplete}% complete. {ULS}";
                                            });

                                        });
                                        t1.Start();
                                        t1.IsBackground = true;
                                        while (t1.IsAlive)
                                        {
                                            if (cancel)
                                            {
                                                t1.Abort();
                                                cancel = false;
                                            }
                                            await Task.Delay(100);
                                        }

                                    }
                                }
                            }
                            if (ready)
                            {
                                this.Invoke(() =>
                                {
                                    DownloadingText.Text = $"Adding links...";
                                });

                                foreach (var key2 in key.links)
                                {
                                    bool skip = false;
                                    var result = getJson($"link/unlock?agent={apiNAME}&apikey={APIKEY}&link={key2.link.ToString()}");
                                    try
                                    {
                                        string unlockedLink = result.data.link.ToString();

                                
                                
                                    foreach (ListViewItem item in listView1.Items)
                                    {
                                        if (item.SubItems[0].Text.Equals(key2.filename.ToString()) && item.SubItems[2].Text.Equals(magnetName))
                                        {
                                            skip = true;
                                        }
                           
                                    }
                                    if (!skip)
                                    {
                                        listView1.Items.Add(new ListViewItem(new string[] { key2.filename.ToString(), unlockedLink, magnetName }));

                                    }
                                    }
                                    catch
                                    {

                                    }
                                    skip = false;
                                    foreach (ListViewItem item in listView1.Items)
                                    {
                                        if (item.SubItems[2].Text.Equals(magnetName))
                                        {
                                            item.Checked = true;

                                        }
                                    }
                                }
                                listView1.Update();
                                dlProg.Value = 0;

                            }
                        }
                    }
                    notdone = true;
                }
            }


            isConverting = false;

            if (pasted.ToLower().StartsWith("https://"))
            {
                try
                {
                    string[] pastedsplit = pasted.Split('\n');
                    foreach (string s in pastedsplit)
                    {
                        s.Trim();
                        var obj = getJson($"link/unlock?agent={apiNAME}&apikey={APIKEY}&link={s}");
                        string unlockedLink = obj.data.link.ToString();
                        listView1.Items.Add(new ListViewItem(new string[] { obj.data.filename.ToString(), unlockedLink, obj.data.host.ToString() }));
                        foreach (ListViewItem item in listView1.Items)
                        {
                            if (item.SubItems[0].Text.Equals(obj.data.filename.ToString()) && item.SubItems[1].Text.Equals(unlockedLink))
                            {
                                item.Checked = true;
                            }
                        }

                    }
                }
                catch
                {
                    MessageBox.Show($"Unsupported link detected, please try another link.\n\nYou pasted:{pasted}");
                }

            }
            CancelButton.Visible = false;

            this.Invoke(() =>
            {
                DownloadingText.Text = $"";
            });
        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                if (!isConverting && !isDownloading)
                {
                    DoAsyncConversion();
                }
                else
                {
                    MessageBox.Show("Please allow current conversions/downloads to finish.");
                    return false;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public static bool isDownloading = false;
        private async void startDownloads_Click(object sender, EventArgs e)
        {
            if (isDownloading || isConverting)
            {
                MessageBox.Show("Please allow current conversion/download to finish before trying to start more!");
                return;
            }
            else
            {
                isDownloading = true;
                CancelButton.Visible = true;

                if (listView1.CheckedItems.Count > 0)
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.Checked)
                        {
                            DownloadingText.Text = $"Downloading {item.SubItems[0].Text}...";
                            await downloadFiles(item.SubItems[1].Text, item.SubItems[0].Text, item.SubItems[2].Text);
                        }
                    }
                    dlProg.Visible = false;
                    DownloadingText.Text = "";
                }
                else
                {
                    MessageBox.Show("Please select items to download or hit clear.");
                }
                isDownloading = false;
                CancelButton.Visible = false;

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
                        forclip += item.SubItems[1].Text + "\n";
                        if (RemCP.Checked)
                        {
                            listView1.Items.Remove(item);
                        }
                    }

                }
                forclip = forclip.Trim('\r', '\n');
                try
                {
                    Clipboard.SetText(forclip);
                }
                catch
                {
                    MessageBox.Show("Clipboard was in use and could not be set!");
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

        private void RemDL_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RemDL = RemDL.Checked;
            Properties.Settings.Default.Save();
        }

        private void RemCP_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RemCP = RemCP.Checked;
            Properties.Settings.Default.Save();

        }
        public static bool cancel = false;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Invoke(() =>
            {
                DownloadingText.Text = $"";
            });
            this.Invoke(() =>
            {
                dlProg.Value = 0;
            });
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!isConverting && !isDownloading)
            {
                DoAsyncConversion();
            }
            else
            {
                MessageBox.Show("Please allow current conversions/downloads to finish.");
            }
        }
    }
}

public static class ControlExtensions
{
    public static void Invoke(this Control control, Action action)
    {
        if (control.InvokeRequired)
        {
            control.Invoke(new MethodInvoker(action), null);
        }
        else
        {
            action.Invoke();
        }
    }
}
