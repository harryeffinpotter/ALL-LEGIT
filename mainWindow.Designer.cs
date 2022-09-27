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
            try
            {

                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);

            }
            catch { }
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
            this.DownloadDir = new System.Windows.Forms.TextBox();
            this.SetDLDIR = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.StayOnTopCheckbox = new System.Windows.Forms.CheckBox();
            this.HotKeyBox = new System.Windows.Forms.TextBox();
            this.ALTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HotKeyBtn = new System.Windows.Forms.Button();
            this.DownloadingText = new System.Windows.Forms.Label();
            this.CopyLinks = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.dlProg = new System.Windows.Forms.ProgressBar();
            this.UncheckAll = new System.Windows.Forms.PictureBox();
            this.CheckAll = new System.Windows.Forms.PictureBox();
            this.OpenDirBox = new System.Windows.Forms.CheckBox();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.splashPanel = new System.Windows.Forms.Panel();
            this.tipsText = new System.Windows.Forms.Label();
            this.tipsHeader = new System.Windows.Forms.Label();
            this.SplashText = new System.Windows.Forms.Label();
            this.changeLog = new System.Windows.Forms.Label();
            this.settingsP = new System.Windows.Forms.Panel();
            this.autoUpdateBox = new System.Windows.Forms.CheckBox();
            this.removeURLs = new System.Windows.Forms.CheckBox();
            this.disableNotiesBox = new System.Windows.Forms.CheckBox();
            this.autoDelZips = new System.Windows.Forms.CheckBox();
            this.extractNested = new System.Windows.Forms.CheckBox();
            this.updateNow = new System.Windows.Forms.Button();
            this.AutoExtract = new System.Windows.Forms.CheckBox();
            this.zipPWLabel = new System.Windows.Forms.Label();
            this.Close2Tray = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.AutoOverwrite = new System.Windows.Forms.CheckBox();
            this.AutoDLBox = new System.Windows.Forms.CheckBox();
            this.RemDL = new System.Windows.Forms.CheckBox();
            this.selectTorrent = new System.Windows.Forms.Button();
            this.startDownloads = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UncheckAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckAll)).BeginInit();
            this.splashPanel.SuspendLayout();
            this.settingsP.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownloadDir
            // 
            this.DownloadDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.DownloadDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadDir.ForeColor = System.Drawing.Color.White;
            this.DownloadDir.Location = new System.Drawing.Point(17, 7);
            this.DownloadDir.Margin = new System.Windows.Forms.Padding(4);
            this.DownloadDir.Name = "DownloadDir";
            this.DownloadDir.Size = new System.Drawing.Size(447, 26);
            this.DownloadDir.TabIndex = 5;
            this.DownloadDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DownloadDir_KeyPress);
            this.DownloadDir.Leave += new System.EventHandler(this.DownloadDir_Leave);
            this.DownloadDir.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // SetDLDIR
            // 
            this.SetDLDIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetDLDIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.SetDLDIR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SetDLDIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.SetDLDIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.SetDLDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDLDIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDLDIR.ForeColor = System.Drawing.SystemColors.Control;
            this.SetDLDIR.Location = new System.Drawing.Point(317, 38);
            this.SetDLDIR.Margin = new System.Windows.Forms.Padding(4);
            this.SetDLDIR.Name = "SetDLDIR";
            this.SetDLDIR.Size = new System.Drawing.Size(146, 30);
            this.SetDLDIR.TabIndex = 6;
            this.SetDLDIR.Text = "Set Output Dir";
            this.SetDLDIR.UseVisualStyleBackColor = false;
            this.SetDLDIR.Click += new System.EventHandler(this.SetDLDIR_Click);
            this.SetDLDIR.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // PasteButton
            // 
            this.PasteButton.AccessibleDescription = "w";
            this.PasteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.PasteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PasteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.PasteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PasteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PasteButton.Location = new System.Drawing.Point(998, 757);
            this.PasteButton.Margin = new System.Windows.Forms.Padding(4);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(81, 31);
            this.PasteButton.TabIndex = 3;
            this.PasteButton.Text = "Paste links";
            this.PasteButton.UseVisualStyleBackColor = false;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // StayOnTopCheckbox
            // 
            this.StayOnTopCheckbox.AccessibleDescription = "w";
            this.StayOnTopCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StayOnTopCheckbox.AutoSize = true;
            this.StayOnTopCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.StayOnTopCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StayOnTopCheckbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.StayOnTopCheckbox.ForeColor = System.Drawing.Color.White;
            this.StayOnTopCheckbox.Location = new System.Drawing.Point(700, 7);
            this.StayOnTopCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.StayOnTopCheckbox.Name = "StayOnTopCheckbox";
            this.StayOnTopCheckbox.Size = new System.Drawing.Size(307, 27);
            this.StayOnTopCheckbox.TabIndex = 8;
            this.StayOnTopCheckbox.Text = "Keep on top of other apps";
            this.StayOnTopCheckbox.UseVisualStyleBackColor = false;
            this.StayOnTopCheckbox.CheckedChanged += new System.EventHandler(this.StayOnTopCheckbox_CheckedChanged_1);
            this.StayOnTopCheckbox.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // HotKeyBox
            // 
            this.HotKeyBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.HotKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HotKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.HotKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeyBox.ForeColor = System.Drawing.Color.White;
            this.HotKeyBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.HotKeyBox.Location = new System.Drawing.Point(474, 7);
            this.HotKeyBox.Margin = new System.Windows.Forms.Padding(4);
            this.HotKeyBox.Name = "HotKeyBox";
            this.HotKeyBox.ReadOnly = true;
            this.HotKeyBox.Size = new System.Drawing.Size(218, 26);
            this.HotKeyBox.TabIndex = 7;
            this.HotKeyBox.TabStop = false;
            this.HotKeyBox.Click += new System.EventHandler(this.HotKeyBtn_Click);
            this.HotKeyBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotKeyBtn_Click);
            this.HotKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyBox_KeyDown);
            this.HotKeyBox.Leave += new System.EventHandler(this.HotKeyBox_Leave);
            this.HotKeyBox.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // ALTrayIcon
            // 
            this.ALTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ALTrayIcon.Icon")));
            this.ALTrayIcon.Tag = "";
            this.ALTrayIcon.Text = "All Legit";
            this.ALTrayIcon.Visible = true;
            this.ALTrayIcon.BalloonTipClicked += new System.EventHandler(this.ALTrayIcon_BalloonTipClicked);
            this.ALTrayIcon.Click += new System.EventHandler(this.ALTrayIcon_Click);
            this.ALTrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ALTrayIcon_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1031, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // HotKeyBtn
            // 
            this.HotKeyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HotKeyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.HotKeyBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HotKeyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.HotKeyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.HotKeyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotKeyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeyBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.HotKeyBtn.Location = new System.Drawing.Point(546, 39);
            this.HotKeyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HotKeyBtn.Name = "HotKeyBtn";
            this.HotKeyBtn.Size = new System.Drawing.Size(146, 30);
            this.HotKeyBtn.TabIndex = 7;
            this.HotKeyBtn.Text = "Set Shortcut";
            this.HotKeyBtn.UseVisualStyleBackColor = false;
            this.HotKeyBtn.Click += new System.EventHandler(this.HotKeyBtn_Click);
            // 
            // DownloadingText
            // 
            this.DownloadingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadingText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.DownloadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.DownloadingText.Location = new System.Drawing.Point(237, 794);
            this.DownloadingText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DownloadingText.Name = "DownloadingText";
            this.DownloadingText.Size = new System.Drawing.Size(624, 30);
            this.DownloadingText.TabIndex = 12;
            this.DownloadingText.Text = "...";
            this.DownloadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyLinks
            // 
            this.CopyLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.CopyLinks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CopyLinks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.CopyLinks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.CopyLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CopyLinks.ForeColor = System.Drawing.SystemColors.Control;
            this.CopyLinks.Location = new System.Drawing.Point(870, 757);
            this.CopyLinks.Margin = new System.Windows.Forms.Padding(4);
            this.CopyLinks.Name = "CopyLinks";
            this.CopyLinks.Size = new System.Drawing.Size(124, 31);
            this.CopyLinks.TabIndex = 2;
            this.CopyLinks.Text = "Copy Links";
            this.CopyLinks.UseVisualStyleBackColor = false;
            this.CopyLinks.Click += new System.EventHandler(this.CopyLinks_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearButton.Location = new System.Drawing.Point(55, 757);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(173, 31);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Delete Selected";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // dlProg
            // 
            this.dlProg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.dlProg.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.dlProg.Location = new System.Drawing.Point(237, 757);
            this.dlProg.Margin = new System.Windows.Forms.Padding(4);
            this.dlProg.Name = "dlProg";
            this.dlProg.Size = new System.Drawing.Size(624, 31);
            this.dlProg.TabIndex = 9;
            // 
            // UncheckAll
            // 
            this.UncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UncheckAll.Image = ((System.Drawing.Image)(resources.GetObject("UncheckAll.Image")));
            this.UncheckAll.Location = new System.Drawing.Point(16, 757);
            this.UncheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.UncheckAll.Name = "UncheckAll";
            this.UncheckAll.Size = new System.Drawing.Size(31, 31);
            this.UncheckAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UncheckAll.TabIndex = 16;
            this.UncheckAll.TabStop = false;
            this.UncheckAll.Click += new System.EventHandler(this.UncheckAll_Click);
            // 
            // CheckAll
            // 
            this.CheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.CheckAll.Image = ((System.Drawing.Image)(resources.GetObject("CheckAll.Image")));
            this.CheckAll.Location = new System.Drawing.Point(16, 757);
            this.CheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(31, 31);
            this.CheckAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckAll.TabIndex = 16;
            this.CheckAll.TabStop = false;
            this.CheckAll.Visible = false;
            this.CheckAll.Click += new System.EventHandler(this.CheckAll_Click);
            // 
            // OpenDirBox
            // 
            this.OpenDirBox.AccessibleDescription = "w";
            this.OpenDirBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenDirBox.AutoSize = true;
            this.OpenDirBox.BackColor = System.Drawing.Color.Transparent;
            this.OpenDirBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenDirBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.OpenDirBox.ForeColor = System.Drawing.Color.White;
            this.OpenDirBox.Location = new System.Drawing.Point(700, 41);
            this.OpenDirBox.Margin = new System.Windows.Forms.Padding(4);
            this.OpenDirBox.Name = "OpenDirBox";
            this.OpenDirBox.Size = new System.Drawing.Size(329, 27);
            this.OpenDirBox.TabIndex = 8;
            this.OpenDirBox.Text = "Open download dir when done";
            this.OpenDirBox.UseVisualStyleBackColor = false;
            this.OpenDirBox.CheckedChanged += new System.EventHandler(this.OpenDirBox_CheckedChanged);
            this.OpenDirBox.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
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
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.URL,
            this.Group,
            this.Size});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.Location = new System.Drawing.Point(16, 78);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1063, 668);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            this.listView1.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // splashPanel
            // 
            this.splashPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.splashPanel.Controls.Add(this.tipsText);
            this.splashPanel.Controls.Add(this.tipsHeader);
            this.splashPanel.Controls.Add(this.SplashText);
            this.splashPanel.Controls.Add(this.changeLog);
            this.splashPanel.Location = new System.Drawing.Point(60, 124);
            this.splashPanel.Margin = new System.Windows.Forms.Padding(4);
            this.splashPanel.Name = "splashPanel";
            this.splashPanel.Size = new System.Drawing.Size(975, 617);
            this.splashPanel.TabIndex = 17;
            this.splashPanel.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // tipsText
            // 
            this.tipsText.AutoSize = true;
            this.tipsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.tipsText.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipsText.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.tipsText.Location = new System.Drawing.Point(0, 225);
            this.tipsText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipsText.Name = "tipsText";
            this.tipsText.Size = new System.Drawing.Size(338, 175);
            this.tipsText.TabIndex = 15;
            this.tipsText.Text = "All Legit v1.0.0\r\nby HarryEffinPottter/YSG\r\n\r\nGlobal hot key works everywhere,\r\ne" +
    "ven when app is minimized.\r\n\r\nCTRL+V or Paste button while in app.";
            this.tipsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tipsHeader
            // 
            this.tipsHeader.AutoSize = true;
            this.tipsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.tipsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipsHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tipsHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.tipsHeader.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.tipsHeader.Location = new System.Drawing.Point(0, 200);
            this.tipsHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipsHeader.Name = "tipsHeader";
            this.tipsHeader.Size = new System.Drawing.Size(61, 25);
            this.tipsHeader.TabIndex = 14;
            this.tipsHeader.Text = "Tips:";
            this.tipsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SplashText
            // 
            this.SplashText.AutoSize = true;
            this.SplashText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.SplashText.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplashText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SplashText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashText.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.SplashText.Location = new System.Drawing.Point(0, 25);
            this.SplashText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SplashText.Name = "SplashText";
            this.SplashText.Size = new System.Drawing.Size(338, 175);
            this.SplashText.TabIndex = 13;
            this.SplashText.Text = "All Legit v1.0.0\r\nby HarryEffinPottter/YSG\r\n\r\nGlobal hot key works everywhere,\r\ne" +
    "ven when app is minimized.\r\n\r\nCTRL+V or Paste button while in app.";
            // 
            // changeLog
            // 
            this.changeLog.AutoSize = true;
            this.changeLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.changeLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLog.ForeColor = System.Drawing.Color.PaleGreen;
            this.changeLog.Location = new System.Drawing.Point(0, 0);
            this.changeLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeLog.Name = "changeLog";
            this.changeLog.Size = new System.Drawing.Size(130, 25);
            this.changeLog.TabIndex = 12;
            this.changeLog.Text = "Change log:\r\n";
            // 
            // settingsP
            // 
            this.settingsP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.settingsP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsP.Controls.Add(this.autoUpdateBox);
            this.settingsP.Controls.Add(this.removeURLs);
            this.settingsP.Controls.Add(this.disableNotiesBox);
            this.settingsP.Controls.Add(this.autoDelZips);
            this.settingsP.Controls.Add(this.extractNested);
            this.settingsP.Controls.Add(this.updateNow);
            this.settingsP.Controls.Add(this.AutoExtract);
            this.settingsP.Controls.Add(this.zipPWLabel);
            this.settingsP.Controls.Add(this.Close2Tray);
            this.settingsP.Controls.Add(this.label1);
            this.settingsP.Controls.Add(this.PWBox);
            this.settingsP.Controls.Add(this.AutoOverwrite);
            this.settingsP.Controls.Add(this.AutoDLBox);
            this.settingsP.Controls.Add(this.RemDL);
            this.settingsP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsP.Location = new System.Drawing.Point(434, 7);
            this.settingsP.Margin = new System.Windows.Forms.Padding(4);
            this.settingsP.Name = "settingsP";
            this.settingsP.Padding = new System.Windows.Forms.Padding(60, 80, 60, 55);
            this.settingsP.Size = new System.Drawing.Size(649, 566);
            this.settingsP.TabIndex = 13;
            this.settingsP.Visible = false;
            this.settingsP.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.settingsP.MouseHover += new System.EventHandler(this.showSettings_MouseHover);
            // 
            // autoUpdateBox
            // 
            this.autoUpdateBox.AutoSize = true;
            this.autoUpdateBox.BackColor = System.Drawing.Color.Transparent;
            this.autoUpdateBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoUpdateBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.autoUpdateBox.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.autoUpdateBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.autoUpdateBox.Location = new System.Drawing.Point(60, 350);
            this.autoUpdateBox.Margin = new System.Windows.Forms.Padding(4);
            this.autoUpdateBox.Name = "autoUpdateBox";
            this.autoUpdateBox.Size = new System.Drawing.Size(525, 30);
            this.autoUpdateBox.TabIndex = 19;
            this.autoUpdateBox.Text = "Automatically update on launch";
            this.autoUpdateBox.UseVisualStyleBackColor = false;
            this.autoUpdateBox.CheckedChanged += new System.EventHandler(this.autoUpdateBox_CheckedChanged);
            // 
            // removeURLs
            // 
            this.removeURLs.AutoSize = true;
            this.removeURLs.BackColor = System.Drawing.Color.Transparent;
            this.removeURLs.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeURLs.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.removeURLs.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.removeURLs.ForeColor = System.Drawing.Color.SteelBlue;
            this.removeURLs.Location = new System.Drawing.Point(60, 320);
            this.removeURLs.Margin = new System.Windows.Forms.Padding(4);
            this.removeURLs.Name = "removeURLs";
            this.removeURLs.Size = new System.Drawing.Size(525, 30);
            this.removeURLs.TabIndex = 18;
            this.removeURLs.Text = "Don\'t download URL files";
            this.removeURLs.UseVisualStyleBackColor = false;
            this.removeURLs.CheckedChanged += new System.EventHandler(this.removeURLs_CheckedChanged);
            // 
            // disableNotiesBox
            // 
            this.disableNotiesBox.AutoSize = true;
            this.disableNotiesBox.BackColor = System.Drawing.Color.Transparent;
            this.disableNotiesBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.disableNotiesBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.disableNotiesBox.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.disableNotiesBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.disableNotiesBox.Location = new System.Drawing.Point(60, 290);
            this.disableNotiesBox.Margin = new System.Windows.Forms.Padding(4);
            this.disableNotiesBox.Name = "disableNotiesBox";
            this.disableNotiesBox.Size = new System.Drawing.Size(525, 30);
            this.disableNotiesBox.TabIndex = 16;
            this.disableNotiesBox.Text = "Disable Windows Notifications";
            this.disableNotiesBox.UseVisualStyleBackColor = false;
            this.disableNotiesBox.CheckedChanged += new System.EventHandler(this.disableNotiesBox_CheckedChanged);
            // 
            // autoDelZips
            // 
            this.autoDelZips.AutoSize = true;
            this.autoDelZips.BackColor = System.Drawing.Color.Transparent;
            this.autoDelZips.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoDelZips.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.autoDelZips.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.autoDelZips.ForeColor = System.Drawing.Color.SteelBlue;
            this.autoDelZips.Location = new System.Drawing.Point(60, 260);
            this.autoDelZips.Margin = new System.Windows.Forms.Padding(4);
            this.autoDelZips.Name = "autoDelZips";
            this.autoDelZips.Size = new System.Drawing.Size(525, 30);
            this.autoDelZips.TabIndex = 15;
            this.autoDelZips.Text = "Delete extracted archives";
            this.autoDelZips.UseVisualStyleBackColor = false;
            this.autoDelZips.CheckedChanged += new System.EventHandler(this.autoDelZips_CheckedChanged_1);
            // 
            // extractNested
            // 
            this.extractNested.AutoSize = true;
            this.extractNested.BackColor = System.Drawing.Color.Transparent;
            this.extractNested.Dock = System.Windows.Forms.DockStyle.Top;
            this.extractNested.Enabled = false;
            this.extractNested.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.extractNested.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.extractNested.ForeColor = System.Drawing.Color.SteelBlue;
            this.extractNested.Location = new System.Drawing.Point(60, 230);
            this.extractNested.Margin = new System.Windows.Forms.Padding(4);
            this.extractNested.Name = "extractNested";
            this.extractNested.Size = new System.Drawing.Size(525, 30);
            this.extractNested.TabIndex = 14;
            this.extractNested.Text = "Extract nested archives";
            this.extractNested.UseVisualStyleBackColor = false;
            this.extractNested.CheckedChanged += new System.EventHandler(this.extractNested_CheckedChanged);
            // 
            // updateNow
            // 
            this.updateNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateNow.BackColor = System.Drawing.Color.Transparent;
            this.updateNow.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.updateNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.updateNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.updateNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.updateNow.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.updateNow.Location = new System.Drawing.Point(60, 389);
            this.updateNow.Margin = new System.Windows.Forms.Padding(4);
            this.updateNow.Name = "updateNow";
            this.updateNow.Size = new System.Drawing.Size(283, 34);
            this.updateNow.TabIndex = 2;
            this.updateNow.Text = "Check if update is available now";
            this.updateNow.UseVisualStyleBackColor = false;
            this.updateNow.Click += new System.EventHandler(this.updateNow_Click);
            // 
            // AutoExtract
            // 
            this.AutoExtract.AutoSize = true;
            this.AutoExtract.BackColor = System.Drawing.Color.Transparent;
            this.AutoExtract.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoExtract.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.AutoExtract.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.AutoExtract.ForeColor = System.Drawing.Color.SteelBlue;
            this.AutoExtract.Location = new System.Drawing.Point(60, 200);
            this.AutoExtract.Margin = new System.Windows.Forms.Padding(4);
            this.AutoExtract.Name = "AutoExtract";
            this.AutoExtract.Size = new System.Drawing.Size(525, 30);
            this.AutoExtract.TabIndex = 10;
            this.AutoExtract.Text = "Extract finished";
            this.AutoExtract.UseVisualStyleBackColor = false;
            this.AutoExtract.CheckedChanged += new System.EventHandler(this.AutoExtract_CheckedChanged_1);
            this.AutoExtract.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // zipPWLabel
            // 
            this.zipPWLabel.AutoSize = true;
            this.zipPWLabel.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.zipPWLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.zipPWLabel.Location = new System.Drawing.Point(88, 459);
            this.zipPWLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipPWLabel.Name = "zipPWLabel";
            this.zipPWLabel.Size = new System.Drawing.Size(468, 26);
            this.zipPWLabel.TabIndex = 9;
            this.zipPWLabel.Text = "Archive passwords - Use ; to separate.";
            this.zipPWLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zipPWLabel.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.zipPWLabel.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // Close2Tray
            // 
            this.Close2Tray.AutoSize = true;
            this.Close2Tray.BackColor = System.Drawing.Color.Transparent;
            this.Close2Tray.Dock = System.Windows.Forms.DockStyle.Top;
            this.Close2Tray.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.Close2Tray.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.Close2Tray.ForeColor = System.Drawing.Color.SteelBlue;
            this.Close2Tray.Location = new System.Drawing.Point(60, 170);
            this.Close2Tray.Margin = new System.Windows.Forms.Padding(4);
            this.Close2Tray.Name = "Close2Tray";
            this.Close2Tray.Size = new System.Drawing.Size(525, 30);
            this.Close2Tray.TabIndex = 9;
            this.Close2Tray.Text = "Close to system tray";
            this.Close2Tray.UseVisualStyleBackColor = false;
            this.Close2Tray.CheckedChanged += new System.EventHandler(this.Close2Tray_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(160, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "All Legit Settings\r\n(These save automatically)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.label1.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // PWBox
            // 
            this.PWBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.PWBox.Enabled = false;
            this.PWBox.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.PWBox.Location = new System.Drawing.Point(47, 493);
            this.PWBox.Margin = new System.Windows.Forms.Padding(4);
            this.PWBox.Name = "PWBox";
            this.PWBox.Size = new System.Drawing.Size(551, 31);
            this.PWBox.TabIndex = 4;
            this.PWBox.Text = "Your;Commonly;Used;Zip;passwords";
            this.PWBox.Click += new System.EventHandler(this.PWBox_Enter);
            this.PWBox.Enter += new System.EventHandler(this.PWBox_Enter);
            this.PWBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PWBox_KeyPress);
            this.PWBox.Leave += new System.EventHandler(this.PWBox_Leave);
            this.PWBox.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.PWBox.MouseHover += new System.EventHandler(this.showSettings_MouseHover);
            // 
            // AutoOverwrite
            // 
            this.AutoOverwrite.AutoSize = true;
            this.AutoOverwrite.BackColor = System.Drawing.Color.Transparent;
            this.AutoOverwrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoOverwrite.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.AutoOverwrite.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.AutoOverwrite.ForeColor = System.Drawing.Color.SteelBlue;
            this.AutoOverwrite.Location = new System.Drawing.Point(60, 140);
            this.AutoOverwrite.Margin = new System.Windows.Forms.Padding(4);
            this.AutoOverwrite.Name = "AutoOverwrite";
            this.AutoOverwrite.Size = new System.Drawing.Size(525, 30);
            this.AutoOverwrite.TabIndex = 0;
            this.AutoOverwrite.Text = "Overwrite existing";
            this.AutoOverwrite.UseVisualStyleBackColor = false;
            this.AutoOverwrite.CheckedChanged += new System.EventHandler(this.AutoDelete_CheckedChanged);
            this.AutoOverwrite.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.AutoOverwrite.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // AutoDLBox
            // 
            this.AutoDLBox.AutoSize = true;
            this.AutoDLBox.BackColor = System.Drawing.Color.Transparent;
            this.AutoDLBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoDLBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.AutoDLBox.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.AutoDLBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.AutoDLBox.Location = new System.Drawing.Point(60, 110);
            this.AutoDLBox.Margin = new System.Windows.Forms.Padding(4);
            this.AutoDLBox.Name = "AutoDLBox";
            this.AutoDLBox.Size = new System.Drawing.Size(525, 30);
            this.AutoDLBox.TabIndex = 0;
            this.AutoDLBox.Text = "Auto download";
            this.AutoDLBox.UseVisualStyleBackColor = false;
            this.AutoDLBox.CheckedChanged += new System.EventHandler(this.AutoDLBox_CheckedChanged);
            this.AutoDLBox.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // RemDL
            // 
            this.RemDL.AutoSize = true;
            this.RemDL.BackColor = System.Drawing.Color.Transparent;
            this.RemDL.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemDL.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.RemDL.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.RemDL.ForeColor = System.Drawing.Color.SteelBlue;
            this.RemDL.Location = new System.Drawing.Point(60, 80);
            this.RemDL.Margin = new System.Windows.Forms.Padding(4);
            this.RemDL.Name = "RemDL";
            this.RemDL.Size = new System.Drawing.Size(525, 30);
            this.RemDL.TabIndex = 6;
            this.RemDL.Text = "Clear Finished";
            this.RemDL.UseVisualStyleBackColor = false;
            this.RemDL.CheckedChanged += new System.EventHandler(this.RemDL_CheckedChanged);
            this.RemDL.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // selectTorrent
            // 
            this.selectTorrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectTorrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.selectTorrent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.selectTorrent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.selectTorrent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.selectTorrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTorrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.selectTorrent.ForeColor = System.Drawing.SystemColors.Control;
            this.selectTorrent.Location = new System.Drawing.Point(16, 792);
            this.selectTorrent.Margin = new System.Windows.Forms.Padding(4);
            this.selectTorrent.Name = "selectTorrent";
            this.selectTorrent.Size = new System.Drawing.Size(212, 31);
            this.selectTorrent.TabIndex = 2;
            this.selectTorrent.Text = "Select torrent file";
            this.selectTorrent.UseVisualStyleBackColor = false;
            this.selectTorrent.Click += new System.EventHandler(this.selectTorrent_Click);
            // 
            // startDownloads
            // 
            this.startDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startDownloads.Cursor = System.Windows.Forms.Cursors.Default;
            this.startDownloads.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.startDownloads.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.startDownloads.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.startDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDownloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDownloads.ForeColor = System.Drawing.SystemColors.Control;
            this.startDownloads.Location = new System.Drawing.Point(870, 792);
            this.startDownloads.Margin = new System.Windows.Forms.Padding(4);
            this.startDownloads.Name = "startDownloads";
            this.startDownloads.Size = new System.Drawing.Size(209, 31);
            this.startDownloads.TabIndex = 1;
            this.startDownloads.Text = "Download Selected";
            this.startDownloads.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startDownloads.UseVisualStyleBackColor = false;
            this.startDownloads.Click += new System.EventHandler(this.startDownloads_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CancelButton.ForeColor = System.Drawing.Color.Moccasin;
            this.CancelButton.Location = new System.Drawing.Point(870, 792);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(209, 31);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel Current Job";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1095, 836);
            this.Controls.Add(this.settingsP);
            this.Controls.Add(this.splashPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckAll);
            this.Controls.Add(this.UncheckAll);
            this.Controls.Add(this.OpenDirBox);
            this.Controls.Add(this.StayOnTopCheckbox);
            this.Controls.Add(this.dlProg);
            this.Controls.Add(this.HotKeyBox);
            this.Controls.Add(this.DownloadDir);
            this.Controls.Add(this.HotKeyBtn);
            this.Controls.Add(this.SetDLDIR);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.selectTorrent);
            this.Controls.Add(this.CopyLinks);
            this.Controls.Add(this.startDownloads);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DownloadingText);
            this.ForeColor = System.Drawing.Color.NavajoWhite;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(958, 614);
            this.Name = "MainWindow";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Legit: Connecting...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            this.MouseLeave += new System.EventHandler(this.settingsP_MouseLeave);
            this.Resize += new System.EventHandler(this.MainWindow_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UncheckAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckAll)).EndInit();
            this.splashPanel.ResumeLayout(false);
            this.splashPanel.PerformLayout();
            this.settingsP.ResumeLayout(false);
            this.settingsP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DownloadDir;
        private System.Windows.Forms.Button SetDLDIR;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.CheckBox StayOnTopCheckbox;
        private System.Windows.Forms.TextBox HotKeyBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HotKeyBtn;
        private System.Windows.Forms.Button CopyLinks;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ProgressBar dlProg;
        private System.Windows.Forms.PictureBox UncheckAll;
        private System.Windows.Forms.PictureBox CheckAll;
        public System.Windows.Forms.Label DownloadingText;
        private System.Windows.Forms.CheckBox OpenDirBox;
        public System.Windows.Forms.NotifyIcon ALTrayIcon;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ColumnHeader Size;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label tipsText;
        private System.Windows.Forms.Label tipsHeader;
        private System.Windows.Forms.Label SplashText;
        private System.Windows.Forms.Label changeLog;
        public System.Windows.Forms.Panel splashPanel;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zipPWLabel;
        private System.Windows.Forms.Button updateNow;
        private System.Windows.Forms.Panel settingsP;
        private System.Windows.Forms.Button selectTorrent;
        private System.Windows.Forms.CheckBox autoUpdateBox;
        private System.Windows.Forms.CheckBox removeURLs;
        private System.Windows.Forms.CheckBox disableNotiesBox;
        private System.Windows.Forms.CheckBox autoDelZips;
        private System.Windows.Forms.CheckBox extractNested;
        private System.Windows.Forms.CheckBox AutoExtract;
        private System.Windows.Forms.CheckBox Close2Tray;
        private System.Windows.Forms.CheckBox AutoOverwrite;
        private System.Windows.Forms.CheckBox AutoDLBox;
        private System.Windows.Forms.CheckBox RemDL;
        private System.Windows.Forms.Button startDownloads;
        public System.Windows.Forms.Button CancelButton;
    }
}

