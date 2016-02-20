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
    public partial class frmMainSub : Form
    {
         private applicationSingleton[] apps;
         private settings[] gSettings;
        public frmMainSub()
        {
            InitializeComponent();
            panel1.TabIndex = 0;

            
            
          

            // get number of levels
            int levels = Int32.Parse(settings.getLevels());

            apps = new applicationSingleton[levels];
            gSettings = new settings[levels-2];

            // start building components on the form using user control..
            for (int i1 = 0; i1 < gSettings.Length; i1++)
            {

                gSettings[i1] = new settings((i1+1).ToString());
                gSettings[i1].getSettings();
                apps[i1] = new applicationSingleton();

                apps[i1].levelnum.Text = (i1+1).ToString();
                apps[i1].Location = new Point(0, (i1) * 38);
                apps[i1].appnamebtn.Text = gSettings[i1].getval("name");
<<<<<<< HEAD
                apps[i1].fname = gSettings[i1].getval("executable");
=======
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
               
                panel1.Controls.Add(apps[i1]);
                
                // read application settings..
                gSettings[i1].getSettings();

                apps[i1].runcheck(gSettings[i1]);

                // check application status (initial)

<<<<<<< HEAD
             
               
=======
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
            }
            apps[gSettings.Length] = new applicationSingleton();
            apps[gSettings.Length].levelnum.Text = (gSettings.Length + 1 ).ToString();
            apps[gSettings.Length].Location = new Point(0, (gSettings.Length ) * 38);
            apps[gSettings.Length].appnamebtn.Text = "Internet";

            panel1.Controls.Add(apps[gSettings.Length]);

            apps[gSettings.Length + 1] = new applicationSingleton();
            apps[gSettings.Length + 1].levelnum.Text = (gSettings.Length + 2).ToString();
            apps[gSettings.Length + 1].Location = new Point(0, (gSettings.Length + 1) * 38);
            apps[gSettings.Length + 1].appnamebtn.Text = "Intranet";

            panel1.Controls.Add(apps[gSettings.Length + 1]);

           

        }

        void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!panel1.Focused)
                panel1.Focus();
        }
      

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCheckStatus secondForm = new frmCheckStatus();
            this.Hide();
            secondForm.ShowDialog();
            this.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTraining thirdForm = new frmTraining();
            this.Hide();
            thirdForm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLog fifthForm = new frmLog();
            this.Hide();
            fifthForm.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminForm fourthForm = new AdminForm();
            this.Hide();
            fourthForm.ShowDialog();
<<<<<<< HEAD
           // this.Show();
=======
            this.Show();
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
