using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               if (textBox1.Text == "Adam")
               //if (textBox1.Text != "Adam") 1
            {
                MessageBox.Show("Hello");
            }
                 //if (textBox1.Text == "Box") 2
               else if (textBox1.Text == "Bob")
                 {
                     MessageBox.Show("yo");
             }
               else if (textBox1.Text == "Joe")
               {
                   MessageBox.Show("Hi");
               }
               else
               {
                   MessageBox.Show("Sorry your name isn't important");
               }
        }
    }
}
