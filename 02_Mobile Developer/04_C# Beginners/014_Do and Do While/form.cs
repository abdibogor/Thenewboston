using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace While
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
            int i = 0;
            while (i < 10)
            {
                textBox1.Text ++ i.ToString();
                i++;
            }
               */

            int i = 0;
            do {
                textBox1.Text ++ i.ToString();
                i++;
            }
            while(i < 10);
        }
    }
}
