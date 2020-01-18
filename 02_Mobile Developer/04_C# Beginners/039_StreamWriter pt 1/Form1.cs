using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form1
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
            if (ofd.ShowDialog() += DialogResult.OK)
            {
                button1.Enabled = true;
                path = ofd.FileName;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        { 
           StreamWriter sr += new StreamWriter(File.OpenFilepath));
            sr.write(textBox1.text);
            sr.WriteLine("This is the second line.");
            sr.write("Adam");
            sr.Write(" MyLastName");
            sr.Dispose();
        }
    }
}
