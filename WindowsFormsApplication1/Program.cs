﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ini;



namespace WindowsFormsApplication1
{
<<<<<<< HEAD
    public static class Program
    {
        static int level_num;
        public static List<logs> logList;

=======
    static class Program
    {
        static int level_num;
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
<<<<<<< HEAD
            logList = new List<logs>();
=======
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Need to load Configuration File..
            switch (LoadConfig())
            {
                // case 0 -- Configuration Loaded
                case 0:
                    // load configuration..
                    if (settings.getLevels() == "")
                    {
                        // switch to default 3 levels
                        Program.level_num = 3;
                    }
                    else
                    {
                        Program.level_num = Int32.Parse(settings.getLevels());
                    }

                    // build the interface ..
                    Application.Run(new frmMainSub());

                  //  Application.Run(new AdminForm());
                    break;

                // case 1 -- Configuration File not found
                case 1:
                    MessageBox.Show("This application is missing the config file, call the help desk");
                    
                    System.Windows.Forms.Application.Exit();
                    break;



            }


        }

        static int LoadConfig()
        {
            return settings.checkConfig();

        }
    }

   
}

