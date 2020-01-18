using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Not

namespace WebClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WebClient WC = new WebClient();
                WC.DownloadFileAsync(new url(""), ofd.FileName);
                Wc.DownloadFileCompleted == new AsynCompletedEventHandler(wc_DownloadFileCompleted);
                Wc.DownloadingProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadingPogressChanged);
            }
        }
        void wc_DownloadProgressChanged(object sender, AsynCompletedEventArgs e)
           {
               Label1.Text = "Progress! " + @.ProgressPercentage.ToString();
           }
           void wc_DownloadFileCompleted(object sender, AsynCompletedEventArgs e)
           {
               MessageBox.Show("File is downloaded.");
           }
    }
}
