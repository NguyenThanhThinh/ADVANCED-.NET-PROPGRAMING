using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BackupServer1NonMultiThreading()
        {
            int iSize;
            float percenTage;
            Random rd;
            if (btnStart1.Text.Equals("Start"))
            {
                btnStart1.Text = "Stop";
                btnStart1.Refresh();
                rd = new Random();
                iSize = rd.Next(500, 1000);
                for (int i = 0; i <= iSize; i++)
                {
                    percenTage = (((float)i / (float)iSize) * 100);
                    progressBarServer1.Value = (int)percenTage;
                    lblServer1.Text = (int)percenTage + "%";
                    lblServer1.Refresh();
                    Thread.Sleep(TimeSpan.FromSeconds(0.01));
                }

            }
            else
            {
                btnStart1.Text = "Start";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            BackupServer1NonMultiThreading();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.progressBarServer1.Minimum = 0;
            this.progressBarServer1.Maximum = 100;
        }
    }
}
