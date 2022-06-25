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
using Timer = System.Windows.Forms.Timer;
using Gma.System.MouseKeyHook;

namespace ALL_LEGIT
{
    public partial class MainWindow : Form
    {
        public static string APIKEY;
        public static string apiNAME;
        public static bool waitingforkey = false;
        public static Timer a = new Timer();
        public static Keys hotkeyset = Properties.Settings.Default.HotKeyKeyData;
        public MainWindow()
        {

            try
            {
                Hook.GlobalEvents().KeyDown += async (sender, e) =>
                {


                    if (waitingforkey)
                    {

                        if (e.KeyData.ToString().Equals("LControlKey"))
                        {
                            HotKeyBox.Text = e.KeyData.ToString().Replace("LControlKey", "Control +");
                        }
                        if (e.KeyData.Equals(Keys.Control) || e.KeyData.Equals(Keys.ControlKey) || e.KeyData.Equals(Keys.LControlKey))
                        {
                            HotKeyBox.Text = "Control +";
                        }

                        HotKeyBox.Text = e.KeyData.ToString().Replace(",", " +");
                        if (HotKeyBox.Text.Contains("Control") && !HotKeyBox.Text.Contains("+") && !HotKeyBox.Text.Contains("LControlKey") || HotKeyBox.Text.Contains("LControlKey"))
                        {
                            HotKeyBox.Text = Properties.Settings.Default.HotKeyKeyData.ToString().Replace(",", " +");
                        }
                        if (e.KeyData.ToString().Contains("LControlKey, Control") || e.KeyData.ToString().Contains("Control") && !e.KeyData.ToString().Contains(" ") || e.KeyData.ToString().Contains("LControlKey") && !e.KeyData.ToString().Contains(" "))
                        {
                            return;

                        }
                        else
                        {
                            hotkeyset = e.KeyData;

                        }
                        Hook.GlobalEvents().KeyUp += (sendeee, eee) =>
                        {
                            if (hotkeyset.Equals(Keys.Control) || hotkeyset.Equals(Keys.ControlKey) || hotkeyset.Equals(Keys.LControlKey) || hotkeyset.ToString().Equals("LControlKey, Control"))
                            {
                                waitingforkey = false;
                                return;
                            }
                            else
                            {
                                Properties.Settings.Default.HotKeyKeyData = hotkeyset;
                                Properties.Settings.Default.Save();
                                HotKeyBox.Text = Properties.Settings.Default.HotKeyKeyData.ToString().Replace(",", " +");
                                waitingforkey = false;
                            }


                        };

                    }

                    else
                    {
                        if (e.KeyData == Properties.Settings.Default.HotKeyKeyData)
                        {
                            if (!isConverting && !isDownloading)
                            {
                                DoAsyncConversion();
                            }
                            else
                            {
                                MessageBox.Show("Please allow current conversions/downloads to finish.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                return;
                            }
                        }
                    }
   

                };
            }
            catch { }

            InitializeComponent();
        }



        private async void MainWindow_Load(object sender, EventArgs e)
        {
            AutoDLBox.Checked = Properties.Settings.Default.AutoDL;
            HotKeyBox.Text = Properties.Settings.Default.HotKeyKeyData.ToString().Replace(",", " +");

            AutoExtract.Checked = Properties.Settings.Default.AutoExtract;
            if (!String.IsNullOrEmpty(Properties.Settings.Default.ZipPWS))
            {
                PWBox.Text = Properties.Settings.Default.ZipPWS;
                PWLIST = PWBox.Text;
            }
            StayOnTopCheckbox.Checked = Properties.Settings.Default.TopMost;
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

                MainWindow.ActiveForm.Text = "All-Legit: Not Connected";

            }
            if (loginsuccess)
            {

                MainWindow.ActiveForm.Text = "All-Legit: Connected";

            }
        }

