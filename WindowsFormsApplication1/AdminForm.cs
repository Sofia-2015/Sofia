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
    public partial class AdminForm : Form
    {
        public settings[] setting;
        public levelsettings[] levels;
        public intranet intralevel;
        public internet interlevel;
        public AdminForm()
        {

            InitializeComponent();
            int level_num;
            
            // determine the number of tabs to be added from config file..

            if (settings.getLevels() == "")
            {
                // switch to default 3 levels
                level_num = 3;
            }
            else
            {
                level_num = Int32.Parse(settings.getLevels());
            }


            this.levels = new levelsettings[level_num];
            this.intralevel = new intranet();
            this.interlevel = new internet();
            setting = new settings[level_num];


            for (int ii = 0; ii < level_num -2; ii++)
            {
                setting[ii] = new settings((ii + 1).ToString());
                string title = "Level " + (tabControl1.TabCount + 1).ToString();
                TabPage myTabPage = new TabPage(title);
                this.levels[ii] = new levelsettings();
                setting[ii].getSettings();
                this.levels[ii].syncSettings(setting[ii]);
                myTabPage.Controls.Add(this.levels[ii]);
                tabControl1.TabPages.Add(myTabPage);
            }


            string titleIntra = "Intranet";
            
            TabPage IntraTabPage = new TabPage(titleIntra);
            IntraTabPage.Controls.Add(this.intralevel);
            
            tabControl1.TabPages.Add(IntraTabPage);


            string titleInter = "Internet";

            TabPage InterTabPage = new TabPage(titleInter);
            InterTabPage.Controls.Add(this.interlevel);

            tabControl1.TabPages.Add(InterTabPage);


        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           
=======
            MessageBox.Show("tabs " + tabControl1.TabCount.ToString());
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
            
            for (int i = 0; i < tabControl1.TabCount -2; i++)
            {
                //MessageBox.Show(this.levels[i].app1_name.Text);

                this.setting[i].setval("total_levels", tabControl1.TabCount.ToString());
                this.setting[i].setval("name", this.levels[i].app1_name.Text);
                this.setting[i].setval("maincheck", this.levels[i].app1_check_run.Value.ToString());
<<<<<<< HEAD
               
=======
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
                this.setting[i].setval("downcheck", this.levels[i].app1_check_run_down.Value.ToString());
                this.setting[i].setval("appdownfile", this.levels[i].app1_app_down_file.Text);

                
                this.setting[i].setval("cond1setting", this.levels[i].app1_cond1_stat.Checked.ToString());
                this.setting[i].setval("cond1fname", this.levels[i].app1_cond1_fname.Text);
                this.setting[i].setval("cond1oldersetting", this.levels[i].app1_cond1_older_stat.Checked.ToString());
                this.setting[i].setval("cond1olderhours", this.levels[i].app1_cond1_older_hours.Value.ToString());
                this.setting[i].setval("cond1atleastsetting", this.levels[i].app1_cond1_atleast_stat.Checked.ToString());
                this.setting[i].setval("cond1atleastfiles", this.levels[i].app1_cond1_atleast_files.Value.ToString());
                this.setting[i].setval("cond1atleasthours", this.levels[i].app1_cond1_atleast_hours.Value.ToString());
                this.setting[i].setval("cond1capture", this.levels[i].app1_cond1_capture_stat.Checked.ToString());



                this.setting[i].setval("cond2setting", this.levels[i].app1_cond2_stat.Checked.ToString());
                this.setting[i].setval("cond2fname", this.levels[i].app1_cond2_fname.Text);
                this.setting[i].setval("cond2oldersetting", this.levels[i].app1_cond2_older_stat.Checked.ToString());
                this.setting[i].setval("cond2olderhours", this.levels[i].app1_cond2_older_hours.Value.ToString());
                this.setting[i].setval("cond2atleastsetting", this.levels[i].app1_cond2_atleast_stat.Checked.ToString());
                this.setting[i].setval("cond2atleastfiles", this.levels[i].app1_cond2_atleast_files.Value.ToString());
                this.setting[i].setval("cond2atleasthours", this.levels[i].app1_cond2_atleast_hours.Value.ToString());
                this.setting[i].setval("cond2capture", this.levels[i].app1_cond2_capture_stat.Checked.ToString());



                this.setting[i].setval("cond3setting", this.levels[i].app1_cond3_stat.Checked.ToString());
                this.setting[i].setval("cond3fname", this.levels[i].app1_cond3_fname.Text);
                this.setting[i].setval("cond3oldersetting", this.levels[i].app1_cond3_older_stat.Checked.ToString());
                this.setting[i].setval("cond3olderhours", this.levels[i].app1_cond3_older_hours.Value.ToString());
                this.setting[i].setval("cond3atleastsetting", this.levels[i].app1_cond3_atleast_stat.Checked.ToString());
                this.setting[i].setval("cond3atleastfiles", this.levels[i].app1_cond3_atleast_files.Value.ToString());
                this.setting[i].setval("cond3atleasthours", this.levels[i].app1_cond3_atleast_hours.Value.ToString());
                this.setting[i].setval("cond3capture", this.levels[i].app1_cond3_capture_stat.Checked.ToString());


                this.setting[i].setval("serversetting", this.levels[i].app1_serv_cond_stat.Checked.ToString());
                this.setting[i].setval("servername", this.levels[i].app1_serv_cond_name.Text);
                this.setting[i].setval("servernickname", this.levels[i].app1_serv_cond_nick.Text);
                this.setting[i].setval("serverip", this.levels[i].app1_serv_cond_ip.Text);
<<<<<<< HEAD
                this.setting[i].setval("executable", this.levels[i].textExec.Text);

=======
                
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c


                this.setting[i].savesetting();
            }


<<<<<<< HEAD
            this.Hide();
            frmMainSub newform = new frmMainSub();
            newform.Show();
=======
            this.Close();
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Resize(ref setting, setting.Length + 1);
            Array.Resize(ref levels, levels.Length + 1);
            setting[setting.Length - 1] = new settings((setting.Length).ToString());
            string title = "Level " + (tabControl1.TabCount - 1).ToString();
            TabPage myTabPage = new TabPage(title);
            this.levels[levels.Length - 1] = new levelsettings();
            myTabPage.Controls.Add(this.levels[levels.Length - 1]);
            tabControl1.TabPages.Insert(tabControl1.TabCount - 2, myTabPage);

            // notify settings class for new update..
            for(int i1 = 0; i1 < this.setting.Length -3; i1++)
            {
               
               this.setting[i1].setval("total_levels", tabControl1.TabCount.ToString());
            }
        }





    }
}
