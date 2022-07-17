using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALL_LEGIT
{
    public partial class WebFormForm : Form
    {
        public static bool DownloadedOnce = false;
        public WebFormForm()
        {
            InitializeComponent();

        }
        public static bool DLCDownloaded = false;
        /// <summary>
        /// The URLMON library contains this function, URLDownloadToFile, which is a way
        /// to download files without user prompts.  The ExecWB( _SAVEAS ) function always
        /// prompts the user, even if _DONTPROMPTUSER parameter is specified, for "internet
        /// security reasons".  This function gets around those reasons.
        /// </summary>
        /// <param name="callerPointer">Pointer to caller object (AX).</param>
        /// <param name="url">String of the URL.</param>
        /// <param name="filePathWithName">String of the destination filename/path.</param>
        /// <param name="reserved">[reserved].</param>
        /// <param name="callBack">A callback function to monitor progress or abort.</param>
        /// <returns>0 for okay.</returns>
        /// source: http://www.pinvoke.net/default.aspx/urlmon/URLDownloadToFile%20.html
        [DllImport("urlmon.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern Int32 URLDownloadToFile(
            [MarshalAs(UnmanagedType.IUnknown)] object callerPointer,
            [MarshalAs(UnmanagedType.LPWStr)] string url,
            [MarshalAs(UnmanagedType.LPWStr)] string filePathWithName,
            Int32 reserved,
            IntPtr callBack);
        public static bool LoadedOnce = false;

        /// <summary>
        /// Download a file from the webpage and save it to the destination without promting the user
        /// </summary>
        /// <param name="url">the url with the file</param>
        /// <param name="destinationFullPathWithName">the absolut full path with the filename as destination</param>
        /// <returns></returns>
        public FileInfo DownloadFile(string url, string destinationFullPathWithName)
        {
            URLDownloadToFile(null, url, destinationFullPathWithName, 0, IntPtr.Zero);
            return new FileInfo(destinationFullPathWithName);
        }
        public static bool mustsignin = false;
        private async void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            DownloadedOnce = false;
            string text = "";
            var links = webBrowser1.Document.GetElementsByTagName("button");
            foreach (HtmlElement link in links)
            {

                if (link.GetAttribute("className").Contains("dlcdownload") && !DownloadedOnce)
                {
                    DownloadedOnce = true;
                    string DLCID = link.OuterHtml;
                    DLCID = Utilities.RemoveEverythingBeforeFirst(DLCID, "(");
                    DLCID = Utilities.RemoveEverythingAfterFirst(DLCID, ")");
                    DLCID = DLCID.Replace("('", "");
                    DLCID = DLCID.Replace("')", "");
                    if (!File.Exists($"{MainWindow.CurrentDLC}.dlc"))
                    {
                        DownloadFile($"https://filecrypt.co/DLC/{DLCID}.dlc", $"_bin\\{MainWindow.CurrentDLC.ToString()}.dlc");
                    }
                    this.Hide();
                    Utilities.DecryptDLC();
                    MainWindow.fileDownloading = "";
                    splashCover.Text = "Please wait...";
                    Program.form.Show();
                }

            }
            if (!webBrowser1.IsDisposed)
            {
                text = webBrowser1.DocumentText;

            }


            if (text.Contains("Security prompt") && !text.Contains("Please confirm that you are no robot"))
            {

            }
            else if (text.Contains("Please confirm that you are no robot"))

            {
                this.Invoke(async () =>
                {
                    var process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            UseShellExecute = true,
                            FileName = MainWindow.FilecryptURL
                        }
                    };
                    if (!LoadedOnce)
                    {
                        process.Start();
                        LoadedOnce = true;
                    }
                    splashCover.Visible = true;
                    webBrowser1.Visible = false;
                    dlcGIF.Visible = true;
                    dlcGIF.Enabled = true;
                    splashCover.Text = "\n\n This captcha (CUTCAPTCHA) cannot be loaded normally, so instead we opened it in your default browser." +
                    "Once you solve it click the green DLC link on the following page.\n\nBE SURE THAT YOU SAVE IT TO YOUR DOWNLOADS FOLDER\n" +
                    "This is where Firefox and Chrome save their downloads by default, so 99.9% of people will not have an issue!\n\n" +
                    "Here is a gif of the entire process:\n\n";
                    this.Text = "All Legit! Complete Captcha/Download DLC FILE!";
                    bool dlcfilefound = false;
                    while (!dlcfilefound)
                    {
                        string[] files = System.IO.Directory.GetFiles(MainWindow.GetDownloadsPath(), "*.dlc", SearchOption.TopDirectoryOnly);
                        if (files.Length > 0) dlcfilefound = true;
                        await Task.Delay(50);
                    }
                    if (dlcfilefound)
                    {
                        this.Hide();
                        Utilities.DecryptDLC();
                        MainWindow.fileDownloading = "";
                        splashCover.Text = "Please wait...";

                    }
                });
            }

            if (text.Contains("Please enter the correct result"))
            {
                splashCover.Visible = false;
                this.Invoke(() =>
                {
                    this.Text = "All Legit: Please complete CAPTCHA!";
                });

            }
            if (!webBrowser1.IsDisposed)
            {


                links = webBrowser1.Document.GetElementsByTagName("button");
                foreach (HtmlElement link in links)
                {

                    if (link.GetAttribute("className").Contains("dlcdownload") && !DownloadedOnce)
                    {

                        DownloadedOnce = true;
                        string DLCID = link.OuterHtml;
                        DLCID = Utilities.RemoveEverythingBeforeFirst(DLCID, "(");
                        DLCID = Utilities.RemoveEverythingAfterFirst(DLCID, ")");
                        DLCID = DLCID.Replace("('", "");
                        DLCID = DLCID.Replace("')", "");
                        if (!File.Exists($"{MainWindow.CurrentDLC}.dlc"))
                        {
                            DownloadFile($"https://filecrypt.co/DLC/{DLCID}.dlc", $"_bin\\{MainWindow.CurrentDLC.ToString()}.dlc");
                        }
                        this.Hide();
                        Utilities.DecryptDLC();
                        MainWindow.fileDownloading = "";
                        splashCover.Text = "Please wait...";
                    }
                    if (MainWindow.isloggingin)
                    {
                        if (!webBrowser1.IsDisposed)
                        {
                            if (link.InnerHtml.Contains("Confirm this code"))
                            {
                                link.InvokeMember("click");
                            }
                        }
                    }


                }
            }
            if (!webBrowser1.IsDisposed)
            {

                if (webBrowser1.DocumentText.Contains("The code you have enter"))
                {
                    this.Hide();

                }
                if (text.Contains("Please login to use your PIN code") && !mustsignin)
                {
                    MessageBox.Show(new Form { TopMost = true }, "Please sign in your AllDebrid account!");
                    mustsignin = true;
                }
                if (text.Contains("Your device have been activated"))
                {
                    this.Hide();
                }

            }

        }

        private async void WebFormForm_Load(object sender, EventArgs e)
        {
            while (MainWindow.isDownloading)
            {
                this.Hide();
                await Task.Delay(100);
                this.Show();
            }

            webBrowser1.Visible = true;
            splashCover.Visible = false;
            var appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
                  appName, 11000, Microsoft.Win32.RegistryValueKind.DWord);
            splashCover.Visible = false;

            webBrowser1.Navigate(MainWindow.FilecryptURL);
        }
        public static bool clicked = false;


        private void WebFormForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!webBrowser1.IsDisposed)
            {
                dlcGIF.Visible = false;
                dlcGIF.Enabled = false;
                webBrowser1.Stop();
                splashCover.Text = "Please wait...";
                this.Hide();
                Program.form.BringToFront();
                LoadedOnce = false;
                Program.form.TopMost = true;
                Program.form.TopMost = true;
                Program.form.BringToFront();

            }

        }
    }
}

