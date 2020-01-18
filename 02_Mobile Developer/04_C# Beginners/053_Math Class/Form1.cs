using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //labels.Text = Math.Abs(-4).ToString();
            //label1.Text = Math.Pi.ToString();
            //label1.Text = Math.Pw(4, 2).ToString();
            //label1.Text = Math.royand(4.2).ToString();
            label1.Text = Math.round(4.79423, 2).ToString();
        }
    }
}
