﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace collective_v2
{
    public partial class task : Form
    {
        public task()
        {
            InitializeComponent();
        }

        private void task_Load(object sender, EventArgs e)
        {
            allp();
        }

        public void allp()
        {
            Process[] p = Process.GetProcesses();
            foreach (var pr in p)
            {
                try
                {
                    dataGridView1.Rows.Add(pr.ProcessName, pr.Id, pr.TotalProcessorTime);

                }
                catch (Exception ex) { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = Process.GetProcessById(Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()));
                p.Kill();
            }
            catch (Exception ex) { }
        }
    }
}
