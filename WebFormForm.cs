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
                if (webBrowser1.DocumentText.Contains("Security prompt"))
                {
                    this.Invoke(() =>
                    {
                        this.Text = "All Legit: Please complete CAPTCHA!";
                    });
                }
            }
        }



        private void WebFormForm_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(MainWindow.FilecryptURL);
        }

        private void closeBrowser_Click(object sender, EventArgs e)
        {
          
            webBrowser1.Stop();
            closeBrowser.Text = "DONE!! -- DO NOT CLICK THIS UNTIL AFTER YOU SOLVE CAPTCHA AND DOWNLOAD DLC FILE!";
            MessageBox.Show("Once you press OK  to this prompt your default browser will show up contianing the captcha that All Legit couldn't load (probably the picture one).\n\n" +
                "You must do these three steps:\n\n1.Solve the captcha.\n2.Click the green DLC button on the links page, save it to downloads.\n.3.CLose the browser out.\n\nThast's it!." +
                "", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            this.Hide();
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = MainWindow.FilecryptURL
                }
            };
            process.Start();
            process.WaitForExit();
            MessageBox.Show("This is step one, move this message to the side so you can solve the captcha  in your browser now, wait for the timer first if it asks. Once you submit the captcha and the next page loads hit OK.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            MessageBox.Show("Final step! Now all you have to do is click the RIGHT HALF OF THE GREEN BUTTON, it says DLC on it and has a little down arrow, click that and allow your browser to save it to the DEFAULT DOWNLOADS FOLDER.\n\nAnd that's it! As soon as the DLC file downloads successfully (its only a few KB, you can close your browser!", "DLC file downloaded?", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            Utilities.DecryptDLC();
            this.Close();

        }
    }

}

