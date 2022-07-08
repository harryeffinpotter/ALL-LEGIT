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
            this.DownloadDir = new System.Windows.Forms.TextBox();
            this.SetDLDIR = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.StayOnTopCheckbox = new System.Windows.Forms.CheckBox();
            this.SplashText = new System.Windows.Forms.Label();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.HotKeyBox = new System.Windows.Forms.TextBox();
            this.AutoDLBox = new System.Windows.Forms.CheckBox();
            this.AutoOverwrite = new System.Windows.Forms.CheckBox();
            this.ALTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.settingsP = new System.Windows.Forms.Panel();
            this.autoDelZips = new System.Windows.Forms.CheckBox();
            this.AutoExtract = new System.Windows.Forms.CheckBox();
            this.zipPWLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RemDL = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HotKeyBtn = new System.Windows.Forms.Button();
            this.DownloadingText = new System.Windows.Forms.Label();
            this.startDownloads = new System.Windows.Forms.Button();
            this.CopyLinks = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.dlProg = new System.Windows.Forms.ProgressBar();
            this.Close2Tray = new System.Windows.Forms.CheckBox();
            this.UncheckAll = new System.Windows.Forms.PictureBox();
            this.CheckAll = new System.Windows.Forms.PictureBox();
            this.settingsP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UncheckAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckAll)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.listView1.Location = new System.Drawing.Point(12, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(797, 550);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
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
            // DownloadDir
            // 
            this.DownloadDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.DownloadDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadDir.ForeColor = System.Drawing.Color.White;
            this.DownloadDir.Location = new System.Drawing.Point(12, 5);
            this.DownloadDir.Name = "DownloadDir";
            this.DownloadDir.Size = new System.Drawing.Size(324, 22);
            this.DownloadDir.TabIndex = 7;
            this.DownloadDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DownloadDir_KeyPress);
            this.DownloadDir.Leave += new System.EventHandler(this.DownloadDir_Leave);
            this.DownloadDir.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // SetDLDIR
            // 
            this.SetDLDIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetDLDIR.BackColor = System.Drawing.Color.Transparent;
            this.SetDLDIR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SetDLDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDLDIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDLDIR.ForeColor = System.Drawing.Color.White;
            this.SetDLDIR.Location = new System.Drawing.Point(222, 29);
            this.SetDLDIR.Name = "SetDLDIR";
            this.SetDLDIR.Size = new System.Drawing.Size(114, 24);
            this.SetDLDIR.TabIndex = 3;
            this.SetDLDIR.Text = "Set Output Dir";
            this.SetDLDIR.UseVisualStyleBackColor = false;
            this.SetDLDIR.Click += new System.EventHandler(this.SetDLDIR_Click);
            this.SetDLDIR.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(649, 640);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(160, 25);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
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
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.PasteButton.ForeColor = System.Drawing.Color.White;
            this.PasteButton.Location = new System.Drawing.Point(748, 612);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(61, 25);
            this.PasteButton.TabIndex = 2;
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
            this.StayOnTopCheckbox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.StayOnTopCheckbox.ForeColor = System.Drawing.Color.White;
            this.StayOnTopCheckbox.Location = new System.Drawing.Point(575, 7);
            this.StayOnTopCheckbox.Name = "StayOnTopCheckbox";
            this.StayOnTopCheckbox.Size = new System.Drawing.Size(115, 21);
            this.StayOnTopCheckbox.TabIndex = 1;
            this.StayOnTopCheckbox.Text = "Keep on top";
            this.StayOnTopCheckbox.UseVisualStyleBackColor = false;
            this.StayOnTopCheckbox.CheckedChanged += new System.EventHandler(this.StayOnTopCheckbox_CheckedChanged_1);
            this.StayOnTopCheckbox.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // SplashText
            // 
            this.SplashText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplashText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.SplashText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashText.ForeColor = System.Drawing.Color.White;
            this.SplashText.Location = new System.Drawing.Point(104, 196);
            this.SplashText.Name = "SplashText";
            this.SplashText.Size = new System.Drawing.Size(613, 286);
            this.SplashText.TabIndex = 4;
            this.SplashText.Text = "All Legit v1.0.0\r\nby HarryEffinPottter/YSG\r\n\r\nGlobal hot key works everywhere,\r\ne" +
    "ven when app is minimized.\r\n\r\nCTRL+V or Paste button while in app.";
            this.SplashText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SplashText.Click += new System.EventHandler(this.DOwnlol);
            this.SplashText.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // PWBox
            // 
            this.PWBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.PWBox.Enabled = false;
            this.PWBox.ForeColor = System.Drawing.Color.White;
            this.PWBox.Location = new System.Drawing.Point(46, 261);
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
            this.HotKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HotKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.HotKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeyBox.ForeColor = System.Drawing.Color.White;
            this.HotKeyBox.Location = new System.Drawing.Point(342, 5);
            this.HotKeyBox.Name = "HotKeyBox";
            this.HotKeyBox.Size = new System.Drawing.Size(220, 22);
            this.HotKeyBox.TabIndex = 7;
            this.HotKeyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DownloadDir_KeyPress);
            this.HotKeyBox.Leave += new System.EventHandler(this.DownloadDir_Leave);
            this.HotKeyBox.MouseEnter += new System.EventHandler(this.settingsP_MouseLeave);
            // 
            // AutoDLBox
            // 
            this.AutoDLBox.AutoSize = true;
            this.AutoDLBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.AutoDLBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoDLBox.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.AutoDLBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.AutoDLBox.Location = new System.Drawing.Point(45, 101);
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
            this.AutoOverwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.AutoOverwrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoOverwrite.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.AutoOverwrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.AutoOverwrite.Location = new System.Drawing.Point(45, 127);
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
            this.ALTrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ALTrayIcon_MouseClick);
            this.ALTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ALTrayIcon_MouseDoubleClick_1);
            // 
            // settingsP
            // 
            this.settingsP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.settingsP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsP.Controls.Add(this.autoDelZips);
            this.settingsP.Controls.Add(this.AutoExtract);
            this.settingsP.Controls.Add(this.zipPWLabel);
            this.settingsP.Controls.Add(this.label1);
            this.settingsP.Controls.Add(this.PWBox);
            this.settingsP.Controls.Add(this.AutoOverwrite);
            this.settingsP.Controls.Add(this.AutoDLBox);
            this.settingsP.Controls.Add(this.RemDL);
            this.settingsP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsP.Location = new System.Drawing.Point(302, 5);
            this.settingsP.Name = "settingsP";
            this.settingsP.Padding = new System.Windows.Forms.Padding(45, 65, 45, 45);
            this.settingsP.Size = new System.Drawing.Size(511, 326);
            this.settingsP.TabIndex = 13;
            this.settingsP.Visible = false;
            this.settingsP.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.settingsP.MouseHover += new System.EventHandler(this.showSettings_MouseHover);
            // 
            // autoDelZips
            // 
            this.autoDelZips.AutoSize = true;
            this.autoDelZips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.autoDelZips.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoDelZips.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.autoDelZips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.autoDelZips.Location = new System.Drawing.Point(45, 179);
            this.autoDelZips.Name = "autoDelZips";
            this.autoDelZips.Size = new System.Drawing.Size(417, 26);
            this.autoDelZips.TabIndex = 11;
            this.autoDelZips.Text = "Delete extracted archives";
            this.autoDelZips.UseVisualStyleBackColor = false;
            this.autoDelZips.CheckedChanged += new System.EventHandler(this.autoDelZips_CheckedChanged_1);
            this.autoDelZips.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // AutoExtract
            // 
            this.AutoExtract.AutoSize = true;
            this.AutoExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.AutoExtract.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoExtract.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.AutoExtract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.AutoExtract.Location = new System.Drawing.Point(45, 153);
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
            this.zipPWLabel.Location = new System.Drawing.Point(58, 235);
            this.zipPWLabel.Name = "zipPWLabel";
            this.zipPWLabel.Size = new System.Drawing.Size(390, 22);
            this.zipPWLabel.TabIndex = 9;
            this.zipPWLabel.Text = "Archive passwords - Use ; to separate.";
            this.zipPWLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zipPWLabel.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.zipPWLabel.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(117, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "All Legit Settings\r\n(These save automatically).";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.label1.MouseHover += new System.EventHandler(this.settingsP_MouseHover);
            // 
            // RemDL
            // 
            this.RemDL.AutoSize = true;
            this.RemDL.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemDL.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.RemDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.RemDL.Location = new System.Drawing.Point(45, 65);
            this.RemDL.Name = "RemDL";
            this.RemDL.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.RemDL.Size = new System.Drawing.Size(417, 36);
            this.RemDL.TabIndex = 6;
            this.RemDL.Text = "Clear Finished";
            this.RemDL.UseVisualStyleBackColor = true;
            this.RemDL.CheckedChanged += new System.EventHandler(this.RemDL_CheckedChanged);
            this.RemDL.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(773, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.showSettings_MouseEnter);
            this.pictureBox1.MouseHover += new System.EventHandler(this.showSettings_MouseHover);
            // 
            // HotKeyBtn
            // 
            this.HotKeyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HotKeyBtn.BackColor = System.Drawing.Color.Transparent;
            this.HotKeyBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HotKeyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotKeyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeyBtn.ForeColor = System.Drawing.Color.White;
            this.HotKeyBtn.Location = new System.Drawing.Point(465, 29);
            this.HotKeyBtn.Name = "HotKeyBtn";
            this.HotKeyBtn.Size = new System.Drawing.Size(97, 24);
            this.HotKeyBtn.TabIndex = 3;
            this.HotKeyBtn.Text = "Set Hotkey";
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
            this.DownloadingText.Location = new System.Drawing.Point(179, 640);
            this.DownloadingText.Name = "DownloadingText";
            this.DownloadingText.Size = new System.Drawing.Size(464, 24);
            this.DownloadingText.TabIndex = 12;
            this.DownloadingText.Text = "...";
            this.DownloadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startDownloads
            // 
            this.startDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startDownloads.Cursor = System.Windows.Forms.Cursors.Default;
            this.startDownloads.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.startDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDownloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDownloads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startDownloads.Location = new System.Drawing.Point(649, 640);
            this.startDownloads.Name = "startDownloads";
            this.startDownloads.Size = new System.Drawing.Size(160, 25);
            this.startDownloads.TabIndex = 5;
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
            this.CopyLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CopyLinks.ForeColor = System.Drawing.Color.White;
            this.CopyLinks.Location = new System.Drawing.Point(649, 612);
            this.CopyLinks.Name = "CopyLinks";
            this.CopyLinks.Size = new System.Drawing.Size(96, 25);
            this.CopyLinks.TabIndex = 10;
            this.CopyLinks.Text = "Copy Links";
            this.CopyLinks.UseVisualStyleBackColor = false;
            this.CopyLinks.Click += new System.EventHandler(this.CopyLinks_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(44, 612);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(130, 25);
            this.ClearButton.TabIndex = 8;
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
            this.dlProg.Location = new System.Drawing.Point(179, 612);
            this.dlProg.Name = "dlProg";
            this.dlProg.Size = new System.Drawing.Size(464, 25);
            this.dlProg.TabIndex = 9;
            // 
            // Close2Tray
            // 
            this.Close2Tray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close2Tray.AutoSize = true;
            this.Close2Tray.BackColor = System.Drawing.Color.Transparent;
            this.Close2Tray.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Close2Tray.ForeColor = System.Drawing.Color.White;
            this.Close2Tray.Location = new System.Drawing.Point(575, 30);
            this.Close2Tray.Name = "Close2Tray";
            this.Close2Tray.Size = new System.Drawing.Size(187, 21);
            this.Close2Tray.TabIndex = 15;
            this.Close2Tray.Text = "Close to system tray";
            this.Close2Tray.UseVisualStyleBackColor = false;
            this.Close2Tray.CheckedChanged += new System.EventHandler(this.Close2Tray_CheckedChanged_1);
            // 
            // UncheckAll
            // 
            this.UncheckAll.Image = ((System.Drawing.Image)(resources.GetObject("UncheckAll.Image")));
            this.UncheckAll.Location = new System.Drawing.Point(13, 611);
            this.UncheckAll.Name = "UncheckAll";
            this.UncheckAll.Size = new System.Drawing.Size(26, 27);
            this.UncheckAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UncheckAll.TabIndex = 16;
            this.UncheckAll.TabStop = false;
            this.UncheckAll.Click += new System.EventHandler(this.UncheckAll_Click);
            // 
            // CheckAll
            // 
            this.CheckAll.Image = ((System.Drawing.Image)(resources.GetObject("CheckAll.Image")));
            this.CheckAll.Location = new System.Drawing.Point(13, 611);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(26, 27);
            this.CheckAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckAll.TabIndex = 16;
            this.CheckAll.TabStop = false;
            this.CheckAll.Visible = false;
            this.CheckAll.Click += new System.EventHandler(this.CheckAll_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(821, 671);
            this.Controls.Add(this.CheckAll);
            this.Controls.Add(this.UncheckAll);
            this.Controls.Add(this.Close2Tray);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StayOnTopCheckbox);
            this.Controls.Add(this.SplashText);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.TextBox DownloadDir;
        private System.Windows.Forms.Button SetDLDIR;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.CheckBox StayOnTopCheckbox;
        private System.Windows.Forms.Label SplashText;
        private System.Windows.Forms.TextBox PWBox;
        private new System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.TextBox HotKeyBox;
        private System.Windows.Forms.CheckBox AutoDLBox;
        private System.Windows.Forms.CheckBox AutoOverwrite;
        private System.Windows.Forms.Panel settingsP;
        private System.Windows.Forms.CheckBox RemDL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HotKeyBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label DownloadingText;
        private System.Windows.Forms.Button startDownloads;
        private System.Windows.Forms.Button CopyLinks;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ProgressBar dlProg;
        private System.Windows.Forms.CheckBox autoDelZips;
        private System.Windows.Forms.CheckBox AutoExtract;
        private System.Windows.Forms.Label zipPWLabel;
        private System.Windows.Forms.CheckBox Close2Tray;
        public System.Windows.Forms.NotifyIcon ALTrayIcon;
        private System.Windows.Forms.PictureBox UncheckAll;
        private System.Windows.Forms.PictureBox CheckAll;
        public System.Windows.Forms.Button CancelButton;
    }
}

