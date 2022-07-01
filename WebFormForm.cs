using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALL_LEGIT
{
    public partial class WebFormForm : Form
    {
        public WebFormForm()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(MainWindow.FilecryptURL);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var links = webBrowser1.Document.GetElementsByTagName("button");

            foreach (HtmlElement link in links)
            {

                if (link.GetAttribute("className").Contains("dlcdownload") && !MainWindow.DownloadedOnce)
                {
                    MainWindow.DownloadedOnce = true;
                    string DLCID = link.OuterHtml;
                    DLCID = Utilities.RemoveEverythingBeforeFirst(DLCID, "(");
                    DLCID = Utilities.RemoveEverythingAfterFirst(DLCID, ")");
                    DLCID = DLCID.Replace("('", "");
                    DLCID = DLCID.Replace("')", "");
                    if (!File.Exists($"{MainWindow.CurrentDLC.ToString()}.dlc"))
                    {
                        MainWindow.DownloadFile($"https://filecrypt.co/DLC/{DLCID}.dlc", $"_bin\\{MainWindow.CurrentDLC.ToString()}.dlc");
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

        private void startDownloads_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
            this.Close();

        }
    }
}
