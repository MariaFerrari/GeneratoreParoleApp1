using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratoreParoleApp1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void bgw_singolo_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            string[] parole = new string[1000];
            string caratteri = "1234567890qwertyuiopasdfghjklzxcvbnm";
            Stopwatch cronometro = new Stopwatch();
            bgw.ReportProgress(0, 0);
            StringBuilder sb;
            cronometro.Start();
            for(int i=0; i<1000; i++)
            {
                sb = new StringBuilder();
                for(int j=0; j<10; j++)
                {
                    int y = rnd.Next(0, caratteri.Length);
                    sb.Append(caratteri[y]);
                }
                parole[i] = sb.ToString();
                bgw.ReportProgress(i/10, (int)cronometro.Elapsed.TotalMilliseconds);
                Thread.Sleep(100);
            }
            cronometro.Stop();
            bgw.ReportProgress(100, (int)cronometro.Elapsed.TotalMilliseconds);
            /*StreamWriter sw = new StreamWriter("Passwords.txt");
            using (sw)
            {
                foreach (string p in parole)
                    sw.WriteLine(p);
            }*/
        }

        private void bgw_singolo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tb_singolo.Text = e.UserState.ToString();
            pgb_singolo.Value = e.ProgressPercentage;
        }

        private void bgw_singolo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btn_start_singolo_Click(object sender, EventArgs e)
        {
            bgw_singolo.RunWorkerAsync();
        }
    }
}
