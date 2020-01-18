using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Directory_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      /*
            FolowBrowserDialog fbd = new folderBrowserDialog();
            if (fbd.ShowDialog) == System.Windows.Forms.DialogResult.OK)
            {
                //string[] files = Directory.GetFiles(fbd.selectedPath);
                string[] files = Directory.GetDirectories(fbd.selectedPath);
                foreach (string a in files)
                    MessageBox.Show(s);
            }
               */
            string[] drives = Directory.SetLogicaldrives();
            foreach (string s in drives)
              MessageBox.Show(s);
        }
    }
}
