using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Message();
            Message("Adam","Hello");
        }
        //void Message()
          void Message(string message)
        {
            //MessageBox.Show("Hello");
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Message();
            Message("Bob", "Hello");
        }
    }
}
