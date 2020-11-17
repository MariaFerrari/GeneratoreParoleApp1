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
        string caratteri = "1234567890qwertyuiopasdfghjklzxcvbnm";
        public Form1()
        {
            InitializeComponent();
        }

        private void bgw_singolo_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            string[] parole = new string[1000];
            Stopwatch cronometro = new Stopwatch();
            StringBuilder sb;

            bgw.ReportProgress(0, 0);
            cronometro.Start();
            
            for (int i = 1; i < 1000; i++) 
            {
                sb = new StringBuilder();
                for (int j = 0; j < 10; j++) 
                {
                    int y = rnd.Next(0, caratteri.Length);
                    sb.Append(caratteri[y]);
                }
                parole[i] = sb.ToString();
                bgw.ReportProgress(i/10, (int)cronometro.Elapsed.TotalMilliseconds);
                Thread.Sleep(10);
            }
            
            cronometro.Stop();
            bgw.ReportProgress(100, (int)cronometro.Elapsed.TotalMilliseconds);
        
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

        string[] parole_multipli = new string[1000];
        private void bgw_multipli1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            Stopwatch cronometro = new Stopwatch();
            StringBuilder sb;

            //bgw.ReportProgress(0, 0);
            cronometro.Start();
            lock (parole_multipli)
            {
                for (int i = 1; i <= 333; i++)
                {
                    sb = new StringBuilder();
                    for (int j = 0; j < 10; j++)
                    {
                        int y = rnd.Next(0, caratteri.Length);
                        sb.Append(caratteri[y]);
                    }
                    parole_multipli[i] = sb.ToString();
                    parametri par = new parametri((int)cronometro.Elapsed.TotalMilliseconds, (int)e.Argument);
                    bgw.ReportProgress(i*100/333, par);
                    Thread.Sleep(100);
                }
            }

            cronometro.Stop();
           
        }

        private void btn_start_tre_Click(object sender, EventArgs e)
        {
            bgw_multipli1.RunWorkerAsync(0);
            bgw_multipli2.RunWorkerAsync(1);
            bgw_multipli3.RunWorkerAsync(2);
        }

        private void bgw_multipli1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            parametri par = (parametri) e.UserState;
            int tempo = par.tempo;
            int start = par.start;
            tb_tre.Text = tempo.ToString();
            pgb_tre.Value = start * (pgb_tre.Width / 3) + e.ProgressPercentage;
        }

        private void bgw_multipli1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        struct parametri
        {
            public int tempo { get; }
            public int start { get; }
            public parametri(int t,int s)
            {
                tempo = t; start = s;
            }

        }
    }
}
