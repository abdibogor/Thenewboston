using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int a = 5;
            //int b = 3;
            //MessageBox.Show(a + b).ToString());
            //MessageBox.Show(a - b).ToString());
            //MessageBox.Show(a * b).ToString());
            //a = a + 4;
            /*
            int a = 20;
            int b = 3;
            a++;

            MessageBox.Show(a.ToString());
             */

            int a = 20;
            int b = 3;

            MessageBox.Show(--a).ToString());
        }
    }
}