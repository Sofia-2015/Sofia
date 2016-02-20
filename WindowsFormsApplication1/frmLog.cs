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
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
<<<<<<< HEAD
            Console.WriteLine(Program.logList.Count);

            for(int i =0; i < Program.logList.Count; i++)
            {
                dataGridView1.Rows.Add(Program.logList[i].rundt.ToString(), Program.logList[i].appname, Program.logList[i].status, Program.logList[i].log);
                
            }
           
=======
            Logging.loadLog();
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

=======
            Logging.exportExcel();
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
        }
    }
}
