using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace indexOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //string FirstName = name.Substring(0, name.IndexOf(' ') + 1);
            /*
            string name = "     John Smith    ";
            string rawdname = name.Trim();
            MessageBox.Show(rawdname);
             */
            /*
            string name = "     John Smith      ";
            string rawdName = name.TrimStart();
            MessageBox.Show(rawdName);
             */
        }
    }
}
