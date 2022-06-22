namespace ALL_LEGIT
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectedLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDownloads = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CopyLinks = new System.Windows.Forms.Button();
            this.DownloadDir = new System.Windows.Forms.TextBox();
            this.SetDLDIR = new System.Windows.Forms.Button();
            this.dlProg = new System.Windows.Forms.ProgressBar();
            this.DownloadingText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectedLbl
            // 
            this.connectedLbl.ForeColor = System.Drawing.Color.Snow;
            this.connectedLbl.Location = new System.Drawing.Point(590, 6);
            this.connectedLbl.Name = "connectedLbl";
            this.connectedLbl.Size = new System.Drawing.Size(105, 21);
            this.connectedLbl.TabIndex = 0;
            this.connectedLbl.Text = "Checking Apikey...";
            this.connectedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.URL});
            this.listView1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(683, 350);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 183;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 485;
            // 
            // startDownloads
            // 
            this.startDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDownloads.ForeColor = System.Drawing.Color.LightGreen;
            this.startDownloads.Location = new System.Drawing.Point(593, 389);
            this.startDownloads.Name = "startDownloads";
            this.startDownloads.Size = new System.Drawing.Size(102, 31);
            this.startDownloads.TabIndex = 2;
            this.startDownloads.Text = "Start Downloads";
            this.startDownloads.UseVisualStyleBackColor = true;
            this.startDownloads.Click += new System.EventHandler(this.startDownloads_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.Color.LightGreen;
            this.ClearButton.Location = new System.Drawing.Point(12, 388);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(51, 31);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CopyLinks
            // 
            this.CopyLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyLinks.ForeColor = System.Drawing.Color.LightGreen;
            this.CopyLinks.Location = new System.Drawing.Point(69, 388);
            this.CopyLinks.Name = "CopyLinks";
            this.CopyLinks.Size = new System.Drawing.Size(103, 31);
            this.CopyLinks.TabIndex = 2;
            this.CopyLinks.Text = "Copy Debrid Links";
            this.CopyLinks.UseVisualStyleBackColor = true;
            this.CopyLinks.Click += new System.EventHandler(this.CopyLinks_Click);
            // 
            // DownloadDir
            // 
            this.DownloadDir.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DownloadDir.ForeColor = System.Drawing.Color.White;
            this.DownloadDir.Location = new System.Drawing.Point(120, 6);
            this.DownloadDir.Name = "DownloadDir";
            this.DownloadDir.Size = new System.Drawing.Size(448, 20);
            this.DownloadDir.TabIndex = 3;
            // 
            // SetDLDIR
            // 
            this.SetDLDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDLDIR.ForeColor = System.Drawing.Color.LightGreen;
            this.SetDLDIR.Location = new System.Drawing.Point(12, 5);
            this.SetDLDIR.Name = "SetDLDIR";
            this.SetDLDIR.Size = new System.Drawing.Size(102, 23);
            this.SetDLDIR.TabIndex = 2;
            this.SetDLDIR.Text = "Set Folder";
            this.SetDLDIR.UseVisualStyleBackColor = true;
            this.SetDLDIR.Click += new System.EventHandler(this.SetDLDIR_Click);
            // 
            // dlProg
            // 
            this.dlProg.BackColor = System.Drawing.Color.DimGray;
            this.dlProg.ForeColor = System.Drawing.Color.PaleGreen;
            this.dlProg.Location = new System.Drawing.Point(178, 389);
            this.dlProg.Name = "dlProg";
            this.dlProg.Size = new System.Drawing.Size(409, 30);
            this.dlProg.TabIndex = 4;
            // 
            // DownloadingText
            // 
            this.DownloadingText.ForeColor = System.Drawing.Color.Snow;
            this.DownloadingText.Location = new System.Drawing.Point(218, 422);
            this.DownloadingText.Name = "DownloadingText";
            this.DownloadingText.Size = new System.Drawing.Size(369, 21);
            this.DownloadingText.TabIndex = 0;
            this.DownloadingText.Text = "...";
            this.DownloadingText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(707, 524);
            this.Controls.Add(this.dlProg);
            this.Controls.Add(this.DownloadDir);
            this.Controls.Add(this.SetDLDIR);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CopyLinks);
            this.Controls.Add(this.startDownloads);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DownloadingText);
            this.Controls.Add(this.connectedLbl);
            this.ForeColor = System.Drawing.Color.NavajoWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Opacity = 0.55D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALL LEGIT";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label connectedLbl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.Button startDownloads;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CopyLinks;
        private System.Windows.Forms.TextBox DownloadDir;
        private System.Windows.Forms.Button SetDLDIR;
        public System.Windows.Forms.Label DownloadingText;
        private System.Windows.Forms.ProgressBar dlProg;
    }
}

