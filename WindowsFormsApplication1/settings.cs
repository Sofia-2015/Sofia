using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ini;
using System.IO;
namespace WindowsFormsApplication1
{
    public class settings
    {
        private string type;
        private string level;
        private string total_levels;
        private string name;
        private string maincheck;
        private string downcheck;
        private string appdownfile;
        private string cond1setting;
        private string cond1fname;
        private string cond1oldersetting;
        private string cond1olderhours;
        private string cond1atleastsetting;
        private string cond1atleastfiles;
        private string cond1atleasthours;
        private string cond1capture;
        private string cond2setting;
        private string cond2fname;
        private string cond2oldersetting;
        private string cond2olderhours;
        private string cond2atleastsetting;
        private string cond2atleastfiles;
        private string cond2atleasthours;
        private string cond2capture;
        private string cond3setting;
        private string cond3fname;
        private string cond3oldersetting;
        private string cond3olderhours;
        private string cond3atleastsetting;
        private string cond3atleastfiles;
        private string cond3atleasthours;
        private string cond3capture;
        private string serversetting;
        private string servername;
        private string servernickname;
        private string serverip;
        public DateTime lastcheck;
        public Boolean CurrentStatus;

        public static string CONFILE = "C:\\appconf.cfg";

        public settings(string levelt)
        {
            this.level = levelt;
        }

