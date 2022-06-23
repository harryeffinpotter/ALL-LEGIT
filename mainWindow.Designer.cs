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
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDownloads = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CopyLinks = new System.Windows.Forms.Button();
            this.DownloadDir = new System.Windows.Forms.TextBox();
            this.SetDLDIR = new System.Windows.Forms.Button();
            this.dlProg = new System.Windows.Forms.ProgressBar();
            this.DownloadingText = new System.Windows.Forms.Label();
            this.RemDL = new System.Windows.Forms.CheckBox();
            this.RemCP = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // connectedLbl
            // 
            this.connectedLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.connectedLbl.ForeColor = System.Drawing.Color.Snow;
            this.connectedLbl.Location = new System.Drawing.Point(574, 18);
            this.connectedLbl.Name = "connectedLbl";
            this.connectedLbl.Size = new System.Drawing.Size(121, 21);
            this.connectedLbl.TabIndex = 0;
            this.connectedLbl.Text = "Checking Apikey...";
            this.connectedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(80)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.URL,
            this.Group});
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 45);
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
            this.URL.Width = 329;
            // 
            // Group
            // 
            this.Group.Text = "Group";
            this.Group.Width = 103;
            // 
            // startDownloads
            // 
            this.startDownloads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.startDownloads.FlatAppearance.BorderSize = 0;
            this.startDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDownloads.ForeColor = System.Drawing.Color.White;
            this.startDownloads.Location = new System.Drawing.Point(582, 404);
            this.startDownloads.Name = "startDownloads";
            this.startDownloads.Size = new System.Drawing.Size(113, 29);
            this.startDownloads.TabIndex = 2;
            this.startDownloads.Text = "Start Downloads";
            this.startDownloads.UseVisualStyleBackColor = false;
            this.startDownloads.Click += new System.EventHandler(this.startDownloads_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(12, 404);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(65, 29);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear all";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CopyLinks
            // 
            this.CopyLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.CopyLinks.FlatAppearance.BorderSize = 0;
            this.CopyLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyLinks.ForeColor = System.Drawing.Color.White;
            this.CopyLinks.Location = new System.Drawing.Point(492, 404);
            this.CopyLinks.Name = "CopyLinks";
            this.CopyLinks.Size = new System.Drawing.Size(85, 29);
            this.CopyLinks.TabIndex = 2;
            this.CopyLinks.Text = "Copy links";
            this.CopyLinks.UseVisualStyleBackColor = false;
            this.CopyLinks.Click += new System.EventHandler(this.CopyLinks_Click);
            // 
            // DownloadDir
            // 
            this.DownloadDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(60)))));
            this.DownloadDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.DownloadDir.Location = new System.Drawing.Point(120, 12);
            this.DownloadDir.Name = "DownloadDir";
            this.DownloadDir.Size = new System.Drawing.Size(448, 20);
            this.DownloadDir.TabIndex = 3;
            // 
            // SetDLDIR
            // 
            this.SetDLDIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.SetDLDIR.FlatAppearance.BorderSize = 0;
            this.SetDLDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDLDIR.ForeColor = System.Drawing.Color.Snow;
            this.SetDLDIR.Location = new System.Drawing.Point(12, 8);
            this.SetDLDIR.Name = "SetDLDIR";
            this.SetDLDIR.Size = new System.Drawing.Size(102, 29);
            this.SetDLDIR.TabIndex = 2;
            this.SetDLDIR.Text = "Set Folder";
            this.SetDLDIR.UseVisualStyleBackColor = false;
            this.SetDLDIR.Click += new System.EventHandler(this.SetDLDIR_Click);
            // 
            // dlProg
            // 
            this.dlProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.dlProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.dlProg.Location = new System.Drawing.Point(83, 406);
            this.dlProg.Name = "dlProg";
            this.dlProg.Size = new System.Drawing.Size(403, 24);
            this.dlProg.TabIndex = 4;
            // 
            // DownloadingText
            // 
            this.DownloadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.DownloadingText.Location = new System.Drawing.Point(83, 436);
            this.DownloadingText.Name = "DownloadingText";
            this.DownloadingText.Size = new System.Drawing.Size(403, 21);
            this.DownloadingText.TabIndex = 0;
            this.DownloadingText.Text = "...";
            this.DownloadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemDL
            // 
            this.RemDL.AutoSize = true;
            this.RemDL.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.RemDL.Location = new System.Drawing.Point(582, 437);
            this.RemDL.Name = "RemDL";
            this.RemDL.Size = new System.Drawing.Size(113, 17);
            this.RemDL.TabIndex = 5;
            this.RemDL.Text = "Clear Downloaded";
            this.RemDL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemDL.UseVisualStyleBackColor = true;
            this.RemDL.CheckedChanged += new System.EventHandler(this.RemDL_CheckedChanged);
            // 
            // RemCP
            // 
            this.RemCP.AutoSize = true;
            this.RemCP.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.RemCP.Location = new System.Drawing.Point(491, 436);
            this.RemCP.Name = "RemCP";
            this.RemCP.Size = new System.Drawing.Size(86, 17);
            this.RemCP.TabIndex = 5;
            this.RemCP.Text = "Clear Copied";
            this.RemCP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemCP.UseVisualStyleBackColor = true;
            this.RemCP.CheckedChanged += new System.EventHandler(this.RemCP_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(707, 463);
            this.Controls.Add(this.RemCP);
            this.Controls.Add(this.RemDL);
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
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALL LEGIT";
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
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.CheckBox RemDL;
        private System.Windows.Forms.CheckBox RemCP;
    }
}