        public static dynamic getJson(string requestURL)
        {
            try
            {
                var client = new RestClient($"https://api.alldebrid.com/v4/");
                var request = new RestRequest(requestURL, Method.Get);
                request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
                var queryResult = client.Execute(request);
                var obj = JsonConvert.DeserializeObject<dynamic>(queryResult.Content);
                return obj;
            }
            catch
            {
                if (!cancel)
                {
                    MessageBox.Show("Not able to access the internet, so cannot login... Exiting program.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    Application.Exit();
                    return null;
                }
                return null;
            }
        }
        public static bool loginsuccess = false;
        public static async Task ConnectViaAPIAsync()
        {
            Thread t1 = new Thread(() =>
            {
                try
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
                            MessageBox.Show("Previously set API key no longer working... you must reconnect!", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
                            MessageBox.Show("Previously set API key no longer working... you must reconnect!", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                }
                catch
                {
                    Application.Exit();
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
            string DL = Properties.Settings.Default.DownloadDir + "\\" + MagnetNAME + "\\" + FILENAME;
            if (File.Exists(DL))
            {
                DialogResult Overwrite1 = MessageBox.Show("File found, do you want to overwrite?", "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
                    dlProg.Value = e.ProgressPercentage;
                });

                if (cancel)
                {
                    webClient.Dispose();
                    cancel = false;
                }
            };

            webClient.DownloadFileCompleted += (s, e) =>
            {
                this.Invoke(() =>
                {
                    DownloadingText.Text = $"Download finished...";
                });

                sw.Stop();
                if (RemDL.Checked)
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[1].Text.Equals(URL))
                        {
                            this.Invoke(() =>
                            {
                                listView1.Items.Remove(item);
                                listView1.Update();
                            });
                        }
                    }
                }


                this.Invoke(() =>
                {
                    dlProg.Value = 0;
                });
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
        public static string PWLIST = "";
        public static string filecryptlist = "";
        public static bool filecryptinprog = false;
        public async void DoAsyncConversion()
        {

            cancel = false;
            SplashText.Visible = false;
            string pasted = Clipboard.GetText();
            Thread t1 = new Thread(() =>
            {
                isConverting = true;
                if (pasted.StartsWith("magnet"))
                {

                    pasted = pasted.Trim();
                    string[] output = new string[] { pasted };
                    if (pasted.Contains(";"))
                    {
                        string[] pastedsplit = pasted.Split(';');
                        output = pastedsplit;

                    }
                    else if (pasted.Contains("\r\n"))
                    {
                        pasted = pasted.Replace("\r\n", "\n");
                        string[] pastedsplit = pasted.Split('\n');
                        output = pastedsplit;
                    }
                    else if (pasted.Contains('\r'))
                    {
                        string[] pastedsplit = pasted.Split('\r');
                        output = pastedsplit;
                    }
                    else if (pasted.Contains('\n'))
                    {
                        string[] pastedsplit = pasted.Split('\n');
                        output = pastedsplit;
                    }
                    bool isErrors = false;
                    int a = 0;
                    int b = 0;
                    int c = 0;
                    string a1 = "";
                    string b1 = "";
                    string c1 = "";
                    foreach (string s in output)
                    {
                        this.Invoke(() =>
                        {
                            CancelButton.Visible = true;
                        });

                        var obj = getJson($"magnet/upload?agent={apiNAME}&apikey={APIKEY}&magnets[]={s}");
                        string status = obj.status.ToString();

                        if (obj.data.magnets[0].ToString().Contains("error"))
                        {
                            isErrors = true;
                            string error = obj.data.magnets[0].error.code.ToString();
                            if (error.Contains("MAGNET_INVALID_URI"))
                            {
                                a++;
                                a1 += $"{s}\n";
                            }
                            if (error.Contains("MAGNET_TOO_MANY_ACTIVE"))
                            {
                                b++;
                                b1 += $"{s}\n";
                            }
                            if (error.Contains("MAGNET_NO_SERVER"))
                            {
                                c++;
                                c1 += $"{s}\n";
                            }
                        }
                        if (isErrors)
                        {
                            continue;
                        }
                        else
                        {

                            string magnetName = obj.data.magnets[0].name.ToString();

                            string magnetID = obj.data.magnets[0].id.ToString();
                            string MagnetPoll = $"magnet/status?agent={apiNAME}&apikey={APIKEY}";
                            while (notdone)
                            {
                                if (cancel)
                                {
                                    this.Invoke(() =>
                                    {
                                        DownloadingText.Text = $"";
                                        dlProg.Value = 0;
                                    });

                                    break;
                                }
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
                                                MessageBox.Show("Torrent not cached, now converting!", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                                alertedonce = true;
                                            }
                                            MagnetStatus = key.status.ToString();
                                            if (MagnetStatus.Equals("In Queue"))
                                            {

                                                this.Invoke(() =>
                                                {
                                                    DownloadingText.Text = $"Torrent added to queue...";
                                                });

                                            }
                                            if (MagnetStatus.Equals("Downloading"))
                                            {

                                                string seeders = key.seeders.ToString();
                                                notdone = true;
                                                DownloadSpeed = double.Parse(key.downloadSpeed.ToString());
                                                double DownloadSpeed2 = (DownloadSpeed / 1024) / 1024;
                                                string DLS;
                                                DLS = "Speed:" + String.Format("{0:0.00}", DownloadSpeed2) + $" MB/s";


                                                total = long.Parse(Utilities.KeepOnlyNumbers(key.size.ToString()));
                                                DLsofar = long.Parse(Utilities.KeepOnlyNumbers(key.downloaded.ToString()));

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


                                            }
                                            else if (MagnetStatus.Equals("Ready"))
                                            {
                                                this.Invoke(() => { DownloadingText.Text = $"Torrent conversion complete!"; });
                                            }
                                            else if (MagnetStatus.Equals("Uploading"))
                                            {

                                                notdone = true;
                                                UploadSpeed = double.Parse(key.uploadSpeed.ToString());
                                                double UploadSpeed2 = (UploadSpeed / 1024) / 1024;
                                                string ULS;
                                                ULS = "Speed: " + String.Format("{0:0.00}", UploadSpeed2) + $" MB/s";


                                                total = long.Parse(Utilities.KeepOnlyNumbers(key.size.ToString()));
                                                ULsofar = long.Parse(Utilities.KeepOnlyNumbers(key.uploaded.ToString()));

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
                                                double FileSize = double.Parse(result.data.filesize.ToString());
                                                string FileSizeInt = "";
                                                if ((FileSize / 1024 / 1024) > 1000)
                                                {
                                                    FileSizeInt = String.Format("{0:0.00}", (FileSize / 1024 / 1024 / 1024).ToString("0.00")) + "GB";

                                                }
                                                else
                                                {
                                                    FileSizeInt = (String.Format("{0:0.00}", (FileSize / 1024 / 1024).ToString("0.00"))) + "MB";
                                                }


                                                this.Invoke(() =>
                                                {
                                                    foreach (ListViewItem item in listView1.Items)
                                                    {
                                                        if (item.SubItems[0].Text.Equals(key2.filename.ToString()) && item.SubItems[2].Text.Equals(magnetName))
                                                        {
                                                            skip = true;
                                                            DownloadingText.Text = $"Item already in list!";
                                                        }
                                                    }
                                                    if (!skip)
                                                    {

                                                        listView1.Items.Add(new ListViewItem(new string[] { key2.filename.ToString(), unlockedLink, magnetName, FileSizeInt }));

                                                    }

                                                    if (listView1.Items.Count == 0)
                                                    {
                                                        this.Invoke(() =>
                                                        {
                                                            listView1.Items.Add(new ListViewItem(new string[] { key2.filename.ToString(), unlockedLink, magnetName, FileSizeInt }));
                                                        });
                                                    }

                                                    skip = false;
                                                    foreach (ListViewItem item in listView1.Items)
                                                    {
                                                        if (item.SubItems[2].Text.Equals(magnetName))
                                                        {
                                                            item.Checked = true;

                                                        }
                                                    }
                                                });
                                            }
                                            catch
                                            {
                                            }
                                        }
                                        this.Invoke(() =>
                                        {
                                            dlProg.Value = 0;
                                        });

                                    }
                                }
                            }
                        }
                        notdone = true;
                    }
                    if (isErrors)
                    {
                        if (a > 0)
                        {
                            MessageBox.Show($"{a1}\nMagnet(s) not valid.", "Invalid magnet.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                        }
                        if (b > 0)
                        {
                            MessageBox.Show($"{b1}\nAlready have maximum allowed active magnets (30).", "Cannot add over 30 torrents.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        if (c > 0)
                        {
                            MessageBox.Show($"{c1}\nServer are not allowed to use this feature. Visit https://alldebrid.com/vpn if you're using a VPN.", "Server error.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                        }
                        isConverting = false;

                    }
                }




                if (pasted.ToLower().StartsWith("https://filecrypt.co") || pasted.ToLower().StartsWith("https://www.filecrypt.co"))
                {
                    pasted = pasted.Trim();
                    string[] output = new string[] { pasted };
                    if (pasted.Contains(";"))
                    {
                        string[] pastedsplit = pasted.Split(';');
                        output = pastedsplit;

                    }
                    else if (pasted.Contains("\r\n"))
                    {
                        pasted = pasted.Replace("\r\n", "\n");
                        string[] pastedsplit = pasted.Split('\n');
                        output = pastedsplit;
                    }
                    else if (pasted.Contains('\r'))
                    {
                        string[] pastedsplit = pasted.Split('\r');
                        output = pastedsplit;
                    }
                    else if (pasted.Contains('\n'))
                    {
                        string[] pastedsplit = pasted.Split('\n');
                        output = pastedsplit;
                    }
                    foreach (string s in output)
                    {
                        Process.Start(s);
                        DialogResult d1 = MessageBox.Show("Please solve the Filecrypt.cc captcha, then click the DLC button to download the DLC file for AllLegit to parse!\n\nNote: Please save it to your Downloads folder within your use folder for this to work!\n\nWhen you are ready return to this messagebox and press OK.", "Captcha needed...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        if (d1 == DialogResult.OK)
                        {
                            this.Invoke(() =>
                            {
                                DownloadingText.Text = "Decrypting Filecrypt.cc DLC file...";
                            });
                            filecryptinprog = true;
                            Utilities.DecryptDLC();
                        }
                        else
                        {
                            cancel = true;
                        }
                    }


                }
                else if (pasted.ToLower().StartsWith("https://"))
                {
                    try
                    {
                        pasted = pasted.Trim();
                        string[] output = new string[] { pasted };
                        if (pasted.Contains(";"))
                        {
                            string[] pastedsplit = pasted.Split(';');
                            output = pastedsplit;

                        }
                        else if (pasted.Contains("\r\n"))
                        {
                            pasted = pasted.Replace("\r\n", "\n");
                            string[] pastedsplit = pasted.Split('\n');
                            output = pastedsplit;
                        }
                        else if (pasted.Contains('\r'))
                        {
                            string[] pastedsplit = pasted.Split('\r');
                            output = pastedsplit;
                        }
                        else if (pasted.Contains('\n'))
                        {
                            string[] pastedsplit = pasted.Split('\n');
                            output = pastedsplit;
                        }
                        bool isErrors = false;
                        int linkdown = 0;
                        string linkdowns = "";
                        int linkmissing = 0;
                        string linkmissings = "";
                        int linkpass = 0;
                        string linkpasss = "";
                        int linknotsup = 0;
                        string linknotsups = "";
                        foreach (string s in output)
                        {
                            var obj = getJson($"link/unlock?agent={apiNAME}&apikey={APIKEY}&link={s}");
                            if (obj.status.ToString().Equals("error"))
                            {
                                isErrors = true;
                                if (obj.error.code.ToString().Equals("LINK_DOWN"))
                                {
                                    linkdown++;
                                    linkdowns += s + "\n";
                                }

                                if (obj.error.code.ToString().Equals("LINK_IS_MISSING"))
                                {
                                    linkmissing++;
                                    linkmissings += s + "\n";
                                }
                                if (obj.error.code.ToString().Equals("LINK_PASS_PROTECTED"))
                                {
                                    linkpass++;
                                    linkpasss += s + "\n";
                                }
                                if (obj.error.code.ToString().Equals("LINK_HOST_NOT_SUPPORTED"))
                                {
                                    linknotsup++;
                                    linknotsups += s + "\n";
                                }
                            }
                            else
                            {

                                string unlockedLink = obj.data.link.ToString();
                                double FileSize = double.Parse(obj.data.filesize.ToString());
                                string FileSizeInt = "";
                                if ((FileSize / 1024 / 1024) > 1000)
                                {
                                    FileSizeInt = String.Format("{0:0.00}", (FileSize / 1024 / 1024 / 1024).ToString("0.00")) + "GB";

                                }
                                else
                                {
                                    FileSizeInt = (String.Format("{0:0.00}", (FileSize / 1024 / 1024).ToString("0.00"))) + "MB";
                                }

                                bool skip = false;
                                this.Invoke(() =>
                                {
                                    foreach (ListViewItem item in listView1.Items)
                                    {
                                        if (item.SubItems[0].Text.Equals(obj.data.filename.ToString()) && item.SubItems[2].Text.Equals(obj.data.host.ToString()))
                                        {
                                            skip = true;
                                        }
                                    }
                                    if (!skip)
                                    {

                                        listView1.Items.Add(new ListViewItem(new string[] { obj.data.filename.ToString(), unlockedLink, obj.data.host.ToString(), FileSizeInt }));

                                    }
                                    if (listView1.Items.Count == 0)
                                    {

                                        listView1.Items.Add(new ListViewItem(new string[] { obj.data.filename.ToString(), unlockedLink, obj.data.host.ToString(), FileSizeInt }));

                                    }
                                    foreach (ListViewItem item in listView1.Items)
                                    {
                                        if (item.SubItems[0].Text.Equals(obj.data.filename.ToString()) && item.SubItems[1].Text.Equals(unlockedLink))
                                        {
                                            item.Checked = true;
                                        }
                                    }
                                });
                            }

                        }
                        if (isErrors)
                        {
                            if (linkdown > 0)
                            {
                                MessageBox.Show($"{linkdowns}\nLink(s) have been taken down from the filehoster's website.\n\nNot adding!", "Link has been taken down.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            }
                            if (linkmissing > 0)
                            {
                                MessageBox.Show($"{linkmissings}\nNo magnets or links found in what you pasted.\n\nNot adding!", "No links found!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            }
                            if (linkpass > 0)
                            {
                                MessageBox.Show($"{linkpasss}\nLink(s) are password protected on the filehost's website.\n\nNot adding!", "Password protected!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            }
                            if (linknotsup > 0)
                            {
                                MessageBox.Show($"{linknotsups}\nLink(s) are from an unsupported host.\n\nPlease check this link for a list of supported filehosters:\nhttps://alldebrid.com/hosts/", "Unsupported host!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            }
                        }

                    }





                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show($"Unsupported link detected, please try another link.\n\nYou pasted:{pasted}", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }

                }


                this.Invoke(() =>
                {
                    CancelButton.Visible = false;
                    DownloadingText.Text = $"";
                    listView1.Update();
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
            isConverting = false;
            if (filecryptinprog)
            {
                string[] files = Directory.GetFiles($"{Environment.CurrentDirectory}\\_bin", "*.txt", SearchOption.TopDirectoryOnly);
                string linkstoget = "";
                foreach (string file in files)
                {
                    if (file.Contains("urls"))
                    {
                        string[] list = File.ReadAllLines(file);
                        foreach (string line in list)
                        {
                            linkstoget += line + "\n";
                        }
                        File.Delete(file);
                    }

                }
                if (!String.IsNullOrWhiteSpace(linkstoget))
                {
                    Clipboard.SetText(linkstoget);
                    DoAsyncConversion();
                    linkstoget = "";
                    filecryptinprog = false;
                }

            }
            if (Properties.Settings.Default.AutoDL)
            {
                object sender = null;
                EventArgs e = new EventArgs();
                startDownloads_Click(sender, e);
            }
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
                    MessageBox.Show("Please allow current conversions/downloads to finish.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
                MessageBox.Show("Please allow current conversion/download to finish before trying to start more!", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            else
            {
                string DLList = "";
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
                            if (AutoExtract.Checked)
                            {
                                DLList += $"{item.SubItems[0].Text};{item.SubItems[2].Text}\n";
                            }

                        }

                    }
                    if (AutoExtract.Checked)
                    {
                        this.Invoke(() =>
                        {
                            string[] SplitDLList = DLList.Split('\n');
                            foreach (string FullDL in SplitDLList)
                            {
                                if (!String.IsNullOrWhiteSpace(FullDL))
                                {
                                    string[] DLS = FullDL.Split(';');
                                    if (DLS[0].ToString().EndsWith(".zip".ToLower()) || DLS[0].ToString().EndsWith(".7z.001".ToLower()) || DLS[0].ToString().EndsWith(".7z".ToLower())
                                        || DLS[0].ToString().EndsWith(".001".ToLower()) || DLS[0].ToString().EndsWith(".part01.rar".ToLower()) || DLS[0].ToString().EndsWith(".rar".ToLower()) && !DLS[0].ToString().Contains(".part".ToLower()))
                                    {
                                        DownloadingText.Text = "Extracting archives...";
                                        string DLDir = Properties.Settings.Default.DownloadDir + "\\" + DLS[1].ToString();
                                        string DL = Properties.Settings.Default.DownloadDir + "\\" + DLS[1].ToString() + "\\" + DLS[0].ToString();
                                        if (!Directory.Exists(DLDir))
                                        {
                                            Directory.CreateDirectory(DLDir);
                                        }
                                        string FileName = DLS[0].ToString().Remove(DLS[0].ToString().Length - 4);
                                        string ArchiveDIR = DLDir + "\\" + "_AutoExtracted" + "\\" + FileName;
                                        if (!Directory.Exists(ArchiveDIR))
                                        {
                                            Directory.CreateDirectory(ArchiveDIR);
                                        }

                                        Utilities.ExtractFile(DL, ArchiveDIR);
                                    }
                                }

                            }

                        });
                    }
                    this.Invoke(() =>
                    {
                        dlProg.Value = 0;
                        DownloadingText.Text = "";
                    });

                }
                else
                {
                    MessageBox.Show("Please select items to download or hit clear.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
                            this.Invoke(() =>
                            {
                                listView1.Items.Remove(item);
                                listView1.Update();
                            });
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
                    MessageBox.Show("Clipboard was in use and could not be set!", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else
            {
                MessageBox.Show("Please select items to download or hit clear.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Update();
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
            cancel = true;
            this.Invoke(() =>
            {
                DownloadingText.Text = $"";
            });
            this.Invoke(() =>
            {
                dlProg.Value = 0;
            });
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            if (!isConverting && !isDownloading)
            {
                DoAsyncConversion();
            }
            else
            {
                this.Invoke(() =>
                {
                    MessageBox.Show("Please allow current conversions/downloads to finish.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                });
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                return;
            }
            listView1.BeginUpdate();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.EndUpdate();
        }

        public void listView1_MouseDoubleClick(object sender, EventArgs e)
        {
            if (!isConverting && !isDownloading)
            {
                DoAsyncConversion();
            }
            else
            {
                MessageBox.Show("Please allow current conversions/downloads to finish.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void StayOnTopCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TopMost = StayOnTopCheckbox.Checked;
            Properties.Settings.Default.Save();

            if (StayOnTopCheckbox.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }

        }

        private void SplashText_Click(object sender, EventArgs e)
        {

        }

        private void DownloadDir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!DownloadDir.Text.Equals(Properties.Settings.Default.DownloadDir))
                {

                    DialogResult answer = MessageBox.Show($"Apply current text as download directory?\n\n{DownloadDir.Text}", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    if (answer == DialogResult.OK)
                    {
                        Properties.Settings.Default.DownloadDir = DownloadDir.Text;
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }

        private void PWBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Properties.Settings.Default.ZipPWS))
            {
                PWBox.Text = "";
            }
            else
            {
                PWBox.Text = Properties.Settings.Default.ZipPWS;
            }
        }

        private void PWBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && PWBox.Text.Length > 0 && !PWBox.Text.Equals("your;commonly;used;zip;passwords"))
            {
                if (PWBox.Text.Length > 0)
                {
                    Properties.Settings.Default.ZipPWS = PWBox.Text;
                    Properties.Settings.Default.Save();
                    PWLIST = PWBox.Text;
                }
                else
                {
                    PWBox.Text = "your;commonly;used;zip;passwords";
                    listView1.Focus();
                }
                if (PWBox.Text == "")
                {
                    if (String.IsNullOrWhiteSpace(Properties.Settings.Default.ZipPWS))
                    {


                        PWBox.Text = "your;commonly;used;zip;passwords";
                    }

                }

            }

        }

        private void PWBox_Leave(object sender, EventArgs e)
        {

            if (PWBox.Text == "")
            {
                if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.ZipPWS))
                {
                    PWBox.Text = Properties.Settings.Default.ZipPWS;
                }
                else
                {
                    PWBox.Text = "your;commonly;used;zip;passwords";
                }

            }
            else if (!PWBox.Text.Equals("your;commonly;used;zip;passwords") && PWBox.Text.Length > 0)
            {

                Properties.Settings.Default.ZipPWS = PWBox.Text;
                Properties.Settings.Default.Save();
                PWLIST = PWBox.Text;
            }
            PWBox.Update();

            listView1.Focus();
        }

        private void AutoExtract_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoExtract = AutoExtract.Checked;
            Properties.Settings.Default.Save();
            if (AutoExtract.Checked)
            {
                PWBox.Enabled = true;
            }
            else
            {
                PWBox.Enabled = false;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!isConverting && !isDownloading)
            {
                DoAsyncConversion();
            }
            else
            {
                MessageBox.Show("Please allow current conversions/downloads to finish.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void PWBox_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Properties.Settings.Default.ZipPWS))
            {
                PWBox.Text = "your;commonly;used;zip;passwords";
            }
        }

        private void DownloadDir_Leave(object sender, EventArgs e)
        {

            if (!DownloadDir.Text.Equals(Properties.Settings.Default.DownloadDir))
            {

                DialogResult answer = MessageBox.Show($"Apply current text as download directory?\n\n{DownloadDir.Text}", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (answer == DialogResult.OK)
                {
                    Properties.Settings.Default.DownloadDir = DownloadDir.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    DownloadDir.Text = Properties.Settings.Default.DownloadDir;
                }
            }
        }

        private void HotKeyBtn_Click(object sender, EventArgs e)
        {

            waitingforkey = true;
            HotKeyBox.Text = "Press desired hotkey...";
        }

        private void AutoDLBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoDL = AutoDLBox.Checked;
            Properties.Settings.Default.Save();
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
