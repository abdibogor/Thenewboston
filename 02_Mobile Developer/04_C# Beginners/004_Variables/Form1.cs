using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string name = "Joe";
            //int number = 5;
            //int number = 66;
            //bool redair = false;
            //object myObj = true;
             object myobj = "Adam"
            MessageBox.Show(myObj.ToString());
        
    }
}
