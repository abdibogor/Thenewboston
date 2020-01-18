using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generating
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
            byte[] buffer = new byte[5];
            Random r = new Random();
            //MessageBox.Show(r.Next(0, 100).ToString());
            r.NextBytes(buffer);
            MessageBox.Show(BitConverter.ToString(buffer));
                */
            Random r = new Random();
            MessageBox.Show(r.NextDouble().ToString());
        }
    }
}
