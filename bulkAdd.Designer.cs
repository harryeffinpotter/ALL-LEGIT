namespace ALL_LEGIT
{
    partial class bulkAdd
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
            this.bulkAddBox = new System.Windows.Forms.RichTextBox();
            this.BulkAddConfirm = new System.Windows.Forms.Button();
            this.cancelBulkAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bulkAddBox
            // 
            this.bulkAddBox.AutoWordSelection = true;
            this.bulkAddBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.bulkAddBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bulkAddBox.EnableAutoDragDrop = true;
            this.bulkAddBox.ForeColor = System.Drawing.Color.White;
            this.bulkAddBox.HideSelection = false;
            this.bulkAddBox.Location = new System.Drawing.Point(14, 27);
            this.bulkAddBox.Margin = new System.Windows.Forms.Padding(33);
            this.bulkAddBox.Name = "bulkAddBox";
            this.bulkAddBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.bulkAddBox.ShowSelectionMargin = true;
            this.bulkAddBox.Size = new System.Drawing.Size(630, 383);
            this.bulkAddBox.TabIndex = 4;
            this.bulkAddBox.Text = "Paste multiple magnets/DDL links seperated by NEW LINES to add them all at once!";
            this.bulkAddBox.Click += new System.EventHandler(this.bulkAddBox_Enter);
            this.bulkAddBox.TextChanged += new System.EventHandler(this.bulkAddBox_TextChanged);
            this.bulkAddBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bulkAddBox_KeyDown);
            // 
            // BulkAddConfirm
            // 
            this.BulkAddConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BulkAddConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.BulkAddConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.BulkAddConfirm.FlatAppearance.BorderSize = 0;
            this.BulkAddConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.BulkAddConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.BulkAddConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BulkAddConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulkAddConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.BulkAddConfirm.Location = new System.Drawing.Point(523, 425);
            this.BulkAddConfirm.Name = "BulkAddConfirm";
            this.BulkAddConfirm.Size = new System.Drawing.Size(103, 27);
            this.BulkAddConfirm.TabIndex = 6;
            this.BulkAddConfirm.Text = "Add To Queue";
            this.BulkAddConfirm.UseVisualStyleBackColor = false;
            this.BulkAddConfirm.Click += new System.EventHandler(this.BulkAddConfirm_Click);
            // 
            // cancelBulkAdd
            // 
            this.cancelBulkAdd.AccessibleDescription = "w";
            this.cancelBulkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBulkAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(115)))));
            this.cancelBulkAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cancelBulkAdd.FlatAppearance.BorderSize = 0;
            this.cancelBulkAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.cancelBulkAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.cancelBulkAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBulkAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBulkAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelBulkAdd.Location = new System.Drawing.Point(439, 425);
            this.cancelBulkAdd.Name = "cancelBulkAdd";
            this.cancelBulkAdd.Size = new System.Drawing.Size(81, 27);
            this.cancelBulkAdd.TabIndex = 5;
            this.cancelBulkAdd.Text = "Cancel";
            this.cancelBulkAdd.UseVisualStyleBackColor = false;
            this.cancelBulkAdd.Click += new System.EventHandler(this.cancelBulkAdd_Click);
            // 
            // bulkAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(658, 466);
            this.ControlBox = false;
            this.Controls.Add(this.bulkAddBox);
            this.Controls.Add(this.BulkAddConfirm);
            this.Controls.Add(this.cancelBulkAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "bulkAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox bulkAddBox;
        private System.Windows.Forms.Button BulkAddConfirm;
        private System.Windows.Forms.Button cancelBulkAdd;
    }
}