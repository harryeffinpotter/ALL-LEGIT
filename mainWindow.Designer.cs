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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.StayOnTopCheckbox = new System.Windows.Forms.CheckBox();
            this.SplashText = new System.Windows.Forms.Label();
            this.AutoExtract = new System.Windows.Forms.CheckBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.HotKeyBtn = new System.Windows.Forms.Button();
            this.HotKeyBox = new System.Windows.Forms.TextBox();
            this.AutoDLBox = new System.Windows.Forms.CheckBox();
            this.AutoDelete = new System.Windows.Forms.CheckBox();
            this.ALTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Min2Tray = new System.Windows.Forms.CheckBox();
            this.Close2Tray = new System.Windows.Forms.CheckBox();
            this.findDLC = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(12, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(936, 528);
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
            this.startDownloads.Location = new System.Drawing.Point(832, 595);
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
            this.ClearButton.Location = new System.Drawing.Point(15, 595);
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
            this.CopyLinks.Location = new System.Drawing.Point(734, 595);
            this.CopyLinks.Name = "CopyLinks";
            this.CopyLinks.Size = new System.Drawing.Size(92, 25);
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
            this.DownloadDir.Location = new System.Drawing.Point(12, 6);
            this.DownloadDir.Name = "DownloadDir";
            this.DownloadDir.Size = new System.Drawing.Size(236, 22);
            this.DownloadDir.TabIndex = 7;
            this.DownloadDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DownloadDir_KeyPress);
            this.DownloadDir.Leave += new System.EventHandler(this.DownloadDir_Leave);
            // 
            // SetDLDIR
            // 
            this.SetDLDIR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetDLDIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.SetDLDIR.FlatAppearance.BorderSize = 0;
            this.SetDLDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDLDIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SetDLDIR.ForeColor = System.Drawing.Color.Snow;
            this.SetDLDIR.Location = new System.Drawing.Point(12, 33);
            this.SetDLDIR.Name = "SetDLDIR";
            this.SetDLDIR.Size = new System.Drawing.Size(100, 23);
            this.SetDLDIR.TabIndex = 3;
            this.SetDLDIR.Text = "Set Output Dir";
            this.SetDLDIR.UseVisualStyleBackColor = false;
            this.SetDLDIR.Click += new System.EventHandler(this.SetDLDIR_Click);
            // 
            // dlProg
            // 
            this.dlProg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.dlProg.ForeColor = System.Drawing.Color.White;
            this.dlProg.Location = new System.Drawing.Point(85, 595);
            this.dlProg.Name = "dlProg";
            this.dlProg.Size = new System.Drawing.Size(643, 25);
            this.dlProg.TabIndex = 9;
            // 
            // DownloadingText
            // 
            this.DownloadingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.DownloadingText.Location = new System.Drawing.Point(85, 622);
            this.DownloadingText.Name = "DownloadingText";
            this.DownloadingText.Size = new System.Drawing.Size(643, 24);
            this.DownloadingText.TabIndex = 12;
            this.DownloadingText.Text = "...";
            this.DownloadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemDL
            // 
            this.RemDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemDL.AutoSize = true;
            this.RemDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.RemDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.RemDL.Location = new System.Drawing.Point(844, 626);
            this.RemDL.Name = "RemDL";
            this.RemDL.Size = new System.Drawing.Size(104, 20);
            this.RemDL.TabIndex = 6;
            this.RemDL.Text = "Clear Done";
            this.RemDL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemDL.UseVisualStyleBackColor = true;
            this.RemDL.CheckedChanged += new System.EventHandler(this.RemDL_CheckedChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(15, 634);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(64, 25);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.AccessibleDescription = "w";
            this.PasteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasteButton.BackColor = System.Drawing.Color.Teal;
            this.PasteButton.FlatAppearance.BorderSize = 0;
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteButton.ForeColor = System.Drawing.Color.White;
            this.PasteButton.Location = new System.Drawing.Point(823, 6);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(125, 23);
            this.PasteButton.TabIndex = 2;
            this.PasteButton.Text = "Paste links";
            this.PasteButton.UseVisualStyleBackColor = false;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // StayOnTopCheckbox
            // 
            this.StayOnTopCheckbox.AccessibleDescription = "w";
            this.StayOnTopCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StayOnTopCheckbox.AutoSize = true;
            this.StayOnTopCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StayOnTopCheckbox.ForeColor = System.Drawing.Color.White;
            this.StayOnTopCheckbox.Location = new System.Drawing.Point(844, 34);
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
            this.SplashText.Location = new System.Drawing.Point(112, 102);
            this.SplashText.Name = "SplashText";
            this.SplashText.Size = new System.Drawing.Size(737, 466);
            this.SplashText.TabIndex = 4;
            this.SplashText.Text = "ALL LEGIT 1.0\r\n\r\nCTRL+V/Paste Links button to convert Magnets or Links.\r\n\r\nSepera" +
    "te multiples by\r\nsemi-colon, comma, or new line.";
            this.SplashText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SplashText.Click += new System.EventHandler(this.c);
            // 
            // AutoExtract
            // 
            this.AutoExtract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoExtract.AutoSize = true;
            this.AutoExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoExtract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AutoExtract.Location = new System.Drawing.Point(472, 34);
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
            this.PWBox.Location = new System.Drawing.Point(474, 6);
            this.PWBox.Name = "PWBox";
            this.PWBox.Size = new System.Drawing.Size(230, 22);
            this.PWBox.TabIndex = 4;
            this.PWBox.Text = "your;common;zip;passwords";
            this.PWBox.Click += new System.EventHandler(this.PWBox_Enter);
            this.PWBox.Enter += new System.EventHandler(this.PWBox_Enter);
            this.PWBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PWBox_KeyPress);
            this.PWBox.Leave += new System.EventHandler(this.PWBox_Leave);
            // 
            // HotKeyBtn
            // 
            this.HotKeyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HotKeyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.HotKeyBtn.FlatAppearance.BorderSize = 0;
            this.HotKeyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotKeyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.HotKeyBtn.ForeColor = System.Drawing.Color.Snow;
            this.HotKeyBtn.Location = new System.Drawing.Point(254, 33);
            this.HotKeyBtn.Name = "HotKeyBtn";
            this.HotKeyBtn.Size = new System.Drawing.Size(81, 23);
            this.HotKeyBtn.TabIndex = 3;
            this.HotKeyBtn.Text = "Set Hotkey";
            this.HotKeyBtn.UseVisualStyleBackColor = false;
            this.HotKeyBtn.Click += new System.EventHandler(this.HotKeyBtn_Click);
            // 
            // HotKeyBox
            // 
            this.HotKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HotKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.HotKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeyBox.ForeColor = System.Drawing.Color.White;
            this.HotKeyBox.Location = new System.Drawing.Point(254, 6);
            this.HotKeyBox.Name = "HotKeyBox";
            this.HotKeyBox.Size = new System.Drawing.Size(214, 22);
            this.HotKeyBox.TabIndex = 7;
            this.HotKeyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DownloadDir_KeyPress);
            this.HotKeyBox.Leave += new System.EventHandler(this.DownloadDir_Leave);
            // 
            // AutoDLBox
            // 
            this.AutoDLBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoDLBox.AutoSize = true;
            this.AutoDLBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoDLBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AutoDLBox.Location = new System.Drawing.Point(118, 34);
            this.AutoDLBox.Name = "AutoDLBox";
            this.AutoDLBox.Size = new System.Drawing.Size(130, 20);
            this.AutoDLBox.TabIndex = 0;
            this.AutoDLBox.Text = "Auto Download";
            this.AutoDLBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.AutoDLBox.UseVisualStyleBackColor = true;
            this.AutoDLBox.CheckedChanged += new System.EventHandler(this.AutoDLBox_CheckedChanged);
            // 
            // AutoDelete
            // 
            this.AutoDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoDelete.AutoSize = true;
            this.AutoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AutoDelete.Location = new System.Drawing.Point(341, 34);
            this.AutoDelete.Name = "AutoDelete";
            this.AutoDelete.Size = new System.Drawing.Size(126, 20);
            this.AutoDelete.TabIndex = 0;
            this.AutoDelete.Text = "Auto Overwrite";
            this.AutoDelete.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.AutoDelete.UseVisualStyleBackColor = true;
            this.AutoDelete.CheckedChanged += new System.EventHandler(this.AutoDelete_CheckedChanged);
            // 
            // ALTrayIcon
            // 
            this.ALTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ALTrayIcon.BalloonTipText = "All Legit moved to tray.";
            this.ALTrayIcon.BalloonTipTitle = "All Legit";
            this.ALTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ALTrayIcon.Icon")));
            this.ALTrayIcon.Text = "All Legit";
            this.ALTrayIcon.Visible = true;
            this.ALTrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ALTrayIcon_MouseClick);
            this.ALTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ALTrayIcon_MouseDoubleClick_1);
            // 
            // Min2Tray
            // 
            this.Min2Tray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Min2Tray.AutoSize = true;
            this.Min2Tray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min2Tray.ForeColor = System.Drawing.Color.White;
            this.Min2Tray.Location = new System.Drawing.Point(588, 34);
            this.Min2Tray.Name = "Min2Tray";
            this.Min2Tray.Size = new System.Drawing.Size(128, 20);
            this.Min2Tray.TabIndex = 1;
            this.Min2Tray.Text = "Minimize 2 tray";
            this.Min2Tray.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Min2Tray.UseVisualStyleBackColor = true;
            this.Min2Tray.CheckedChanged += new System.EventHandler(this.Min2Tray_CheckedChanged);
            // 
            // Close2Tray
            // 
            this.Close2Tray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close2Tray.AutoSize = true;
            this.Close2Tray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close2Tray.ForeColor = System.Drawing.Color.White;
            this.Close2Tray.Location = new System.Drawing.Point(723, 34);
            this.Close2Tray.Name = "Close2Tray";
            this.Close2Tray.Size = new System.Drawing.Size(114, 20);
            this.Close2Tray.TabIndex = 1;
            this.Close2Tray.Text = "Close 2 Tray";
            this.Close2Tray.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close2Tray.UseVisualStyleBackColor = true;
            this.Close2Tray.CheckedChanged += new System.EventHandler(this.Close2Tray_CheckedChanged);
            // 
            // findDLC
            // 
            this.findDLC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findDLC.BackColor = System.Drawing.Color.Teal;
            this.findDLC.FlatAppearance.BorderSize = 0;
            this.findDLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findDLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findDLC.ForeColor = System.Drawing.Color.White;
            this.findDLC.Location = new System.Drawing.Point(710, 6);
            this.findDLC.Name = "findDLC";
            this.findDLC.Size = new System.Drawing.Size(107, 23);
            this.findDLC.TabIndex = 2;
            this.findDLC.Text = "Parse .DLC\'s";
            this.findDLC.UseVisualStyleBackColor = false;
            this.findDLC.Click += new System.EventHandler(this.findDLC_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(960, 671);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.SplashText);
            this.Controls.Add(this.AutoDLBox);
            this.Controls.Add(this.AutoDelete);
            this.Controls.Add(this.AutoExtract);
            this.Controls.Add(this.Close2Tray);
            this.Controls.Add(this.Min2Tray);
            this.Controls.Add(this.StayOnTopCheckbox);
            this.Controls.Add(this.RemDL);
            this.Controls.Add(this.dlProg);
            this.Controls.Add(this.HotKeyBox);
            this.Controls.Add(this.DownloadDir);
            this.Controls.Add(this.HotKeyBtn);
            this.Controls.Add(this.SetDLDIR);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.findDLC);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CopyLinks);
            this.Controls.Add(this.startDownloads);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DownloadingText);
            this.ForeColor = System.Drawing.Color.NavajoWhite;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(723, 508);
            this.Name = "MainWindow";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Legit: Connecting...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.Button startDownloads;
        private System.Windows.Forms.Button CopyLinks;
        private System.Windows.Forms.TextBox DownloadDir;
        private System.Windows.Forms.Button SetDLDIR;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.CheckBox RemDL;
        private System.Windows.Forms.Label DownloadingText;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.ProgressBar dlProg;
        private System.Windows.Forms.CheckBox StayOnTopCheckbox;
        private System.Windows.Forms.Label SplashText;
        private System.Windows.Forms.CheckBox AutoExtract;
        private System.Windows.Forms.TextBox PWBox;
        private new System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.Button HotKeyBtn;
        private System.Windows.Forms.TextBox HotKeyBox;
        private System.Windows.Forms.CheckBox AutoDLBox;
        private System.Windows.Forms.CheckBox AutoDelete;
        private System.Windows.Forms.NotifyIcon ALTrayIcon;
        private System.Windows.Forms.CheckBox Min2Tray;
        private System.Windows.Forms.CheckBox Close2Tray;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button findDLC;
    }
}

