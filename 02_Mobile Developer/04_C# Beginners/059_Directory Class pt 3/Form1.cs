using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                /*
            FolderBrowse(DialogResult fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Directory.CreateDirectory(fbd.SelectedPath = "\\Adam");
                Directory.Neve(fbd.SelectedPath, "C:\\Users\\Adam\\Desktop\\Test Folder\\folder2\\Adam");
                */
            FolderBrowse(DialogResult fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Directory.Delete(fbd.SelectedPath);
       }
    }
}
