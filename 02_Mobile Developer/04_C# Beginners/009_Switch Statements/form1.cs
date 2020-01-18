using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           /*
        private void button1_Click(object sender, EventArgs e)
        {
              
             int i = 5;
            switch (textBox1.text)
            {
                case "Adam";
                     MessageBox.Show('Hello');
                    break;
                case "bob";
                    MessageBox.Show('yo');
                    break;
                default : 
                     MessageBox.Show('your name isn' important.');
                         break;
            }
        }
    }
}
        */

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 5;
            switch (i)
            {
                case 4:
                    MessageBox.Show('your too young');
                    break;
                case 36:
                    MessageBox.Show('Your can drive');
                    break;
                default:
                    MessageBox.Show("your age isn't textBox1 relevant");
            }
        }
    }
}