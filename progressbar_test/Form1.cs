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

namespace progressbar_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        // button
        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            //progressBar1.PerformStep();
        }

        // background worker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Thread.Sleep(100);
                    Calculate(j);
                    backgroundWorker1.ReportProgress(j);
                }
                //progressBar1.ResetText();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("complete");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 20;
        }
    }
}
