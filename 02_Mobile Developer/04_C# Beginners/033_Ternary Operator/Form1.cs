using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ternary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string myString = "";
            //if (checkBox1.Checked) myString = "It's checked.";
            //else myString = "It's not checked.";
              /*
            string myString = (CheckBox1.Checked) ? "It's Checked.": "It's not Checked.";
            MessageBox.Show(myString);
               */
            MessageBox.Show((CheckBox1.Checked) ? "It's Checked." : "It's not Checked.");
        }
    }
}
