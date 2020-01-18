using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Process
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
             string myString = "Adam";
             if (myString == null)
                 MessageBox.Show("The String is null.");
             else MessageBox.Show(myString);
                */
            /*
            //string myString = null;
            string.myString = "Adam";
            MessageBox.Show(myString "The String is null.");
             */
            int i = null;
            int a = i ?? a;
            MessageBox.Show(a.ToString());
        }
    }
}
