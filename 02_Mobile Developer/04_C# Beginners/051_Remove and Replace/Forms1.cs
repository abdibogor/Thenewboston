using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Remove
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
            string sentence = "Hello, my name is Adam.";
            string after = sentence.Remove(0, 7);
            MessageBox.Show(after);
                */

               /*
            string sentence = "Hello, my name is Adam.";
            string after = sentence.Remove(18);
            MessageBox.Show(after);
               */

               /*
            string sentence = "Hello, my name is Adam.";
            string after = sentence.Replace("Hello", "Wi");
            MessageBox.Show(after);
               */

               /*
            string sentence = "Hello, my name is Adam.";
            string after = sentence.Replace("a", "0");
            MessageBox.Show(after);
                */

            string sentence = "Hello, my name is Adam. Hello";
            string after = sentence.Replace("Hello", "Hi");
            MessageBox.Show(after);

        }
    }
}
