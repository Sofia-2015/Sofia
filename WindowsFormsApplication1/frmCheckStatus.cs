<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
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
    public partial class frmCheckStatus : Form
    {
        private applicationSingletonchk[] apps;
        private settings[] gSettings;
        public frmCheckStatus()
        {
            InitializeComponent();

            panel1.TabIndex = 0;





            // get number of levels
            int levels = Int32.Parse(settings.getLevels());

            apps = new applicationSingletonchk[levels];
            gSettings = new settings[levels - 2];

            // start building components on the form using user control..
            for (int i1 = 0; i1 < gSettings.Length; i1++)
            {

                gSettings[i1] = new settings((i1 + 1).ToString());
                gSettings[i1].getSettings();
                apps[i1] = new applicationSingletonchk();

                apps[i1].levelnum.Text = (i1 + 1).ToString();
                apps[i1].Location = new Point(0, (i1) * 38);
                apps[i1].appnamebtn.Text = gSettings[i1].getval("name");
                apps[i1].frequnc.Text = gSettings[i1].getval("maincheck");
<<<<<<< HEAD
                apps[i1].fname = gSettings[i1].getval("executable");
                apps[i1].this_setting = gSettings[i1];
                
=======

>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
                panel1.Controls.Add(apps[i1]);

                // read application settings..
                gSettings[i1].getSettings();

<<<<<<< HEAD
                apps[i1].runcheckFromLast(gSettings[i1]);
=======
                apps[i1].runcheck(gSettings[i1]);
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c

                // check application status (initial)

            }
            apps[gSettings.Length] = new applicationSingletonchk();
            apps[gSettings.Length].levelnum.Text = (gSettings.Length + 1).ToString();
            apps[gSettings.Length].Location = new Point(0, (gSettings.Length) * 38);
            apps[gSettings.Length].appnamebtn.Text = "Internet";
            

            panel1.Controls.Add(apps[gSettings.Length]);

            apps[gSettings.Length + 1] = new applicationSingletonchk();
            apps[gSettings.Length + 1].levelnum.Text = (gSettings.Length + 2).ToString();
            apps[gSettings.Length + 1].Location = new Point(0, (gSettings.Length + 1) * 38);
            apps[gSettings.Length + 1].appnamebtn.Text = "Intranet";

            panel1.Controls.Add(apps[gSettings.Length + 1]);
<<<<<<< HEAD


=======
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLog fifthForm = new frmLog();
            this.Hide();
            fifthForm.ShowDialog();
            this.Show();
        }
    }
}
