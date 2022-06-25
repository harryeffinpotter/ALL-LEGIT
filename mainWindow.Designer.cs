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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.connectedLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDownloads = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CopyLinks = new System.Windows.Forms.Button();
            this.DownloadDir = new System.Windows.Forms.TextBox();
            this.SetDLDIR = new System.Windows.Forms.Button();
            this.dlProg = new System.Windows.Forms.ProgressBar();
            this.DownloadingText = new System.Windows.Forms.Label();
            this.RemDL = new System.Windows.Forms.CheckBox();
            this.RemCP = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.StayOnTopCheckbox = new System.Windows.Forms.CheckBox();
            this.SplashText = new System.Windows.Forms.Label();
            this.AutoExtract = new System.Windows.Forms.CheckBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectedLbl
            // 
            this.connectedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectedLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.connectedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedLbl.ForeColor = System.Drawing.Color.Snow;
            this.connectedLbl.Location = new System.Drawing.Point(574, 12);
            this.connectedLbl.Name = "connectedLbl";
            this.connectedLbl.Size = new System.Drawing.Size(121, 21);
            this.connectedLbl.TabIndex = 0;
            this.connectedLbl.Text = "Connecting...";
            this.connectedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.URL,
            this.Group,
            this.Size});
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.Location = new System.Drawing.Point(12, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(683, 386);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 301;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 165;
            // 
            // Group
            // 
            this.Group.Text = "Group";
            this.Group.Width = 120;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 97;
            // 
            // startDownloads
            // 
            this.startDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startDownloads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.startDownloads.FlatAppearance.BorderSize = 0;
            this.startDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDownloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.startDownloads.ForeColor = System.Drawing.Color.White;
            this.startDownloads.Location = new System.Drawing.Point(579, 468);
            this.startDownloads.Name = "startDownloads";
            this.startDownloads.Size = new System.Drawing.Size(116, 25);
            this.startDownloads.TabIndex = 5;
            this.startDownloads.Text = "Start Downloads";
            this.startDownloads.UseVisualStyleBackColor = false;
            this.startDownloads.Click += new System.EventHandler(this.startDownloads_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(12, 468);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(64, 25);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear all";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CopyLinks
            // 
            this.CopyLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.CopyLinks.FlatAppearance.BorderSize = 0;
            this.CopyLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CopyLinks.ForeColor = System.Drawing.Color.White;
            this.CopyLinks.Location = new System.Drawing.Point(493, 468);
            this.CopyLinks.Name = "CopyLinks";
            this.CopyLinks.Size = new System.Drawing.Size(83, 25);
            this.CopyLinks.TabIndex = 10;
            this.CopyLinks.Text = "Copy links";
            this.CopyLinks.UseVisualStyleBackColor = false;
            this.CopyLinks.Click += new System.EventHandler(this.CopyLinks_Click);
            // 
            // DownloadDir
            // 
            this.DownloadDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.DownloadDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadDir.ForeColor = System.Drawing.Color.White;
            this.DownloadDir.Location = new System.Drawing.Point(126, 45);
            this.DownloadDir.Name = "DownloadDir";
            this.DownloadDir.Size = new System.Drawing.Size(574, 22);
            this.DownloadDir.TabIndex = 7;
            this.DownloadDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DownloadDir_KeyPress);
            this.DownloadDir.Leave += new System.EventHandler(this.DownloadDir_Leave);
            // 
            // SetDLDIR
            // 
            this.SetDLDIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.SetDLDIR.FlatAppearance.BorderSize = 0;
            this.SetDLDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDLDIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SetDLDIR.ForeColor = System.Drawing.Color.Snow;
            this.SetDLDIR.Location = new System.Drawing.Point(12, 44);
            this.SetDLDIR.Name = "SetDLDIR";
            this.SetDLDIR.Size = new System.Drawing.Size(108, 25);
            this.SetDLDIR.TabIndex = 3;
            this.SetDLDIR.Text = "Set DL Folder";
            this.SetDLDIR.UseVisualStyleBackColor = false;
            this.SetDLDIR.Click += new System.EventHandler(this.SetDLDIR_Click);
            // 
            // dlProg
            // 
            this.dlProg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.dlProg.ForeColor = System.Drawing.Color.White;
            this.dlProg.Location = new System.Drawing.Point(83, 468);
            this.dlProg.Name = "dlProg";
            this.dlProg.Size = new System.Drawing.Size(403, 24);
            this.dlProg.TabIndex = 9;
            // 
            // DownloadingText
            // 
            this.DownloadingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.DownloadingText.Location = new System.Drawing.Point(83, 495);
            this.DownloadingText.Name = "DownloadingText";
            this.DownloadingText.Size = new System.Drawing.Size(403, 24);
            this.DownloadingText.TabIndex = 12;
            this.DownloadingText.Text = "...";
            this.DownloadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemDL
            // 
            this.RemDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemDL.AutoSize = true;
            this.RemDL.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.RemDL.Location = new System.Drawing.Point(582, 498);
            this.RemDL.Name = "RemDL";
            this.RemDL.Size = new System.Drawing.Size(113, 17);
            this.RemDL.TabIndex = 6;
            this.RemDL.Text = "Clear Downloaded";
            this.RemDL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemDL.UseVisualStyleBackColor = true;
            this.RemDL.CheckedChanged += new System.EventHandler(this.RemDL_CheckedChanged);
            // 
            // RemCP
            // 
            this.RemCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemCP.AutoSize = true;
            this.RemCP.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.RemCP.Location = new System.Drawing.Point(490, 498);
            this.RemCP.Name = "RemCP";
            this.RemCP.Size = new System.Drawing.Size(86, 17);
            this.RemCP.TabIndex = 12;
            this.RemCP.Text = "Clear Copied";
            this.RemCP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemCP.UseVisualStyleBackColor = true;
            this.RemCP.CheckedChanged += new System.EventHandler(this.RemCP_CheckedChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(12, 494);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(64, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasteButton.BackColor = System.Drawing.Color.Teal;
            this.PasteButton.FlatAppearance.BorderSize = 0;
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteButton.ForeColor = System.Drawing.Color.White;
            this.PasteButton.Location = new System.Drawing.Point(505, 10);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(96, 25);
            this.PasteButton.TabIndex = 2;
            this.PasteButton.Text = "Paste links";
            this.PasteButton.UseVisualStyleBackColor = false;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // StayOnTopCheckbox
            // 
            this.StayOnTopCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StayOnTopCheckbox.AutoSize = true;
            this.StayOnTopCheckbox.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.StayOnTopCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StayOnTopCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.StayOnTopCheckbox.Location = new System.Drawing.Point(392, 14);
            this.StayOnTopCheckbox.Name = "StayOnTopCheckbox";
            this.StayOnTopCheckbox.Size = new System.Drawing.Size(104, 20);
            this.StayOnTopCheckbox.TabIndex = 1;
            this.StayOnTopCheckbox.Text = "Stay on top";
            this.StayOnTopCheckbox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.StayOnTopCheckbox.UseVisualStyleBackColor = true;
            this.StayOnTopCheckbox.CheckedChanged += new System.EventHandler(this.StayOnTopCheckbox_CheckedChanged);
            // 
            // SplashText
            // 
            this.SplashText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplashText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.SplashText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashText.ForeColor = System.Drawing.Color.White;
            this.SplashText.Location = new System.Drawing.Point(12, 106);
            this.SplashText.Name = "SplashText";
            this.SplashText.Size = new System.Drawing.Size(683, 355);
            this.SplashText.TabIndex = 4;
            this.SplashText.Text = "ALL LEGIT 1.0\r\n\r\nCTRL+V/Paste Links button to convert Magnets or Links.\r\n\r\nSepera" +
    "te multiples by\r\nsemi-colon, comma, or new line.";
            this.SplashText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SplashText.Click += new System.EventHandler(this.SplashText_Click);
            // 
            // AutoExtract
            // 
            this.AutoExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoExtract.AutoSize = true;
            this.AutoExtract.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.AutoExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoExtract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.AutoExtract.Location = new System.Drawing.Point(12, 13);
            this.AutoExtract.Name = "AutoExtract";
            this.AutoExtract.Size = new System.Drawing.Size(108, 20);
            this.AutoExtract.TabIndex = 0;
            this.AutoExtract.Text = "Auto Extract";
            this.AutoExtract.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.AutoExtract.UseVisualStyleBackColor = true;
            this.AutoExtract.CheckedChanged += new System.EventHandler(this.AutoExtract_CheckedChanged);
            // 
            // PWBox
            // 
            this.PWBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PWBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.PWBox.Enabled = false;
            this.PWBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWBox.ForeColor = System.Drawing.Color.White;
            this.PWBox.Location = new System.Drawing.Point(126, 12);
            this.PWBox.Name = "PWBox";
            this.PWBox.Size = new System.Drawing.Size(260, 22);
            this.PWBox.TabIndex = 4;
            this.PWBox.Text = "your;commonly;used;zip;passwords";
            this.PWBox.Click += new System.EventHandler(this.PWBox_Click);
            this.PWBox.Enter += new System.EventHandler(this.PWBox_Enter);
            this.PWBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PWBox_KeyPress);
            this.PWBox.Leave += new System.EventHandler(this.PWBox_Leave);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(707, 523);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.SplashText);
            this.Controls.Add(this.AutoExtract);
            this.Controls.Add(this.StayOnTopCheckbox);
            this.Controls.Add(this.RemCP);
            this.Controls.Add(this.RemDL);
            this.Controls.Add(this.dlProg);
            this.Controls.Add(this.DownloadDir);
            this.Controls.Add(this.SetDLDIR);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CopyLinks);
            this.Controls.Add(this.startDownloads);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DownloadingText);
            this.Controls.Add(this.connectedLbl);
            this.ForeColor = System.Drawing.Color.NavajoWhite;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(723, 508);
            this.Name = "MainWindow";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALL LEGIT";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
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
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.CheckBox RemDL;
        private System.Windows.Forms.CheckBox RemCP;
        private System.Windows.Forms.Label DownloadingText;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.ProgressBar dlProg;
        private System.Windows.Forms.CheckBox StayOnTopCheckbox;
        private System.Windows.Forms.Label SplashText;
        private System.Windows.Forms.CheckBox AutoExtract;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.ColumnHeader Size;
    }
}

