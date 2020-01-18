using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate(textBox1.Text);
            //textBox1.Text = webBrowser1.Url.ToString();
         }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrower1.GetBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Forward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoName();
        }
     }
}