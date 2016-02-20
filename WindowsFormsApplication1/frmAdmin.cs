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
    
   
    public partial class frmAdmin : Form
    {
        public settings[] setting;
       
        public frmAdmin()
        {
            InitializeComponent();
            this.setting = new settings[3];
            this.setting[0] = new settings("1");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.setting[0].setval("name", app1_name.Text);
            this.setting[0].savesetting();
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

   

}
