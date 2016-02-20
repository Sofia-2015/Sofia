using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmTraining : Form
    {
        public frmTraining()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\test.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\test-short.mp4");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\test-long.mp4");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\test.docx");
        }
    }
}
