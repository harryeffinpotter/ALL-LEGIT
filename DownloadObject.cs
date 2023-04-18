using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Graph.Groups.Item.Conversations.Item.Threads.Item.Posts.Item.InReplyTo;
using Microsoft.Graph.Models;
using static ICSharpCode.SharpZipLib.Zip.FastZip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;

namespace ALL_LEGIT
{
    class DownloadObject
    {
        public string fullPath { get; set; }
        public string outputDirectory { get; set; }
        public string fileName { get; set; }
        public string extension { get; set; }
        public string status { get; set; }
        public Uri url { get; set; }
        public int internalID { get; set; }
        public int internalGroupID { get; set; }

        public DownloadObject() { }

        public DownloadObject(string outputDirectory, string fullPath, string fileName, string extension, string status, Uri url, int internalID, int internalGroupID)
        {
            var download = new DownloadObject();
            download.fileName = fileName;
            download.fullPath = fullPath;
            download.extension = extension;
            download.status = status;
            download.url = url;
            download.internalID = internalID;
            download.internalGroupID = internalGroupID; 
            download.outputDirectory = outputDirectory;
            DoDownloadAsync(download);
        }

        private async Task<Task> DoDownloadAsync(DownloadObject currentDownload)
        {
            ProcessDownload(currentDownload);
            return Task.CompletedTask;
        }

        private async DownloadObject ProcessDownload(DownloadObject currentDownload)
        {
            var webClient = new WebClient();
            Stopwatch sw = new Stopwatch(); // The stopwatch which we will be using to calculate the download speed
            if (!Directory.Exists(currentDownload.outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            if (File.Exists(currentDownload.fullPath))
            {
                bool overwrite = false;
                if (!Properties.Settings.Default.AutoOverwrite)
                {
                    DialogResult Overwrite1 = MessageBox.Show(new Form { TopMost = true }, $"Files found, do you want to overwrite all files from this batch of links({MagnetNAME})", "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Overwrite1 == DialogResult.Yes)
                    {
                        overwrite = true;
                    }
                }
                if (Properties.Settings.Default.AutoOverwrite)
                {
                    try
                    {

                        if (File.Exists(currentDownload.fullPath))
                        {
                            currentDownload.fullPath.FileRecycle();
                        }
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            
            }
            //
            //
            //
            //
            //DOWNLOAD AREA
            //
            //
            //
            //
            string DLS = "";
            sw.Start();
            webClient.DownloadProgressChanged += (s, e) =>
            {
            
                
                  Program.form.Invoke(() =>
                    {
                        Program.form.CancelButton.Visible = true;
                    });
                    var name = currentDownload.fileName;
                    const int MaxLength = 35;
                    if (name.Length > MaxLength)
                    {
                        currentDownload.fileName = name.Substring(0, MaxLength) + "..."; //
                    }
          
                
                DLS = String.Format("{0:0.00}", (e.BytesReceived / 1024 / 1024 / sw.Elapsed.TotalSeconds).ToString("0.00"));
                Program.form.Invoke(() =>
                {
                    Program.form.DownloadingText.Text = $"{currentDownload.fileName} - {e.ProgressPercentage}% - {DLS}MB\\s";
                    Program.form.dlProg.Value = e.ProgressPercentage;
                });
            };

            webClient.DownloadFileCompleted += (s, e) =>
            {
                webClient.Dispose();
                if (e.Cancelled)
                {
                    if (File.Exists(currentDownload.fullPath))
                    {
                        currentDownload.fullPath.FileRecycle();
                    }
                    if (Directory.Exists(currentDownload.outputDirectory))
                    {
                        string[] files = Directory.GetFiles(currentDownload.outputDirectory, "*.*", SearchOption.AllDirectories);
                        if (files.Length == 0)
                        {
                            currentDownload.outputDirectory.DirectoryRecycle();
                        }
                    }
                    if (webClient.IsBusy)
                    {
                    }
                    foreach (ListViewItem item in Program.form.listView1.CheckedItems)
                    {
                        if (item.BackColor == Color.MediumSpringGreen)
                        {
                            item.BackColor = Color.FromArgb(0, 50, 42);
                        }
                    }
                }
                Program.form.Invoke(() =>
                {
                    Program.form.CancelButton.Visible = false;
                    Program.form.DownloadingText.Text = $"Download finished...";
                });
                sw.Stop();

                Program.form.Invoke(() =>
                {
                    Program.form.listView1.BeginUpdate();

                    foreach (ListViewItem item in Program.form.listView1.Items)
                    {
                        if (item.SubItems[1].Text.Equals(currentDownload.url))
                        {
                            if (Properties.Settings.Default.RemDL)
                            {
                                Program.form.listView1.Items.Remove(item);
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                    Program.form.listView1.EndUpdate();
                });
                Program.form.Invoke(() =>
                {
                    Program.form.AcceptButto=dlProg.Value = 0;
                });
                webClient.Dispose();
            };
            await webClient.DownloadFileTaskAsync(new Uri(URL), $"{DL}");



        }
    }

}