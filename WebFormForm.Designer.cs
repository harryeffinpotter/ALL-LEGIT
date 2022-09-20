namespace ALL_LEGIT
{
    partial class WebFormForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebFormForm));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.splashCover = new System.Windows.Forms.Label();
            this.dlcGIF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dlcGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-5, -2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(996, 720);
            this.webBrowser1.TabIndex = 14;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(435, 715);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 15;
            // 
            // splashCover
            // 
            this.splashCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.splashCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.75F);
            this.splashCover.ForeColor = System.Drawing.SystemColors.Control;
            this.splashCover.Location = new System.Drawing.Point(-4, -2);
            this.splashCover.Name = "splashCover";
            this.splashCover.Size = new System.Drawing.Size(995, 388);
            this.splashCover.TabIndex = 17;
            this.splashCover.Text = "\r\nPlease wait...";
            this.splashCover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.splashCover.Visible = false;
            // 
            // dlcGIF
            // 
            this.dlcGIF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.dlcGIF.Enabled = false;
            this.dlcGIF.Image = ((System.Drawing.Image)(resources.GetObject("dlcGIF.Image")));
            this.dlcGIF.InitialImage = null;
            this.dlcGIF.Location = new System.Drawing.Point(-5, 381);
            this.dlcGIF.Name = "dlcGIF";
            this.dlcGIF.Size = new System.Drawing.Size(995, 332);
            this.dlcGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dlcGIF.TabIndex = 18;
            this.dlcGIF.TabStop = false;
            this.dlcGIF.Visible = false;
            this.dlcGIF.WaitOnLoad = true;
            // 
            // WebFormForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(988, 711);
            this.Controls.Add(this.dlcGIF);
            this.Controls.Add(this.splashCover);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebFormForm";
            this.Text = "All Legit! Captcha Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebFormForm_FormClosing);
            this.Load += new System.EventHandler(this.WebFormForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlcGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label splashCover;
        private System.Windows.Forms.PictureBox dlcGIF;
    }
}