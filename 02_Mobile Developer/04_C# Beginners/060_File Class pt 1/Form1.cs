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
                //MessageBox.Show(File.Exists(ofd.filename).ToString());
                MessageBox.Show(File.Exists("C:\\Users\\Adam\\textbox.txt").ToString());
            File.Delete(ofd.FileName);
        }
    }
}
