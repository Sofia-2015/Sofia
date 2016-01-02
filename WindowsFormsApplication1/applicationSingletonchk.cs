using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using System.Net;
using System.Timers;

namespace WindowsFormsApplication1
{
    public partial class applicationSingletonchk : UserControl
    {
        public applicationSingletonchk()
        {
            InitializeComponent();
        }

        public void runcheck(settings AppSetting)
        {
            Boolean appStatus = true;

            String applog = "";
            DateTime currentTime = DateTime.Now;

            if(AppSetting.getval("appdownfile") != "")
            {
                if(File.Exists(AppSetting.getval("appdownfile")))
                {
                    appStatus = false;
                    applog += "Found Downfile " + AppSetting.getval("appdownfile") + ", Application status is set to DOWN. ";
                }
            }

            // condition 1 file check..

            if(Boolean.Parse(AppSetting.getval("cond1setting")) == true)
            {
                if (AppSetting.getval("cond1fname") != "")
                {
                   if(Boolean.Parse(AppSetting.getval("cond1oldersetting")) == true)
                   {
                       DateTime fileDate = File.GetCreationTime(AppSetting.getval("cond1fname"));
                       if((currentTime - fileDate).Hours > Int32.Parse(AppSetting.getval("cond1olderhours")))
                       {
                           appStatus = false;
                           applog += "File Condition 1 is older than settings, Application status is set to DOWN. ";
                       }
                   }


                   if (Boolean.Parse(AppSetting.getval("cond1atleastsetting")) == true)
                   {
                       // check for files within the pattern..
                       string[] filesfound = Directory.GetFiles(AppSetting.getval("cond1fname"));
                       if(filesfound.Length < Int32.Parse(AppSetting.getval("cond1atleastfiles")))
                       {
                           appStatus = false;
                           applog += "File Condition 1 Couldn't find sufficient number of files, Application status is set to DOWN. ";
                       }
                       else
                       {
                           int fileslist = 0;
                           for(int io = 0; io < filesfound.Length; io++)
                           {
                               DateTime fileDate = File.GetCreationTime(AppSetting.getval("cond1fname"));
                               if ((currentTime - fileDate).Hours <= Int32.Parse(AppSetting.getval("cond1atleasthours")))
                               {
                                   fileslist++;
                               }

                              
                           }

                           if(fileslist < Int32.Parse(AppSetting.getval("cond1atleastfiles")))
                           {
                               appStatus = false;
                               applog += "Couldn't find enough files within the condition 1 settings, Application status is set to DOWN. ";
                           }
                          

                       }
                       
                   }


                }
               
            }


            // Condition 2 settings validation:

            if (Boolean.Parse(AppSetting.getval("cond2setting")) == true)
            {
                if (AppSetting.getval("cond2fname") != "")
                {
                    if (Boolean.Parse(AppSetting.getval("cond2oldersetting")) == true)
                    {
                        DateTime fileDate = File.GetCreationTime(AppSetting.getval("cond2fname"));
                        if ((currentTime - fileDate).Hours > Int32.Parse(AppSetting.getval("cond2olderhours")))
                        {
                            appStatus = false;
                            applog += "File Condition 2 is older than settings, Application status is set to DOWN. ";
                        }
                    }


                    if (Boolean.Parse(AppSetting.getval("cond2atleastsetting")) == true)
                    {
                        // check for files within the pattern..
                        string[] filesfound = Directory.GetFiles(AppSetting.getval("cond2fname"));
                        if (filesfound.Length < Int32.Parse(AppSetting.getval("cond2atleastfiles")))
                        {
                            appStatus = false;
                            applog += "File Condition 2 Couldn't find sufficient number of files, Application status is set to DOWN. ";
                        }
                        else
                        {
                            int fileslist = 0;
                            for (int io = 0; io < filesfound.Length; io++)
                            {
                                DateTime fileDate = File.GetCreationTime(AppSetting.getval("cond2fname"));
                                if ((currentTime - fileDate).Hours <= Int32.Parse(AppSetting.getval("cond2atleasthours")))
                                {
                                    fileslist++;
                                }


                            }

                            if (fileslist < Int32.Parse(AppSetting.getval("cond2atleastfiles")))
                            {
                                appStatus = false;
                                applog += "Couldn't find enough files within the condition 2 settings, Application status is set to DOWN. ";
                            }


                        }

                    }


                }
               
            }



            // condition 3 settings validation

            if (Boolean.Parse(AppSetting.getval("cond3setting")) == true)
            {
                if (AppSetting.getval("cond3fname") != "")
                {
                    if (Boolean.Parse(AppSetting.getval("cond3oldersetting")) == true)
                    {
                        DateTime fileDate = File.GetCreationTime(AppSetting.getval("cond3fname"));
                        if ((currentTime - fileDate).Hours > Int32.Parse(AppSetting.getval("cond3olderhours")))
                        {
                            appStatus = false;
                            applog += "File Condition 3 is older than settings, Application status is set to DOWN. ";
                        }
                    }


                    if (Boolean.Parse(AppSetting.getval("cond3atleastsetting")) == true)
                    {
                        // check for files within the pattern..
                        string[] filesfound = Directory.GetFiles(AppSetting.getval("cond3fname"));
                        if (filesfound.Length < Int32.Parse(AppSetting.getval("cond3atleastfiles")))
                        {
                            appStatus = false;
                            applog += "File Condition 3 Couldn't find sufficient number of files, Application status is set to DOWN. ";
                        }
                        else
                        {
                            int fileslist = 0;
                            for (int io = 0; io < filesfound.Length; io++)
                            {
                                DateTime fileDate = File.GetCreationTime(AppSetting.getval("cond3fname"));
                                if ((currentTime - fileDate).Hours <= Int32.Parse(AppSetting.getval("cond3atleasthours")))
                                {
                                    fileslist++;
                                }


                            }

                            if (fileslist < Int32.Parse(AppSetting.getval("cond3atleastfiles")))
                            {
                                appStatus = false;
                                applog += "Couldn't find enough files within the condition 3 settings, Application status is set to DOWN. ";
                            }


                        }

                    }


                }
                
            }

            if (Boolean.Parse(AppSetting.getval("serversetting"))==true)
            {
                if(AppSetting.getval("servernickname") !="")
                {
                    if(AppSetting.getval("serverip")!="")
                    {
                        Ping pingSender = new Ping();
                        IPAddress address = IPAddress.Parse(AppSetting.getval("serverip"));
                        PingReply reply = pingSender.Send(address);

                        if(reply.Status != IPStatus.Success)
                        {
                            appStatus = false;
                            applog += "Couldn't Ping Server " + AppSetting.getval("servernickname") + ", Application status is set to DOWN. ";
                        }
                    }

                }
            }


            AppSetting.lastcheck = DateTime.Now;
            AppSetting.CurrentStatus = appStatus;
            System.Timers.Timer aTimer;

            if(appStatus==true)
            {
                appnamebtn.ForeColor = System.Drawing.Color.Green;
                if(Int32.Parse(AppSetting.getval("maincheck"))==0)
                {
                     aTimer = new System.Timers.Timer(1*1000);
                }
                else
                {
                     aTimer = new System.Timers.Timer(Int32.Parse(AppSetting.getval("maincheck"))*1000);
                }
            }
            else
            {
                appnamebtn.ForeColor = System.Drawing.Color.Red;
                if (Int32.Parse(AppSetting.getval("downcheck")) == 0)
                {
                    aTimer = new System.Timers.Timer(1 * 1000);
                }
                else
                {
                    aTimer = new System.Timers.Timer(Int32.Parse(AppSetting.getval("downcheck")) * 1000);
                }
               
            }


            lastchecktime.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            
           // aTimer.Elapsed += this.runcheck(AppSetting);
            aTimer.AutoReset = false;
            aTimer.Enabled = true;

           

        }


    }
}
