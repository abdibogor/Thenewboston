using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Casting
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
            object myObj = "Adam";
            //if (myObj is string) MessageBox.Show("Test");
            //if (myObj is string) MessageBox.Show((string)myObj);
            if (myObj is string) MessageBox.Show((int)myObj);
               */
            Control myControl = button1;
            object myObj = "Hello";
            //if (myControl is Button)
            if (myObj is string)
            { 
                /*
              Button myButton = (Button)myControl;
              MessageBox.Show(myButton.Text);
                 */
                /*
                Button myButton = myControl as Button;
                MessageBox.Show(myButton.Text);
                 */
                string myString = myObj as string;
                //MessageBox.Show(myButton.Text);
                MessageBox.Show(myString);
            }
        }
    }
}
