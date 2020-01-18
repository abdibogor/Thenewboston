using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Optional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ShowMessage("Message");
            ShowMessage("Adam", "Title", 2);
        }

        //void ShowMessage(string message, string title = "Default Value")
          void ShowMessage(string message = "", string title = "", int amount = 0)
        {
            for (int i = 0; i < amount; i++)
            MessageBox.Show(message, title);
        }
    }
}
