using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALL_LEGIT
{
    public partial class bulkAdd : Form
    {
        public bulkAdd()
        {
            InitializeComponent();
            this.TopMost = true;
        }
        private void bulkAddBox_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void cancelBulkAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            bulkAddBox.Clear();
        }

        private void BulkAddConfirm_Click(object sender, EventArgs e)
        {
            string lineList = "";
            if (bulkAddBox.Text.Trim().Length > 0)
            {
                bool first = true;
                foreach (var line in bulkAddBox.Text.Split('\n'))
                {
                    if (!first && !line.EndsWith("\n"))
                        lineList += "\n";

                    if (first)
                        first = false;


                    lineList += line.Trim();

                }
                Clipboard.Clear();
                Program.form.DoAsyncConversion(lineList);
                bulkAddBox.Clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Add lines to bulk add box or click cancel!");
            }
        }
        private void bulkAddBox_Enter(object sender, EventArgs e)
        {
            if (bulkAddBox.Text.Contains("Paste multiple magnets/DDL links seperated by NEW LINES to add them all at once!"))
            {
                bulkAddBox.Clear();
            }
        }

        private void bulkAddBox_TextChanged(object sender, EventArgs e)
        {
            if (bulkAddBox.Text.EndsWith("\n") || bulkAddBox.Text.Trim().Length == 0 || bulkAddBox.Text.EndsWith("\n\n"))
            {
                return;
            }
            bulkAddBox.AppendText("\n");
            bulkAddBox.SelectionStart = bulkAddBox.Text.Length;
            bulkAddBox.SelectionLength = 0;
            int count = 0;
            foreach (string line in bulkAddBox.Text.Split('\n'))
            {
                if (line.Equals(Clipboard.GetText()))
                {
                    count++;
                }
            }
            if (count > 1)
            {
                string newtext = "";
                newtext = bulkAddBox.Text.Replace(Clipboard.GetText() + "\n", "");
                newtext += $"{Clipboard.GetText()}\n";
                bulkAddBox.Text = newtext;
                bulkAddBox.SelectionStart = bulkAddBox.Text.Length;
                bulkAddBox.SelectionLength = 0;

            }
            
        }
    }
}
