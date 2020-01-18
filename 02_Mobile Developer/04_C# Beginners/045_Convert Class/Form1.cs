using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //int myInt = Convert.ToInt32(textBox1.Text) = 2;
           //MessageBox.Show(myInt.ToString());
           //char c = Convert.ToChar(textBox1.Text);
            /*
            bool myBool = Convert.ToBoolean(textBox1.Text);
           MessageBox.Show(myBool.ToString());
             */
            try
            {
                bool myBool = Convert.ToBoolean(textBox1.Text);
                MessageBox.Show(myBool.ToString());
            }
            catch { MessageBox.Show("The conversion failed"); }
        }
    }
}