        public void setval(string prop, string val)
        {

            var prop1 = this.GetType().GetField(prop, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            prop1.SetValue(this, val);


        }

        public static int checkConfig()
        {
            if (File.Exists(settings.CONFILE))
            {

                IniFile confile = new IniFile(settings.CONFILE);

                if (confile.IniReadValue("conf", "ready").Equals("1"))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
            else
            {
                return 1;
            }
        }

        public static string getLevels()
        {
            IniFile confile = new IniFile(settings.CONFILE);
            return confile.IniReadValue("conf", "levels");
        }
        public string getval(string prop)
        {

           

            switch(prop)
            {
                case "name": return this.name; break;
                case "level": return this.level; break;
                case "maincheck": return this.maincheck; break;
                case "downcheck": return this.downcheck; break;
                case "appdownfile": return this.appdownfile; break;
                case "cond1setting": return this.cond1setting; break;
                case "cond1fname": return this.cond1fname; break;
                case "cond1oldersetting": return this.cond1oldersetting; break;
                case "cond1olderhours": return this.cond1olderhours; break;
                case "cond1atleastsetting": return this.cond1atleastsetting; break;
                case "cond1atleastfiles": return this.cond1atleastfiles; break;
                case "cond1atleasthours": return this.cond1atleasthours; break;
                case "cond1capture": return this.cond1capture; break;
                case "cond2setting": return this.cond2setting; break;
                case "cond2fname": return this.cond2fname; break;
                case "cond2oldersetting": return this.cond2oldersetting; break;
                case "cond2olderhours": return this.cond2olderhours; break;
                case "cond2atleastsetting": return this.cond2atleastsetting; break;
                case "cond2atleastfiles": return this.cond2atleastfiles; break;
                case "cond2atleasthours": return this.cond2atleasthours; break;
                case "cond2capture": return this.cond2capture; break;
                case "cond3setting": return this.cond3setting; break;
                case "cond3fname": return this.cond3fname; break;
                case "cond3oldersetting": return this.cond3oldersetting; break;
                case "cond3olderhours": return this.cond3olderhours; break;
                case "cond3atleastsetting": return this.cond3atleastsetting; break;
                case "cond3atleastfiles": return this.cond3atleastfiles; break;
                case "cond3atleasthours": return this.cond3atleasthours; break;
                case "cond3capture": return this.cond3capture; break;
                case "serversetting": return this.serversetting; break;
                case "servername": return this.servername; break;
                case "servernickname": return this.servernickname; break;
                case "serverip": return this.serverip; break;
               
                default:
                    return "";

            }


        }
        public void savesetting()
        {
           
            IniFile confile = new IniFile(settings.CONFILE);
            confile.IniWriteValue("conf", "ready", "1");
            confile.IniWriteValue("conf", "levels", this.total_levels );
            confile.IniWriteValue("app" + this.level, "name", this.name);
            confile.IniWriteValue("app" + this.level, "maincheck", this.maincheck);
            confile.IniWriteValue("app" + this.level, "downcheck", this.downcheck);
            confile.IniWriteValue("app" + this.level, "appdownfile", this.appdownfile);
            confile.IniWriteValue("app" + this.level, "cond1setting", this.cond1setting);
            confile.IniWriteValue("app" + this.level, "cond1fname", this.cond1fname);
            confile.IniWriteValue("app" + this.level, "cond1oldersetting", this.cond1oldersetting);
            confile.IniWriteValue("app" + this.level, "cond1olderhours", this.cond1olderhours);
            confile.IniWriteValue("app" + this.level, "cond1atleastsetting", this.cond1atleastsetting);
            confile.IniWriteValue("app" + this.level, "cond1atleastfiles", this.cond1atleastfiles);
            confile.IniWriteValue("app" + this.level, "cond1atleasthours", this.cond1atleasthours);
            confile.IniWriteValue("app" + this.level, "cond1capture", this.cond1capture);
            confile.IniWriteValue("app" + this.level, "cond2setting", this.cond2setting);
            confile.IniWriteValue("app" + this.level, "cond2fname", this.cond2fname);
            confile.IniWriteValue("app" + this.level, "cond2oldersetting", this.cond2oldersetting);
            confile.IniWriteValue("app" + this.level, "cond2olderhours", this.cond2olderhours);
            confile.IniWriteValue("app" + this.level, "cond2atleastsetting", this.cond2atleastsetting);
            confile.IniWriteValue("app" + this.level, "cond2atleastfiles", this.cond2atleastfiles);
            confile.IniWriteValue("app" + this.level, "cond2atleasthours", this.cond2atleasthours);
            confile.IniWriteValue("app" + this.level, "cond2capture", this.cond2capture);
            confile.IniWriteValue("app" + this.level, "cond3setting", this.cond3setting);
            confile.IniWriteValue("app" + this.level, "cond3fname", this.cond3fname);
            confile.IniWriteValue("app" + this.level, "cond3oldersetting", this.cond3oldersetting);
            confile.IniWriteValue("app" + this.level, "cond3olderhours", this.cond3olderhours);
            confile.IniWriteValue("app" + this.level, "cond3atleastsetting", this.cond3atleastsetting);
            confile.IniWriteValue("app" + this.level, "cond3atleastfiles", this.cond3atleastfiles);
            confile.IniWriteValue("app" + this.level, "cond3atleasthours", this.cond3atleasthours);
            confile.IniWriteValue("app" + this.level, "cond3capture", this.cond3capture);
            confile.IniWriteValue("app" + this.level, "serversetting", this.serversetting);
            confile.IniWriteValue("app" + this.level, "servername", this.servername);
            confile.IniWriteValue("app" + this.level, "servernickname", this.servernickname);
            confile.IniWriteValue("app" + this.level, "serverip", this.serverip);
            


        }

        public void getSettings()
        {
            IniFile confile = new IniFile(settings.CONFILE);
            this.name =  confile.IniReadValue("conf", "ready");
            this.total_levels = confile.IniReadValue("conf", "levels");
            this.name = confile.IniReadValue("app" + this.level, "name");
            this.maincheck = confile.IniReadValue("app" + this.level, "maincheck");
            this.downcheck = confile.IniReadValue("app" + this.level, "downcheck");
            this.appdownfile = confile.IniReadValue("app" + this.level, "appdownfile");
            this.cond1setting = confile.IniReadValue("app" + this.level, "cond1setting");
            this.cond1fname = confile.IniReadValue("app" + this.level, "cond1fname");
            this.cond1oldersetting = confile.IniReadValue("app" + this.level, "cond1oldersetting");
            this.cond1olderhours = confile.IniReadValue("app" + this.level, "cond1olderhours");
            this.cond1atleastsetting = confile.IniReadValue("app" + this.level, "cond1atleastsetting");
            this.cond1atleastfiles = confile.IniReadValue("app" + this.level, "cond1atleastfiles");
            this.cond1atleasthours = confile.IniReadValue("app" + this.level, "cond1atleasthours");
            this.cond1capture = confile.IniReadValue("app" + this.level, "cond1capture");
            this.cond2setting = confile.IniReadValue("app" + this.level, "cond2setting");
            this.cond2fname = confile.IniReadValue("app" + this.level, "cond2fname");
            this.cond2oldersetting = confile.IniReadValue("app" + this.level, "cond2oldersetting");
            this.cond2olderhours = confile.IniReadValue("app" + this.level, "cond2olderhours");
            this.cond2atleastsetting = confile.IniReadValue("app" + this.level, "cond2atleastsetting");
            this.cond2atleastfiles = confile.IniReadValue("app" + this.level, "cond2atleastfiles");
            this.cond2atleasthours = confile.IniReadValue("app" + this.level, "cond2atleasthours");
            this.cond2capture = confile.IniReadValue("app" + this.level, "cond2capture");
            this.cond3setting = confile.IniReadValue("app" + this.level, "cond3setting");
            this.cond3fname = confile.IniReadValue("app" + this.level, "cond3fname");
            this.cond3oldersetting = confile.IniReadValue("app" + this.level, "cond3oldersetting");
            this.cond3olderhours = confile.IniReadValue("app" + this.level, "cond3olderhours");
            this.cond3atleastsetting = confile.IniReadValue("app" + this.level, "cond3atleastsetting");
            this.cond3atleastfiles = confile.IniReadValue("app" + this.level, "cond3atleastfiles");
            this.cond3atleasthours = confile.IniReadValue("app" + this.level, "cond3atleasthours");
            this.cond3capture = confile.IniReadValue("app" + this.level, "cond3capture");
            this.serversetting = confile.IniReadValue("app" + this.level, "serversetting");
            this.servername = confile.IniReadValue("app" + this.level, "servername");
            this.servernickname = confile.IniReadValue("app" + this.level, "servernickname");
            this.serverip = confile.IniReadValue("app" + this.level, "serverip");
        }

    }
}
