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
            this.StayOnTopCheckbox = new System.Windows.Forms.CheckBox();
            this.HotKeyBox = new System.Windows.Forms.TextBox();
            this.ALTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HotKeyBtn = new System.Windows.Forms.Button();
            this.DownloadingText = new System.Windows.Forms.Label();
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
            this.KA_tipsHeader = new System.Windows.Forms.Label();
            this.SplashText = new System.Windows.Forms.Label();
            this.KA_changeLog_Label = new System.Windows.Forms.Label();
            this.settingsP = new System.Windows.Forms.Panel();
            this.ApiManPanel = new System.Windows.Forms.Panel();
            this.CancelAPIMan = new System.Windows.Forms.Button();
            this.ApiManConnect = new System.Windows.Forms.Button();
            this.KA_APIHeader = new System.Windows.Forms.Label();
            this.KA_APINm = new System.Windows.Forms.Label();
            this.ApiNameMan = new System.Windows.Forms.TextBox();
            this.KA_ApiKeyLbl = new System.Windows.Forms.Label();
            this.ApiKeyMan = new System.Windows.Forms.TextBox();
            this.ShowManualPanel = new System.Windows.Forms.Button();
            this.autoUpdateBox = new System.Windows.Forms.CheckBox();
            this.removeURLs = new System.Windows.Forms.CheckBox();
            this.disableNotiesBox = new System.Windows.Forms.CheckBox();
            this.autoDelZips = new System.Windows.Forms.CheckBox();
            this.extractNested = new System.Windows.Forms.CheckBox();
            this.updateNow = new System.Windows.Forms.Button();
            this.AutoExtract = new System.Windows.Forms.CheckBox();
            this.KA_zip_pwlabel = new System.Windows.Forms.Label();
            this.Close2Tray = new System.Windows.Forms.CheckBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.AutoOverwrite = new System.Windows.Forms.CheckBox();
            this.AutoDLBox = new System.Windows.Forms.CheckBox();
            this.RemDL = new System.Windows.Forms.CheckBox();
            this.KA_ALSettingsLabel = new System.Windows.Forms.Label();
            this.startDownloads = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CopyLinks = new System.Windows.Forms.Button();
            this.linksToTextButton = new System.Windows.Forms.Button();
            this.selectTorrent = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.bulkAddBtn = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SetDLDIR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UncheckAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckAll)).BeginInit();
            this.splashPanel.SuspendLayout();
            this.settingsP.SuspendLayout();
            this.ApiManPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownloadDir
            // 
            this.DownloadDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.DownloadDir.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadDir.ForeColor = System.Drawing.Color.White;
            this.DownloadDir.Location = new System.Drawing.Point(8, 9);
            this.DownloadDir.Name = "DownloadDir";
            this.DownloadDir.Size = new System.Drawing.Size(410, 23);
            this.DownloadDir.TabIndex = 10;
            this.DownloadDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DownloadDir_KeyPress);
            this.DownloadDir.Leave += new System.EventHandler(this.DownloadDir_Leave);
            this.DownloadDir.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // StayOnTopCheckbox
            // 
            this.StayOnTopCheckbox.AccessibleDescription = "w";
            this.StayOnTopCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StayOnTopCheckbox.AutoSize = true;
            this.StayOnTopCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.StayOnTopCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StayOnTopCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.StayOnTopCheckbox.ForeColor = System.Drawing.Color.White;
            this.StayOnTopCheckbox.Location = new System.Drawing.Point(518, 39);
            this.StayOnTopCheckbox.Name = "StayOnTopCheckbox";
            this.StayOnTopCheckbox.Size = new System.Drawing.Size(201, 18);
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
            this.HotKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.HotKeyBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeyBox.ForeColor = System.Drawing.Color.White;
            this.HotKeyBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.HotKeyBox.Location = new System.Drawing.Point(424, 9);
            this.HotKeyBox.Name = "HotKeyBox";
            this.HotKeyBox.ReadOnly = true;
            this.HotKeyBox.Size = new System.Drawing.Size(329, 23);
            this.HotKeyBox.TabIndex = 9;
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
            this.pictureBox1.Location = new System.Drawing.Point(775, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // HotKeyBtn
            // 
            this.HotKeyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HotKeyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.HotKeyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.HotKeyBtn.FlatAppearance.BorderSize = 0;
            this.HotKeyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.HotKeyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.HotKeyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotKeyBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeyBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.HotKeyBtn.Location = new System.Drawing.Point(424, 35);
            this.HotKeyBtn.Name = "HotKeyBtn";
            this.HotKeyBtn.Size = new System.Drawing.Size(83, 22);
            this.HotKeyBtn.TabIndex = 6;
            this.HotKeyBtn.Text = "Set Hotkey";
            this.HotKeyBtn.UseVisualStyleBackColor = false;
            this.HotKeyBtn.Click += new System.EventHandler(this.HotKeyBtn_Click);
            // 
            // DownloadingText
            // 
            this.DownloadingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadingText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.DownloadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.DownloadingText.Location = new System.Drawing.Point(-1, 678);
            this.DownloadingText.Name = "DownloadingText";
            this.DownloadingText.Size = new System.Drawing.Size(822, 27);
            this.DownloadingText.TabIndex = 12;
            this.DownloadingText.Text = "...";
            this.DownloadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dlProg
            // 
            this.dlProg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dlProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.dlProg.Location = new System.Drawing.Point(-1, 707);
            this.dlProg.Name = "dlProg";
            this.dlProg.Size = new System.Drawing.Size(822, 17);
            this.dlProg.TabIndex = 9;
            // 
            // UncheckAll
            // 
            this.UncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UncheckAll.BackColor = System.Drawing.Color.Transparent;
            this.UncheckAll.Image = ((System.Drawing.Image)(resources.GetObject("UncheckAll.Image")));
            this.UncheckAll.Location = new System.Drawing.Point(13, 651);
            this.UncheckAll.Name = "UncheckAll";
            this.UncheckAll.Size = new System.Drawing.Size(19, 20);
            this.UncheckAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UncheckAll.TabIndex = 16;
            this.UncheckAll.TabStop = false;
            this.UncheckAll.Click += new System.EventHandler(this.UncheckAll_Click);
            // 
            // CheckAll
            // 
            this.CheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckAll.BackColor = System.Drawing.Color.Transparent;
            this.CheckAll.Image = ((System.Drawing.Image)(resources.GetObject("CheckAll.Image")));
            this.CheckAll.Location = new System.Drawing.Point(13, 651);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(19, 20);
            this.CheckAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckAll.TabIndex = 16;
            this.CheckAll.TabStop = false;
            this.CheckAll.Visible = false;
            this.CheckAll.Click += new System.EventHandler(this.CheckAll_Click);
            // 
            // OpenDirBox
            // 
            this.OpenDirBox.AccessibleDescription = "w";
            this.OpenDirBox.AutoSize = true;
            this.OpenDirBox.BackColor = System.Drawing.Color.Transparent;
            this.OpenDirBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenDirBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.OpenDirBox.ForeColor = System.Drawing.Color.White;
            this.OpenDirBox.Location = new System.Drawing.Point(155, 39);
            this.OpenDirBox.Name = "OpenDirBox";
            this.OpenDirBox.Size = new System.Drawing.Size(215, 18);
            this.OpenDirBox.TabIndex = 7;
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
            this.Group.Width = 118;
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
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
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
            this.listView1.Location = new System.Drawing.Point(8, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(804, 580);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            this.listView1.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // splashPanel
            // 
            this.splashPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.splashPanel.Controls.Add(this.tipsText);
            this.splashPanel.Controls.Add(this.KA_tipsHeader);
            this.splashPanel.Controls.Add(this.SplashText);
            this.splashPanel.Controls.Add(this.KA_changeLog_Label);
            this.splashPanel.Location = new System.Drawing.Point(32, 101);
            this.splashPanel.Name = "splashPanel";
            this.splashPanel.Size = new System.Drawing.Size(762, 512);
            this.splashPanel.TabIndex = 17;
            this.splashPanel.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // tipsText
            // 
            this.tipsText.AutoSize = true;
            this.tipsText.BackColor = System.Drawing.Color.Transparent;
            this.tipsText.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipsText.ForeColor = System.Drawing.Color.White;
            this.tipsText.Location = new System.Drawing.Point(0, 174);
            this.tipsText.Name = "tipsText";
            this.tipsText.Size = new System.Drawing.Size(273, 140);
            this.tipsText.TabIndex = 15;
            this.tipsText.Text = "All Legit v1.0.0\r\nby HarryEffinPottter/YSG\r\n\r\nGlobal hot key works everywhere,\r\ne" +
    "ven when app is minimized.\r\n\r\nCTRL+V or Paste button while in app.";
            this.tipsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KA_tipsHeader
            // 
            this.KA_tipsHeader.AutoSize = true;
            this.KA_tipsHeader.BackColor = System.Drawing.Color.Transparent;
            this.KA_tipsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.KA_tipsHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KA_tipsHeader.Font = new System.Drawing.Font("Karmatic Arcade", 12F);
            this.KA_tipsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.KA_tipsHeader.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.KA_tipsHeader.Location = new System.Drawing.Point(0, 157);
            this.KA_tipsHeader.Name = "KA_tipsHeader";
            this.KA_tipsHeader.Size = new System.Drawing.Size(59, 17);
            this.KA_tipsHeader.TabIndex = 14;
            this.KA_tipsHeader.Text = "Tips:";
            this.KA_tipsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SplashText
            // 
            this.SplashText.AutoSize = true;
            this.SplashText.BackColor = System.Drawing.Color.Transparent;
            this.SplashText.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplashText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SplashText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashText.ForeColor = System.Drawing.Color.White;
            this.SplashText.Location = new System.Drawing.Point(0, 17);
            this.SplashText.Name = "SplashText";
            this.SplashText.Size = new System.Drawing.Size(273, 140);
            this.SplashText.TabIndex = 13;
            this.SplashText.Text = "All Legit v1.0.0\r\nby HarryEffinPottter/YSG\r\n\r\nGlobal hot key works everywhere,\r\ne" +
    "ven when app is minimized.\r\n\r\nCTRL+V or Paste button while in app.";
            // 
            // KA_changeLog_Label
            // 
            this.KA_changeLog_Label.AutoSize = true;
            this.KA_changeLog_Label.BackColor = System.Drawing.Color.Transparent;
            this.KA_changeLog_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.KA_changeLog_Label.Font = new System.Drawing.Font("Karmatic Arcade", 12F);
            this.KA_changeLog_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.KA_changeLog_Label.Location = new System.Drawing.Point(0, 0);
            this.KA_changeLog_Label.Name = "KA_changeLog_Label";
            this.KA_changeLog_Label.Size = new System.Drawing.Size(141, 17);
            this.KA_changeLog_Label.TabIndex = 12;
            this.KA_changeLog_Label.Text = "Change log:\r\n";
            // 
            // settingsP
            // 
            this.settingsP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.settingsP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsP.Controls.Add(this.ApiManPanel);
            this.settingsP.Controls.Add(this.ShowManualPanel);
            this.settingsP.Controls.Add(this.autoUpdateBox);
            this.settingsP.Controls.Add(this.removeURLs);
            this.settingsP.Controls.Add(this.disableNotiesBox);
            this.settingsP.Controls.Add(this.autoDelZips);
            this.settingsP.Controls.Add(this.extractNested);
            this.settingsP.Controls.Add(this.updateNow);
            this.settingsP.Controls.Add(this.AutoExtract);
            this.settingsP.Controls.Add(this.KA_zip_pwlabel);
            this.settingsP.Controls.Add(this.Close2Tray);
            this.settingsP.Controls.Add(this.PWBox);
            this.settingsP.Controls.Add(this.AutoOverwrite);
            this.settingsP.Controls.Add(this.AutoDLBox);
            this.settingsP.Controls.Add(this.RemDL);
            this.settingsP.Controls.Add(this.KA_ALSettingsLabel);
            this.settingsP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsP.Location = new System.Drawing.Point(366, 6);
            this.settingsP.Name = "settingsP";
            this.settingsP.Size = new System.Drawing.Size(446, 478);
            this.settingsP.TabIndex = 13;
            this.settingsP.Visible = false;
            this.settingsP.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.settingsP.MouseHover += new System.EventHandler(this.showSettings_MouseHover);
            // 
            // ApiManPanel
            // 
            this.ApiManPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApiManPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ApiManPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApiManPanel.Controls.Add(this.CancelAPIMan);
            this.ApiManPanel.Controls.Add(this.ApiManConnect);
            this.ApiManPanel.Controls.Add(this.KA_APIHeader);
            this.ApiManPanel.Controls.Add(this.KA_APINm);
            this.ApiManPanel.Controls.Add(this.ApiNameMan);
            this.ApiManPanel.Controls.Add(this.KA_ApiKeyLbl);
            this.ApiManPanel.Controls.Add(this.ApiKeyMan);
            this.ApiManPanel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApiManPanel.Location = new System.Drawing.Point(140, 5);
            this.ApiManPanel.Name = "ApiManPanel";
            this.ApiManPanel.Size = new System.Drawing.Size(301, 265);
            this.ApiManPanel.TabIndex = 13;
            this.ApiManPanel.Visible = false;
            this.ApiManPanel.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.ApiManPanel.MouseHover += new System.EventHandler(this.showSettings_MouseHover);
            // 
            // CancelAPIMan
            // 
            this.CancelAPIMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.CancelAPIMan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CancelAPIMan.FlatAppearance.BorderSize = 0;
            this.CancelAPIMan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.CancelAPIMan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.CancelAPIMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAPIMan.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAPIMan.ForeColor = System.Drawing.Color.White;
            this.CancelAPIMan.Location = new System.Drawing.Point(122, 217);
            this.CancelAPIMan.Name = "CancelAPIMan";
            this.CancelAPIMan.Size = new System.Drawing.Size(71, 29);
            this.CancelAPIMan.TabIndex = 3;
            this.CancelAPIMan.Text = "Cancel";
            this.CancelAPIMan.UseVisualStyleBackColor = false;
            this.CancelAPIMan.Click += new System.EventHandler(this.CancelAPIMan_Click);
            // 
            // ApiManConnect
            // 
            this.ApiManConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(143)))));
            this.ApiManConnect.Enabled = false;
            this.ApiManConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ApiManConnect.FlatAppearance.BorderSize = 0;
            this.ApiManConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ApiManConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ApiManConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApiManConnect.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApiManConnect.ForeColor = System.Drawing.Color.White;
            this.ApiManConnect.Location = new System.Drawing.Point(196, 217);
            this.ApiManConnect.Name = "ApiManConnect";
            this.ApiManConnect.Size = new System.Drawing.Size(89, 29);
            this.ApiManConnect.TabIndex = 3;
            this.ApiManConnect.Text = "Connect";
            this.ApiManConnect.UseVisualStyleBackColor = false;
            this.ApiManConnect.Click += new System.EventHandler(this.ApiManConnect_Click);
            // 
            // KA_APIHeader
            // 
            this.KA_APIHeader.AutoSize = true;
            this.KA_APIHeader.Font = new System.Drawing.Font("Karmatic Arcade", 13F);
            this.KA_APIHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.KA_APIHeader.Location = new System.Drawing.Point(33, 28);
            this.KA_APIHeader.Name = "KA_APIHeader";
            this.KA_APIHeader.Size = new System.Drawing.Size(228, 20);
            this.KA_APIHeader.TabIndex = 9;
            this.KA_APIHeader.Text = "Manual API entry";
            this.KA_APIHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KA_APIHeader.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.KA_APIHeader.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // KA_APINm
            // 
            this.KA_APINm.AutoSize = true;
            this.KA_APINm.Font = new System.Drawing.Font("Karmatic Arcade", 9.75F);
            this.KA_APINm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.KA_APINm.Location = new System.Drawing.Point(26, 111);
            this.KA_APINm.Name = "KA_APINm";
            this.KA_APINm.Size = new System.Drawing.Size(82, 15);
            this.KA_APINm.TabIndex = 9;
            this.KA_APINm.Text = "Api Name";
            this.KA_APINm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KA_APINm.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.KA_APINm.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // ApiNameMan
            // 
            this.ApiNameMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ApiNameMan.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ApiNameMan.Location = new System.Drawing.Point(21, 76);
            this.ApiNameMan.Margin = new System.Windows.Forms.Padding(45, 49, 45, 49);
            this.ApiNameMan.MaxLength = 50;
            this.ApiNameMan.Name = "ApiNameMan";
            this.ApiNameMan.Size = new System.Drawing.Size(262, 26);
            this.ApiNameMan.TabIndex = 0;
            this.ApiNameMan.TextChanged += new System.EventHandler(this.ApiNameMan_TextChanged);
            this.ApiNameMan.Enter += new System.EventHandler(this.PWBox_Enter);
            this.ApiNameMan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PWBox_KeyPress);
            this.ApiNameMan.Leave += new System.EventHandler(this.PWBox_Leave);
            this.ApiNameMan.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.ApiNameMan.MouseHover += new System.EventHandler(this.showSettings_MouseHover);
            // 
            // KA_ApiKeyLbl
            // 
            this.KA_ApiKeyLbl.AutoSize = true;
            this.KA_ApiKeyLbl.Font = new System.Drawing.Font("Karmatic Arcade", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KA_ApiKeyLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.KA_ApiKeyLbl.Location = new System.Drawing.Point(26, 181);
            this.KA_ApiKeyLbl.Name = "KA_ApiKeyLbl";
            this.KA_ApiKeyLbl.Size = new System.Drawing.Size(70, 15);
            this.KA_ApiKeyLbl.TabIndex = 9;
            this.KA_ApiKeyLbl.Text = "Api Key";
            this.KA_ApiKeyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KA_ApiKeyLbl.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.KA_ApiKeyLbl.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // ApiKeyMan
            // 
            this.ApiKeyMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ApiKeyMan.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ApiKeyMan.Location = new System.Drawing.Point(21, 144);
            this.ApiKeyMan.Name = "ApiKeyMan";
            this.ApiKeyMan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApiKeyMan.Size = new System.Drawing.Size(262, 26);
            this.ApiKeyMan.TabIndex = 2;
            this.ApiKeyMan.TextChanged += new System.EventHandler(this.ApiKeyMan_TextChanged);
            this.ApiKeyMan.Enter += new System.EventHandler(this.PWBox_Enter);
            this.ApiKeyMan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PWBox_KeyPress);
            this.ApiKeyMan.Leave += new System.EventHandler(this.PWBox_Leave);
            this.ApiKeyMan.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.ApiKeyMan.MouseHover += new System.EventHandler(this.showSettings_MouseHover);
            // 
            // ShowManualPanel
            // 
            this.ShowManualPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(143)))));
            this.ShowManualPanel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ShowManualPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ShowManualPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ShowManualPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowManualPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold);
            this.ShowManualPanel.ForeColor = System.Drawing.Color.White;
            this.ShowManualPanel.Location = new System.Drawing.Point(340, 9);
            this.ShowManualPanel.Name = "ShowManualPanel";
            this.ShowManualPanel.Size = new System.Drawing.Size(95, 25);
            this.ShowManualPanel.TabIndex = 0;
            this.ShowManualPanel.Text = "Add APIKey";
            this.ShowManualPanel.UseVisualStyleBackColor = false;
            this.ShowManualPanel.Click += new System.EventHandler(this.ShowManualPanel_Click);
            // 
            // autoUpdateBox
            // 
            this.autoUpdateBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.autoUpdateBox.AutoSize = true;
            this.autoUpdateBox.BackColor = System.Drawing.Color.Transparent;
            this.autoUpdateBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.autoUpdateBox.Font = new System.Drawing.Font("Consolas", 13F);
            this.autoUpdateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(135)))));
            this.autoUpdateBox.Location = new System.Drawing.Point(24, 299);
            this.autoUpdateBox.Name = "autoUpdateBox";
            this.autoUpdateBox.Size = new System.Drawing.Size(329, 26);
            this.autoUpdateBox.TabIndex = 12;
            this.autoUpdateBox.Text = "Automatically update on launch";
            this.autoUpdateBox.UseVisualStyleBackColor = false;
            this.autoUpdateBox.CheckedChanged += new System.EventHandler(this.autoUpdateBox_CheckedChanged);
            // 
            // removeURLs
            // 
            this.removeURLs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.removeURLs.AutoSize = true;
            this.removeURLs.BackColor = System.Drawing.Color.Transparent;
            this.removeURLs.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.removeURLs.Font = new System.Drawing.Font("Consolas", 13F);
            this.removeURLs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(135)))));
            this.removeURLs.Location = new System.Drawing.Point(24, 273);
            this.removeURLs.Name = "removeURLs";
            this.removeURLs.Size = new System.Drawing.Size(269, 26);
            this.removeURLs.TabIndex = 11;
            this.removeURLs.Text = "Don\'t download URL files";
            this.removeURLs.UseVisualStyleBackColor = false;
            this.removeURLs.CheckedChanged += new System.EventHandler(this.removeURLs_CheckedChanged);
            // 
            // disableNotiesBox
            // 
            this.disableNotiesBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.disableNotiesBox.AutoSize = true;
            this.disableNotiesBox.BackColor = System.Drawing.Color.Transparent;
            this.disableNotiesBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.disableNotiesBox.Font = new System.Drawing.Font("Consolas", 13F);
            this.disableNotiesBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(135)))));
            this.disableNotiesBox.Location = new System.Drawing.Point(24, 247);
            this.disableNotiesBox.Name = "disableNotiesBox";
            this.disableNotiesBox.Size = new System.Drawing.Size(319, 26);
            this.disableNotiesBox.TabIndex = 10;
            this.disableNotiesBox.Text = "Disable Windows Notifications";
            this.disableNotiesBox.UseVisualStyleBackColor = false;
            this.disableNotiesBox.CheckedChanged += new System.EventHandler(this.disableNotiesBox_CheckedChanged);
            // 
            // autoDelZips
            // 
            this.autoDelZips.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.autoDelZips.AutoSize = true;
            this.autoDelZips.BackColor = System.Drawing.Color.Transparent;
            this.autoDelZips.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.autoDelZips.Font = new System.Drawing.Font("Consolas", 13F);
            this.autoDelZips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(135)))));
            this.autoDelZips.Location = new System.Drawing.Point(24, 221);
            this.autoDelZips.Name = "autoDelZips";
            this.autoDelZips.Size = new System.Drawing.Size(279, 26);
            this.autoDelZips.TabIndex = 9;
            this.autoDelZips.Text = "Delete extracted archives";
            this.autoDelZips.UseVisualStyleBackColor = false;
            this.autoDelZips.CheckedChanged += new System.EventHandler(this.autoDelZips_CheckedChanged_1);
            // 
            // extractNested
            // 
            this.extractNested.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.extractNested.AutoSize = true;
            this.extractNested.BackColor = System.Drawing.Color.Transparent;
            this.extractNested.Enabled = false;
            this.extractNested.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.extractNested.Font = new System.Drawing.Font("Consolas", 13F);
            this.extractNested.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(135)))));
            this.extractNested.Location = new System.Drawing.Point(24, 195);
            this.extractNested.Name = "extractNested";
            this.extractNested.Size = new System.Drawing.Size(259, 26);
            this.extractNested.TabIndex = 5;
            this.extractNested.Text = "Extract nested archives";
            this.extractNested.UseVisualStyleBackColor = false;
            this.extractNested.CheckedChanged += new System.EventHandler(this.extractNested_CheckedChanged);
            // 
            // updateNow
            // 
            this.updateNow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(143)))));
            this.updateNow.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.updateNow.FlatAppearance.BorderSize = 0;
            this.updateNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.updateNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.updateNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateNow.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNow.ForeColor = System.Drawing.Color.White;
            this.updateNow.Location = new System.Drawing.Point(24, 331);
            this.updateNow.Name = "updateNow";
            this.updateNow.Size = new System.Drawing.Size(258, 27);
            this.updateNow.TabIndex = 13;
            this.updateNow.Text = "Check if update is available now";
            this.updateNow.UseVisualStyleBackColor = false;
            this.updateNow.Click += new System.EventHandler(this.updateNow_Click);
            // 
            // AutoExtract
            // 
            this.AutoExtract.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AutoExtract.AutoSize = true;
            this.AutoExtract.BackColor = System.Drawing.Color.Transparent;
            this.AutoExtract.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.AutoExtract.Font = new System.Drawing.Font("Consolas", 13F);
            this.AutoExtract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(135)))));
            this.AutoExtract.Location = new System.Drawing.Point(24, 169);
            this.AutoExtract.Name = "AutoExtract";
            this.AutoExtract.Size = new System.Drawing.Size(189, 26);
            this.AutoExtract.TabIndex = 4;
            this.AutoExtract.Text = "Extract finished";
            this.AutoExtract.UseVisualStyleBackColor = false;
            this.AutoExtract.CheckedChanged += new System.EventHandler(this.AutoExtract_CheckedChanged_1);
            this.AutoExtract.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // KA_zip_pwlabel
            // 
            this.KA_zip_pwlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KA_zip_pwlabel.AutoSize = true;
            this.KA_zip_pwlabel.Font = new System.Drawing.Font("Karmatic Arcade", 11F);
            this.KA_zip_pwlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.KA_zip_pwlabel.Location = new System.Drawing.Point(20, 389);
            this.KA_zip_pwlabel.Name = "KA_zip_pwlabel";
            this.KA_zip_pwlabel.Size = new System.Drawing.Size(213, 17);
            this.KA_zip_pwlabel.TabIndex = 9;
            this.KA_zip_pwlabel.Text = "archive passwords";
            this.KA_zip_pwlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KA_zip_pwlabel.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.KA_zip_pwlabel.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // Close2Tray
            // 
            this.Close2Tray.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Close2Tray.AutoSize = true;
            this.Close2Tray.BackColor = System.Drawing.Color.Transparent;
            this.Close2Tray.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.Close2Tray.Font = new System.Drawing.Font("Consolas", 13F);
            this.Close2Tray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(135)))));
            this.Close2Tray.Location = new System.Drawing.Point(24, 143);
            this.Close2Tray.Name = "Close2Tray";
            this.Close2Tray.Size = new System.Drawing.Size(229, 26);
            this.Close2Tray.TabIndex = 3;
            this.Close2Tray.Text = "Close to system tray";
            this.Close2Tray.UseVisualStyleBackColor = false;
            this.Close2Tray.CheckedChanged += new System.EventHandler(this.Close2Tray_CheckedChanged_1);
            // 
            // PWBox
            // 
            this.PWBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PWBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.PWBox.Enabled = false;
            this.PWBox.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.PWBox.Location = new System.Drawing.Point(23, 418);
            this.PWBox.Name = "PWBox";
            this.PWBox.Size = new System.Drawing.Size(353, 26);
            this.PWBox.TabIndex = 14;
            this.PWBox.Text = "your;common;zip;passwords";
            this.PWBox.Click += new System.EventHandler(this.PWBox_Enter);
            this.PWBox.Enter += new System.EventHandler(this.PWBox_Enter);
            this.PWBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PWBox_KeyPress);
            this.PWBox.Leave += new System.EventHandler(this.PWBox_Leave);
            this.PWBox.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.PWBox.MouseHover += new System.EventHandler(this.showSettings_MouseHover);
            // 
            // AutoOverwrite
            // 
            this.AutoOverwrite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AutoOverwrite.AutoSize = true;
            this.AutoOverwrite.BackColor = System.Drawing.Color.Transparent;
            this.AutoOverwrite.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.AutoOverwrite.Font = new System.Drawing.Font("Consolas", 13F);
            this.AutoOverwrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(135)))));
            this.AutoOverwrite.Location = new System.Drawing.Point(24, 117);
            this.AutoOverwrite.Name = "AutoOverwrite";
            this.AutoOverwrite.Size = new System.Drawing.Size(209, 26);
            this.AutoOverwrite.TabIndex = 2;
            this.AutoOverwrite.Text = "Overwrite existing";
            this.AutoOverwrite.UseVisualStyleBackColor = false;
            this.AutoOverwrite.CheckedChanged += new System.EventHandler(this.AutoDelete_CheckedChanged);
            this.AutoOverwrite.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.AutoOverwrite.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // AutoDLBox
            // 
            this.AutoDLBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AutoDLBox.AutoSize = true;
            this.AutoDLBox.BackColor = System.Drawing.Color.Transparent;
            this.AutoDLBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.AutoDLBox.Font = new System.Drawing.Font("Consolas", 13F);
            this.AutoDLBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(135)))));
            this.AutoDLBox.Location = new System.Drawing.Point(24, 91);
            this.AutoDLBox.Name = "AutoDLBox";
            this.AutoDLBox.Size = new System.Drawing.Size(159, 26);
            this.AutoDLBox.TabIndex = 1;
            this.AutoDLBox.Text = "Auto download";
            this.AutoDLBox.UseVisualStyleBackColor = false;
            this.AutoDLBox.CheckedChanged += new System.EventHandler(this.AutoDLBox_CheckedChanged);
            this.AutoDLBox.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // RemDL
            // 
            this.RemDL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RemDL.AutoSize = true;
            this.RemDL.BackColor = System.Drawing.Color.Transparent;
            this.RemDL.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.RemDL.Font = new System.Drawing.Font("Consolas", 13F);
            this.RemDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(135)))));
            this.RemDL.Location = new System.Drawing.Point(24, 65);
            this.RemDL.Name = "RemDL";
            this.RemDL.Size = new System.Drawing.Size(169, 26);
            this.RemDL.TabIndex = 0;
            this.RemDL.Text = "Clear Finished";
            this.RemDL.UseVisualStyleBackColor = false;
            this.RemDL.CheckedChanged += new System.EventHandler(this.RemDL_CheckedChanged);
            this.RemDL.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // KA_ALSettingsLabel
            // 
            this.KA_ALSettingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KA_ALSettingsLabel.AutoSize = true;
            this.KA_ALSettingsLabel.Font = new System.Drawing.Font("Karmatic Arcade", 13F);
            this.KA_ALSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.KA_ALSettingsLabel.Location = new System.Drawing.Point(15, 16);
            this.KA_ALSettingsLabel.Name = "KA_ALSettingsLabel";
            this.KA_ALSettingsLabel.Size = new System.Drawing.Size(245, 20);
            this.KA_ALSettingsLabel.TabIndex = 9;
            this.KA_ALSettingsLabel.Text = "All Legit Settings";
            this.KA_ALSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KA_ALSettingsLabel.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.KA_ALSettingsLabel.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // startDownloads
            // 
            this.startDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startDownloads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(143)))));
            this.startDownloads.Cursor = System.Windows.Forms.Cursors.Default;
            this.startDownloads.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.startDownloads.FlatAppearance.BorderSize = 0;
            this.startDownloads.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.startDownloads.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.startDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDownloads.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDownloads.ForeColor = System.Drawing.Color.White;
            this.startDownloads.Location = new System.Drawing.Point(682, 647);
            this.startDownloads.Name = "startDownloads";
            this.startDownloads.Size = new System.Drawing.Size(130, 27);
            this.startDownloads.TabIndex = 1;
            this.startDownloads.Text = "Download Selected";
            this.startDownloads.UseVisualStyleBackColor = false;
            this.startDownloads.Click += new System.EventHandler(this.startDownloads_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(682, 647);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 27);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel Current Job";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CopyLinks
            // 
            this.CopyLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.CopyLinks.Enabled = false;
            this.CopyLinks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CopyLinks.FlatAppearance.BorderSize = 0;
            this.CopyLinks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.CopyLinks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.CopyLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyLinks.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyLinks.ForeColor = System.Drawing.SystemColors.Control;
            this.CopyLinks.Location = new System.Drawing.Point(147, 647);
            this.CopyLinks.Name = "CopyLinks";
            this.CopyLinks.Size = new System.Drawing.Size(113, 27);
            this.CopyLinks.TabIndex = 1;
            this.CopyLinks.Text = "Copy debrid links";
            this.CopyLinks.UseVisualStyleBackColor = false;
            this.CopyLinks.Click += new System.EventHandler(this.CopyLinks_Click);
            // 
            // linksToTextButton
            // 
            this.linksToTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linksToTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.linksToTextButton.Enabled = false;
            this.linksToTextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.linksToTextButton.FlatAppearance.BorderSize = 0;
            this.linksToTextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.linksToTextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.linksToTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linksToTextButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksToTextButton.ForeColor = System.Drawing.SystemColors.Control;
            this.linksToTextButton.Location = new System.Drawing.Point(264, 647);
            this.linksToTextButton.Name = "linksToTextButton";
            this.linksToTextButton.Size = new System.Drawing.Size(123, 27);
            this.linksToTextButton.TabIndex = 1;
            this.linksToTextButton.Text = "Export Debrid links";
            this.linksToTextButton.UseVisualStyleBackColor = false;
            this.linksToTextButton.Click += new System.EventHandler(this.linksToTextButton_Click);
            // 
            // selectTorrent
            // 
            this.selectTorrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectTorrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.selectTorrent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.selectTorrent.FlatAppearance.BorderSize = 0;
            this.selectTorrent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.selectTorrent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.selectTorrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTorrent.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTorrent.ForeColor = System.Drawing.SystemColors.Control;
            this.selectTorrent.Location = new System.Drawing.Point(411, 647);
            this.selectTorrent.Name = "selectTorrent";
            this.selectTorrent.Size = new System.Drawing.Size(97, 27);
            this.selectTorrent.TabIndex = 3;
            this.selectTorrent.Text = ".torrent File";
            this.selectTorrent.UseVisualStyleBackColor = false;
            this.selectTorrent.Click += new System.EventHandler(this.selectTorrent_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.AccessibleDescription = "w";
            this.PasteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.PasteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PasteButton.FlatAppearance.BorderSize = 0;
            this.PasteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.PasteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PasteButton.Location = new System.Drawing.Point(599, 647);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(77, 27);
            this.PasteButton.TabIndex = 2;
            this.PasteButton.Text = "Paste links";
            this.PasteButton.UseVisualStyleBackColor = false;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // bulkAddBtn
            // 
            this.bulkAddBtn.AccessibleDescription = "w";
            this.bulkAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bulkAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.bulkAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bulkAddBtn.FlatAppearance.BorderSize = 0;
            this.bulkAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.bulkAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.bulkAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bulkAddBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkAddBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.bulkAddBtn.Location = new System.Drawing.Point(513, 647);
            this.bulkAddBtn.Name = "bulkAddBtn";
            this.bulkAddBtn.Size = new System.Drawing.Size(81, 27);
            this.bulkAddBtn.TabIndex = 2;
            this.bulkAddBtn.Text = "Bulk Add";
            this.bulkAddBtn.UseVisualStyleBackColor = false;
            this.bulkAddBtn.Click += new System.EventHandler(this.bulkAddBtn_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.ClearButton.Enabled = false;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearButton.Location = new System.Drawing.Point(36, 647);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 27);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Remove Selected";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SetDLDIR
            // 
            this.SetDLDIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.SetDLDIR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SetDLDIR.FlatAppearance.BorderSize = 0;
            this.SetDLDIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.SetDLDIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.SetDLDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDLDIR.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDLDIR.ForeColor = System.Drawing.SystemColors.Control;
            this.SetDLDIR.Location = new System.Drawing.Point(8, 35);
            this.SetDLDIR.Name = "SetDLDIR";
            this.SetDLDIR.Size = new System.Drawing.Size(141, 22);
            this.SetDLDIR.TabIndex = 5;
            this.SetDLDIR.Text = "Change DL Location";
            this.SetDLDIR.UseVisualStyleBackColor = false;
            this.SetDLDIR.Click += new System.EventHandler(this.SetDLDIR_Click);
            this.SetDLDIR.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(821, 724);
            this.Controls.Add(this.settingsP);
            this.Controls.Add(this.HotKeyBtn);
            this.Controls.Add(this.HotKeyBox);
            this.Controls.Add(this.splashPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckAll);
            this.Controls.Add(this.OpenDirBox);
            this.Controls.Add(this.StayOnTopCheckbox);
            this.Controls.Add(this.UncheckAll);
            this.Controls.Add(this.DownloadDir);
            this.Controls.Add(this.SetDLDIR);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.bulkAddBtn);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.selectTorrent);
            this.Controls.Add(this.linksToTextButton);
            this.Controls.Add(this.CopyLinks);
            this.Controls.Add(this.startDownloads);
            this.Controls.Add(this.DownloadingText);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dlProg);
            this.Controls.Add(this.CancelButton);
            this.ForeColor = System.Drawing.Color.NavajoWhite;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(711, 472);
            this.Name = "MainWindow";
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
            this.ApiManPanel.ResumeLayout(false);
            this.ApiManPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DownloadDir;
        private System.Windows.Forms.CheckBox StayOnTopCheckbox;
        private System.Windows.Forms.TextBox HotKeyBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HotKeyBtn;
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
        private System.Windows.Forms.Label KA_tipsHeader;
        private System.Windows.Forms.Label SplashText;
        private System.Windows.Forms.Label KA_changeLog_Label;
        public System.Windows.Forms.Panel splashPanel;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.Button updateNow;
        private System.Windows.Forms.Panel settingsP;
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
        private System.Windows.Forms.Label KA_ALSettingsLabel;
        private System.Windows.Forms.Panel ApiManPanel;
        private System.Windows.Forms.Label KA_APIHeader;
        private System.Windows.Forms.Label KA_APINm;
        private System.Windows.Forms.TextBox ApiNameMan;
        private System.Windows.Forms.Label KA_ApiKeyLbl;
        private System.Windows.Forms.TextBox ApiKeyMan;
        private System.Windows.Forms.Button ShowManualPanel;
        private System.Windows.Forms.Button CancelAPIMan;
        private System.Windows.Forms.Button ApiManConnect;
        private System.Windows.Forms.Button CopyLinks;
        private System.Windows.Forms.Button linksToTextButton;
        private System.Windows.Forms.Button selectTorrent;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Button bulkAddBtn;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SetDLDIR;
        private System.Windows.Forms.Label KA_zip_pwlabel;
    }
}

