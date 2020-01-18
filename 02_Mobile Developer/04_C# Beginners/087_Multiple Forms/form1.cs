using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(string myString);
            label1.Text = myString;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //f.Show();
            f.ShowDialog();
        }
    }
}
