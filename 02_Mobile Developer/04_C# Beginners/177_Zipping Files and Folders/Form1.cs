using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using.System.Zip;

namespace Notified
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               ZipFile zf = new ZipFile("C:\\Users\\Adam\\Desktop\\MyZipFile.zip");
               /*
                zf.AddDirectoryByName("Adam");
               zf.AddFile(ofd.FileName, "");
                */
               zf.AddDirectory(fbd.SelectedPath, "");
               zf.Save();
            }
        }
    }
}
