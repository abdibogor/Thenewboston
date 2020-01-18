using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Convert
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
            string Name = "John Smith";
            string FirstName = Name.Substring(0, 4);
            MessageBox.Show(FirstName);
              */
            /*
            string Name = "John Smith";
            string LastName = Name.Substring(5, 4);
            MessageBox.Show(LastName);
             */
            string Name = "John Smith abdibogoreh";
            string LastName = Name.Substring(5);
            MessageBox.Show(LastName);
        }
    }
}
