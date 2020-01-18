using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace File
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
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //File.Copy(ofd.FileName, "C:\\users\\Adam\\Desktop\\Text Folder\\Folder1\\textDoc.txt");
                File.move(ofd.FileName, "C:\\users\\Adam\\Desktop\\Text Folder\\Folder1\\textDoc.txt");
        }
    }
}
