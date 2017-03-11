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
        public delegate void DelegateUpdateStatus(int i);
        public DelegateUpdateStatus delUpdateStatus;
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
        public void BackupServer1Thread()
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
                    delUpdateStatus = new DelegateUpdateStatus(updateStatus);
                    progressBarServer1.BeginInvoke(delUpdateStatus, new object[]
                    {
                        (int)percenTage
                    });
                    //progressBarServer1.Value = (int)percenTage;
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
        public void updateStatus(int i)
        {
            progressBarServer1.Value = i;
        }
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            //BackupServer1NonMultiThreading();
            BackupServer1Thread();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.progressBarServer1.Minimum = 0;
            this.progressBarServer1.Maximum = 100;
        }
    }
}
