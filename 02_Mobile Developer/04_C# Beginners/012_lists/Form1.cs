using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace allo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] myArray = new string[4];
            /*
            List<string> Names = new List<string>(); // Adam, Joe
            Names.Add("Adam");
            Names.Add("Joe");
            MessageBox.Show(Names[0]);
             */

            List<int> numbers = new List<int>(); //5
            numbers.Add(5);
            numbers.Add(667);
            MessageBox.Show(numbers[1].ToString());
        }
    }
}
