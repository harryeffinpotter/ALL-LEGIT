using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
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
                    webBrowser1.Stop();
                    this.Close();

                }
                if (link.InnerHtml.Contains("Confirm this code"))
                {

                   link.InvokeMember("click");
                }
                if (webBrowser1.DocumentText.Contains("premium links module"))
                {
                    webBrowser1.Navigate(MainWindow.FilecryptURL);
                }

                if (webBrowser1.DocumentText.Contains("Your device have been activated"))
                {
                    webBrowser1.Dispose();
                    this.Close();
                }
                if (webBrowser1.DocumentText.Contains("The code you have enter"))
                {
                    this.Close();

                }
                if (webBrowser1.DocumentText.Contains("Security prompt"))
                {
                    this.Invoke(() =>
                    {
                        this.Text = "All Legit: Please complete CAPTCHA!";
                    });
                }
                if (!mustsignin && webBrowser1.DocumentText.ToString().Contains("Please login to use your PIN code"))
                {
                    MessageBox.Show("Please sign in your AllDebrid account!");
                    mustsignin = true;
                }
            }
        }

        private void WebFormForm_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(MainWindow.FilecryptURL);
        }
        public static bool clicked = false;

        private async void closeBrowser_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                closeBrowser.Text = "SUBMIT DOWNLOADED DLC FILE.";
            }
            if (clicked)
            {
                clicked = false;
                webBrowser1.Stop();
                Utilities.DecryptDLC();
                closeBrowser.Text = "CAPTCHA DIDN'T LOAD PROPERLY? USE THIS WORKAROUND!";
                this.Close();
                return;
            }
            bool GotDLC = false;
            clicked = true;

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = MainWindow.FilecryptURL
                }
            };
            process.Start();

            while (!GotDLC)
            {

                webBrowser1.Document.GetElementsByTagName("button.dlcdownload");
                string[] files = System.IO.Directory.GetFiles(Properties.Settings.Default.DownloadDir, "*.dlc", SearchOption.TopDirectoryOnly);
                if (files.Length > 0) GotDLC = true;
                await Task.Delay(100);
            }
            if (GotDLC)
            {
                webBrowser1.Stop();
                Utilities.DecryptDLC();
                this.Close();
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}

