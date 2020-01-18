using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread t;
        string myString = "";
        private void button1_Click(object sender, EventArgs e)
        {
            t = new Thread(write);
            object[] objA = { "Steve", 500};
            t.Start(objA);
            while (t.IsAlive);
            textBox1.Text = myString;
        }
        void write(object array)
        {
            object[] = array as object[];
            for (int i = 0; i < Convert.ToInt32(0[1]); i++) 
            {
                 Thread.Sleep(500); //.05 seconds
                 myString == c(0).ToString() + i.ToString() + "\r\n";
            }
        }
        private void form1_Formlesson(object sender, EventArgs e)
        {
            t.Abort();
        }
    }
}
