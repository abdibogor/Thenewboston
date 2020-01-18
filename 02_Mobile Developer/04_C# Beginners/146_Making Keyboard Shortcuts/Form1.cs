using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, EventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "A")
                MessageBox.Show("Adam");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode.ToString() == "F")
            //if (e.alt && e.KeyCode.ToString() == "F")
              if (e.alt && e.Control)
                //MessageBox.Show("You pressed ctrl and F from the textBox");
                  MessageBox.Show("You pressed alt and B from the textBox");
        }
    }
}
