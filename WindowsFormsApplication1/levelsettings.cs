using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class levelsettings : UserControl
    {
        public levelsettings()
        {
            InitializeComponent();
        }

        private void levelsettings_Load(object sender, EventArgs e)
        {

        }

        public void syncSettings(settings syncSetting)
        {
            this.app1_name.Text = syncSetting.getval("name");
            this.app1_check_run.Value = Int32.Parse(syncSetting.getval("maincheck"));
            this.app1_check_run_down.Value = Int32.Parse(syncSetting.getval("downcheck"));
            this.app1_app_down_file.Text = syncSetting.getval("appdownfile");

            this.app1_cond1_stat.Checked = Boolean.Parse(syncSetting.getval("cond1setting"));
            this.app1_cond1_fname.Text = syncSetting.getval("cond1fname");
            this.app1_cond1_older_stat.Checked = Boolean.Parse(syncSetting.getval("cond1oldersetting"));
            this.app1_cond1_older_hours.Value = Int32.Parse(syncSetting.getval("cond1olderhours"));
            this.app1_cond1_atleast_stat.Checked = Boolean.Parse(syncSetting.getval("cond1atleastsetting"));
            this.app1_cond1_atleast_files.Value = Int32.Parse(syncSetting.getval("cond1atleastfiles"));
            this.app1_cond1_atleast_hours.Value = Int32.Parse(syncSetting.getval("cond1atleasthours"));
            this.app1_cond1_capture_stat.Checked = Boolean.Parse(syncSetting.getval("cond1capture"));

            this.app1_cond2_stat.Checked = Boolean.Parse(syncSetting.getval("cond2setting"));
            this.app1_cond2_fname.Text = syncSetting.getval("cond2fname");
            this.app1_cond2_older_stat.Checked = Boolean.Parse(syncSetting.getval("cond2oldersetting"));
            this.app1_cond2_older_hours.Value = Int32.Parse(syncSetting.getval("cond2olderhours"));
            this.app1_cond2_atleast_stat.Checked = Boolean.Parse(syncSetting.getval("cond2atleastsetting"));
            this.app1_cond2_atleast_files.Value = Int32.Parse(syncSetting.getval("cond2atleastfiles"));
            this.app1_cond2_atleast_hours.Value = Int32.Parse(syncSetting.getval("cond2atleasthours"));
            this.app1_cond2_capture_stat.Checked = Boolean.Parse(syncSetting.getval("cond2capture"));

            this.app1_cond3_stat.Checked = Boolean.Parse(syncSetting.getval("cond3setting"));
            this.app1_cond3_fname.Text = syncSetting.getval("cond3fname");
            this.app1_cond3_older_stat.Checked = Boolean.Parse(syncSetting.getval("cond3oldersetting"));
            this.app1_cond3_older_hours.Value = Int32.Parse(syncSetting.getval("cond3olderhours"));
            this.app1_cond3_atleast_stat.Checked = Boolean.Parse(syncSetting.getval("cond3atleastsetting"));
            this.app1_cond3_atleast_files.Value = Int32.Parse(syncSetting.getval("cond3atleastfiles"));
            this.app1_cond3_atleast_hours.Value = Int32.Parse(syncSetting.getval("cond3atleasthours"));
            this.app1_cond3_capture_stat.Checked = Boolean.Parse(syncSetting.getval("cond3capture"));

            this.app1_serv_cond_stat.Checked = Boolean.Parse(syncSetting.getval("serversetting"));
            this.app1_serv_cond_name.Text = syncSetting.getval("servername");
            this.app1_serv_cond_nick.Text = syncSetting.getval("servernickname");
            this.app1_serv_cond_ip.Text = syncSetting.getval("serverip");

        }
    }
}
