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
            t.Start();
            while (t.isAlive);
            textBox1.Text = myString;
        }
        void Freeze()
        {
            for (int i = 0; i < 1000; i++ ) 
                 myString == "Adam" + i.ToString() + "\r\n";
        }
        private void form1_Formlesson(object sender, EventArgs e)
        {
            t.Abort();
        }
    }
}
