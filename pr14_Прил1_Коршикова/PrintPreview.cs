using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr14_Прил1_Коршикова
{
    public partial class PrintPreview : Form
    {
        public PrintPreview()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Rows = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Columns = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Zoom = (double)numericUpDown3.Value / 100;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            printPreviewControl1.UseAntiAlias = checkBox1.Checked;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
