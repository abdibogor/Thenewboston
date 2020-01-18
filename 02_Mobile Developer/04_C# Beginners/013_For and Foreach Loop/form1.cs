using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @for
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
            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("Hello", i.ToString());
            }
             */

            /*
            for (int i = 0; ; i++)
            {
                MessageBox.Show("Hello", i.ToString());
            }
             */

            /*
            string[] names = { "Adam", "Bob", "Joe" };
            foreach (string e in names)
            {
                MessageBox.Show(e);
            }
             */
            List<int> numbers = List<int>;
            numbers.Add(5);
            numbers.Add(18);
            numbers.Add(15);
            foreach (int i is indexes)
            {
                MessageBox.Show(i.ToString());
            }
        }
    }
}
