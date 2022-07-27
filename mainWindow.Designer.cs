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
            this.CancelButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.StayOnTopCheckbox = new System.Windows.Forms.CheckBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.HotKeyBox = new System.Windows.Forms.TextBox();
            this.AutoDLBox = new System.Windows.Forms.CheckBox();
            this.AutoOverwrite = new System.Windows.Forms.CheckBox();
            this.ALTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.settingsP = new System.Windows.Forms.Panel();
            this.autoUpdateBox = new System.Windows.Forms.CheckBox();
            this.disableNotiesBox = new System.Windows.Forms.CheckBox();
            this.autoDelZips = new System.Windows.Forms.CheckBox();
            this.extractNested = new System.Windows.Forms.CheckBox();
            this.updateNow = new System.Windows.Forms.Button();
            this.AutoExtract = new System.Windows.Forms.CheckBox();
            this.zipPWLabel = new System.Windows.Forms.Label();
            this.Close2Tray = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemDL = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HotKeyBtn = new System.Windows.Forms.Button();
            this.DownloadingText = new System.Windows.Forms.Label();
            this.startDownloads = new System.Windows.Forms.Button();
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
            this.settingsP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UncheckAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckAll)).BeginInit();
            this.splashPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownloadDir
            // 
            this.DownloadDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.DownloadDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadDir.ForeColor = System.Drawing.Color.White;
            this.DownloadDir.Location = new System.Drawing.Point(12, 5);
            this.DownloadDir.Name = "DownloadDir";
            this.DownloadDir.Size = new System.Drawing.Size(336, 22);
            this.DownloadDir.TabIndex = 5;
            this.DownloadDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DownloadDir_KeyPress);
            this.DownloadDir.Leave += new System.EventHandler(this.DownloadDir_Leave);
            this.DownloadDir.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // SetDLDIR
            // 
            this.SetDLDIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetDLDIR.BackColor = System.Drawing.Color.Transparent;
            this.SetDLDIR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SetDLDIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.SetDLDIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.SetDLDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDLDIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDLDIR.ForeColor = System.Drawing.SystemColors.Control;
            this.SetDLDIR.Location = new System.Drawing.Point(234, 33);
            this.SetDLDIR.Name = "SetDLDIR";
            this.SetDLDIR.Size = new System.Drawing.Size(114, 24);
            this.SetDLDIR.TabIndex = 6;
            this.SetDLDIR.Text = "Set Output Dir";
            this.SetDLDIR.UseVisualStyleBackColor = false;
            this.SetDLDIR.Click += new System.EventHandler(this.SetDLDIR_Click);
            this.SetDLDIR.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CancelButton.ForeColor = System.Drawing.Color.Moccasin;
            this.CancelButton.Location = new System.Drawing.Point(655, 644);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(154, 25);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel Current Job";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.AccessibleDescription = "w";
            this.PasteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasteButton.BackColor = System.Drawing.Color.Transparent;
            this.PasteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PasteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.PasteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PasteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PasteButton.Location = new System.Drawing.Point(751, 615);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(58, 25);
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
            this.StayOnTopCheckbox.Location = new System.Drawing.Point(580, 10);
            this.StayOnTopCheckbox.Name = "StayOnTopCheckbox";
            this.StayOnTopCheckbox.Size = new System.Drawing.Size(127, 23);
            this.StayOnTopCheckbox.TabIndex = 8;
            this.StayOnTopCheckbox.Text = "Keep on top";
            this.StayOnTopCheckbox.UseVisualStyleBackColor = false;
            this.StayOnTopCheckbox.CheckedChanged += new System.EventHandler(this.StayOnTopCheckbox_CheckedChanged_1);
            this.StayOnTopCheckbox.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // PWBox
            // 
            this.PWBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.PWBox.Enabled = false;
            this.PWBox.ForeColor = System.Drawing.Color.White;
            this.PWBox.Location = new System.Drawing.Point(46, 379);
            this.PWBox.Name = "PWBox";
            this.PWBox.Size = new System.Drawing.Size(414, 26);
            this.PWBox.TabIndex = 4;
            this.PWBox.Text = "Your;Commonly;Used;Zip;passwords";
            this.PWBox.Click += new System.EventHandler(this.PWBox_Enter);
            this.PWBox.Enter += new System.EventHandler(this.PWBox_Enter);
            this.PWBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PWBox_KeyPress);
            this.PWBox.Leave += new System.EventHandler(this.PWBox_Leave);
            this.PWBox.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.PWBox.MouseHover += new System.EventHandler(this.showSettings_MouseHover);
            // 
            // HotKeyBox
            // 
            this.HotKeyBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.HotKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HotKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.HotKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeyBox.ForeColor = System.Drawing.Color.White;
            this.HotKeyBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.HotKeyBox.Location = new System.Drawing.Point(354, 5);
            this.HotKeyBox.Name = "HotKeyBox";
            this.HotKeyBox.ReadOnly = true;
            this.HotKeyBox.Size = new System.Drawing.Size(220, 22);
            this.HotKeyBox.TabIndex = 7;
            this.HotKeyBox.TabStop = false;
            this.HotKeyBox.Click += new System.EventHandler(this.HotKeyBox_Click);
            this.HotKeyBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotKeyBox_MouseClick);
            this.HotKeyBox.TextChanged += new System.EventHandler(this.HotKeyBox_TextChanged);
            this.HotKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyBox_KeyDown);
            this.HotKeyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HotKeyBox_KeyPress);
            this.HotKeyBox.Leave += new System.EventHandler(this.HotKeyBox_Leave);
            this.HotKeyBox.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // AutoDLBox
            // 
            this.AutoDLBox.AutoSize = true;
            this.AutoDLBox.BackColor = System.Drawing.Color.Transparent;
            this.AutoDLBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoDLBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.AutoDLBox.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.AutoDLBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.AutoDLBox.Location = new System.Drawing.Point(45, 91);
            this.AutoDLBox.Name = "AutoDLBox";
            this.AutoDLBox.Size = new System.Drawing.Size(417, 26);
            this.AutoDLBox.TabIndex = 0;
            this.AutoDLBox.Text = "Auto download";
            this.AutoDLBox.UseVisualStyleBackColor = false;
            this.AutoDLBox.CheckedChanged += new System.EventHandler(this.AutoDLBox_CheckedChanged);
            this.AutoDLBox.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // AutoOverwrite
            // 
            this.AutoOverwrite.AutoSize = true;
            this.AutoOverwrite.BackColor = System.Drawing.Color.Transparent;
            this.AutoOverwrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoOverwrite.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.AutoOverwrite.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.AutoOverwrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.AutoOverwrite.Location = new System.Drawing.Point(45, 117);
            this.AutoOverwrite.Name = "AutoOverwrite";
            this.AutoOverwrite.Size = new System.Drawing.Size(417, 26);
            this.AutoOverwrite.TabIndex = 0;
            this.AutoOverwrite.Text = "Overwrite existing";
            this.AutoOverwrite.UseVisualStyleBackColor = false;
            this.AutoOverwrite.CheckedChanged += new System.EventHandler(this.AutoDelete_CheckedChanged);
            this.AutoOverwrite.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.AutoOverwrite.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
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
            // settingsP
            // 
            this.settingsP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.settingsP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsP.Controls.Add(this.autoUpdateBox);
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
            this.settingsP.Location = new System.Drawing.Point(320, 5);
            this.settingsP.Name = "settingsP";
            this.settingsP.Padding = new System.Windows.Forms.Padding(45, 65, 45, 45);
            this.settingsP.Size = new System.Drawing.Size(511, 433);
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
            this.autoUpdateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.autoUpdateBox.Location = new System.Drawing.Point(45, 273);
            this.autoUpdateBox.Name = "autoUpdateBox";
            this.autoUpdateBox.Size = new System.Drawing.Size(417, 26);
            this.autoUpdateBox.TabIndex = 17;
            this.autoUpdateBox.Text = "Automatically update on launch";
            this.autoUpdateBox.UseVisualStyleBackColor = false;
            this.autoUpdateBox.CheckedChanged += new System.EventHandler(this.autoUpdateBox_CheckedChanged);
            // 
            // disableNotiesBox
            // 
            this.disableNotiesBox.AutoSize = true;
            this.disableNotiesBox.BackColor = System.Drawing.Color.Transparent;
            this.disableNotiesBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.disableNotiesBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.disableNotiesBox.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.disableNotiesBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.disableNotiesBox.Location = new System.Drawing.Point(45, 247);
            this.disableNotiesBox.Name = "disableNotiesBox";
            this.disableNotiesBox.Size = new System.Drawing.Size(417, 26);
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
            this.autoDelZips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.autoDelZips.Location = new System.Drawing.Point(45, 221);
            this.autoDelZips.Name = "autoDelZips";
            this.autoDelZips.Size = new System.Drawing.Size(417, 26);
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
            this.extractNested.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.extractNested.Location = new System.Drawing.Point(45, 195);
            this.extractNested.Name = "extractNested";
            this.extractNested.Size = new System.Drawing.Size(417, 26);
            this.extractNested.TabIndex = 14;
            this.extractNested.Text = "Extract nested archives";
            this.extractNested.UseVisualStyleBackColor = false;
            this.extractNested.CheckedChanged += new System.EventHandler(this.extractNested_CheckedChanged);
            // 
            // updateNow
            // 
            this.updateNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateNow.BackColor = System.Drawing.Color.Transparent;
            this.updateNow.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.updateNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.updateNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.updateNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.updateNow.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.updateNow.Location = new System.Drawing.Point(45, 304);
            this.updateNow.Name = "updateNow";
            this.updateNow.Size = new System.Drawing.Size(321, 30);
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
            this.AutoExtract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.AutoExtract.Location = new System.Drawing.Point(45, 169);
            this.AutoExtract.Name = "AutoExtract";
            this.AutoExtract.Size = new System.Drawing.Size(417, 26);
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
            this.zipPWLabel.Location = new System.Drawing.Point(60, 350);
            this.zipPWLabel.Name = "zipPWLabel";
            this.zipPWLabel.Size = new System.Drawing.Size(390, 22);
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
            this.Close2Tray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.Close2Tray.Location = new System.Drawing.Point(45, 143);
            this.Close2Tray.Name = "Close2Tray";
            this.Close2Tray.Size = new System.Drawing.Size(417, 26);
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
            this.label1.Location = new System.Drawing.Point(118, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "All Legit Settings\r\n(These save automatically)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.label1.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // RemDL
            // 
            this.RemDL.AutoSize = true;
            this.RemDL.BackColor = System.Drawing.Color.Transparent;
            this.RemDL.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemDL.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlText;
            this.RemDL.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.RemDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.RemDL.Location = new System.Drawing.Point(45, 65);
            this.RemDL.Name = "RemDL";
            this.RemDL.Size = new System.Drawing.Size(417, 26);
            this.RemDL.TabIndex = 6;
            this.RemDL.Text = "Clear Finished";
            this.RemDL.UseVisualStyleBackColor = false;
            this.RemDL.CheckedChanged += new System.EventHandler(this.RemDL_CheckedChanged);
            this.RemDL.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(773, 12);
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
            this.HotKeyBtn.BackColor = System.Drawing.Color.Transparent;
            this.HotKeyBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HotKeyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.HotKeyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.HotKeyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotKeyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeyBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.HotKeyBtn.Location = new System.Drawing.Point(469, 33);
            this.HotKeyBtn.Name = "HotKeyBtn";
            this.HotKeyBtn.Size = new System.Drawing.Size(105, 24);
            this.HotKeyBtn.TabIndex = 7;
            this.HotKeyBtn.Text = "Set Shortcut";
            this.HotKeyBtn.UseVisualStyleBackColor = false;
            this.HotKeyBtn.Click += new System.EventHandler(this.HotKeyBtn_Click);
            // 
            // DownloadingText
            // 
            this.DownloadingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadingText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.DownloadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(191)))));
            this.DownloadingText.Location = new System.Drawing.Point(177, 645);
            this.DownloadingText.Name = "DownloadingText";
            this.DownloadingText.Size = new System.Drawing.Size(472, 24);
            this.DownloadingText.TabIndex = 12;
            this.DownloadingText.Text = "...";
            this.DownloadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.startDownloads.Location = new System.Drawing.Point(655, 644);
            this.startDownloads.Name = "startDownloads";
            this.startDownloads.Size = new System.Drawing.Size(154, 25);
            this.startDownloads.TabIndex = 1;
            this.startDownloads.Text = "Download Selected";
            this.startDownloads.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startDownloads.UseVisualStyleBackColor = false;
            this.startDownloads.Click += new System.EventHandler(this.startDownloads_Click);
            // 
            // CopyLinks
            // 
            this.CopyLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyLinks.BackColor = System.Drawing.Color.Transparent;
            this.CopyLinks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CopyLinks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.CopyLinks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.CopyLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CopyLinks.ForeColor = System.Drawing.SystemColors.Control;
            this.CopyLinks.Location = new System.Drawing.Point(655, 615);
            this.CopyLinks.Name = "CopyLinks";
            this.CopyLinks.Size = new System.Drawing.Size(93, 25);
            this.CopyLinks.TabIndex = 2;
            this.CopyLinks.Text = "Copy Links";
            this.CopyLinks.UseVisualStyleBackColor = false;
            this.CopyLinks.Click += new System.EventHandler(this.CopyLinks_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearButton.Location = new System.Drawing.Point(41, 615);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(130, 25);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Delete Selected";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // dlProg
            // 
            this.dlProg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.dlProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dlProg.Location = new System.Drawing.Point(177, 615);
            this.dlProg.Name = "dlProg";
            this.dlProg.Size = new System.Drawing.Size(472, 25);
            this.dlProg.TabIndex = 9;
            // 
            // UncheckAll
            // 
            this.UncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UncheckAll.Image = ((System.Drawing.Image)(resources.GetObject("UncheckAll.Image")));
            this.UncheckAll.Location = new System.Drawing.Point(12, 615);
            this.UncheckAll.Name = "UncheckAll";
            this.UncheckAll.Size = new System.Drawing.Size(23, 25);
            this.UncheckAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UncheckAll.TabIndex = 16;
            this.UncheckAll.TabStop = false;
            this.UncheckAll.Click += new System.EventHandler(this.UncheckAll_Click);
            // 
            // CheckAll
            // 
            this.CheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckAll.Image = ((System.Drawing.Image)(resources.GetObject("CheckAll.Image")));
            this.CheckAll.Location = new System.Drawing.Point(12, 615);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(23, 25);
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
            this.OpenDirBox.Location = new System.Drawing.Point(580, 35);
            this.OpenDirBox.Name = "OpenDirBox";
            this.OpenDirBox.Size = new System.Drawing.Size(190, 23);
            this.OpenDirBox.TabIndex = 8;
            this.OpenDirBox.Text = "Open dir when done";
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
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
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
            this.listView1.Location = new System.Drawing.Point(12, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(797, 543);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            this.listView1.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // splashPanel
            // 
            this.splashPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.splashPanel.Controls.Add(this.tipsText);
            this.splashPanel.Controls.Add(this.tipsHeader);
            this.splashPanel.Controls.Add(this.SplashText);
            this.splashPanel.Controls.Add(this.changeLog);
            this.splashPanel.Location = new System.Drawing.Point(45, 101);
            this.splashPanel.Name = "splashPanel";
            this.splashPanel.Size = new System.Drawing.Size(731, 503);
            this.splashPanel.TabIndex = 17;
            this.splashPanel.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // tipsText
            // 
            this.tipsText.AutoSize = true;
            this.tipsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.tipsText.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipsText.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.tipsText.Location = new System.Drawing.Point(0, 180);
            this.tipsText.Name = "tipsText";
            this.tipsText.Size = new System.Drawing.Size(273, 140);
            this.tipsText.TabIndex = 15;
            this.tipsText.Text = "All Legit v1.0.0\r\nby HarryEffinPottter/YSG\r\n\r\nGlobal hot key works everywhere,\r\ne" +
    "ven when app is minimized.\r\n\r\nCTRL+V or Paste button while in app.";
            this.tipsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tipsHeader
            // 
            this.tipsHeader.AutoSize = true;
            this.tipsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.tipsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipsHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tipsHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.tipsHeader.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.tipsHeader.Location = new System.Drawing.Point(0, 160);
            this.tipsHeader.Name = "tipsHeader";
            this.tipsHeader.Size = new System.Drawing.Size(47, 20);
            this.tipsHeader.TabIndex = 14;
            this.tipsHeader.Text = "Tips:";
            this.tipsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SplashText
            // 
            this.SplashText.AutoSize = true;
            this.SplashText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.SplashText.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplashText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SplashText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashText.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.SplashText.Location = new System.Drawing.Point(0, 20);
            this.SplashText.Name = "SplashText";
            this.SplashText.Size = new System.Drawing.Size(273, 140);
            this.SplashText.TabIndex = 13;
            this.SplashText.Text = "All Legit v1.0.0\r\nby HarryEffinPottter/YSG\r\n\r\nGlobal hot key works everywhere,\r\ne" +
    "ven when app is minimized.\r\n\r\nCTRL+V or Paste button while in app.";
            // 
            // changeLog
            // 
            this.changeLog.AutoSize = true;
            this.changeLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.changeLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLog.ForeColor = System.Drawing.Color.PaleGreen;
            this.changeLog.Location = new System.Drawing.Point(0, 0);
            this.changeLog.Name = "changeLog";
            this.changeLog.Size = new System.Drawing.Size(105, 20);
            this.changeLog.TabIndex = 12;
            this.changeLog.Text = "Change log:\r\n";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(821, 679);
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
            this.Controls.Add(this.CopyLinks);
            this.Controls.Add(this.startDownloads);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DownloadingText);
            this.Controls.Add(this.settingsP);
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
            this.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            this.MouseLeave += new System.EventHandler(this.settingsP_MouseLeave);
            this.Resize += new System.EventHandler(this.MainWindow_Resize_1);
            this.settingsP.ResumeLayout(false);
            this.settingsP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UncheckAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckAll)).EndInit();
            this.splashPanel.ResumeLayout(false);
            this.splashPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DownloadDir;
        private System.Windows.Forms.Button SetDLDIR;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.CheckBox StayOnTopCheckbox;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.TextBox HotKeyBox;
        private System.Windows.Forms.CheckBox AutoDLBox;
        private System.Windows.Forms.CheckBox AutoOverwrite;
        private System.Windows.Forms.Panel settingsP;
        private System.Windows.Forms.CheckBox RemDL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HotKeyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startDownloads;
        private System.Windows.Forms.Button CopyLinks;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ProgressBar dlProg;
        private System.Windows.Forms.CheckBox AutoExtract;
        private System.Windows.Forms.CheckBox Close2Tray;
        private System.Windows.Forms.PictureBox UncheckAll;
        private System.Windows.Forms.PictureBox CheckAll;
        public new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label zipPWLabel;
        public System.Windows.Forms.Label DownloadingText;
        private System.Windows.Forms.CheckBox OpenDirBox;
        public System.Windows.Forms.NotifyIcon ALTrayIcon;
        private System.Windows.Forms.Button updateNow;
        private System.Windows.Forms.CheckBox autoUpdateBox;
        private System.Windows.Forms.CheckBox disableNotiesBox;
        private System.Windows.Forms.CheckBox autoDelZips;
        private System.Windows.Forms.CheckBox extractNested;
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
    }
}

