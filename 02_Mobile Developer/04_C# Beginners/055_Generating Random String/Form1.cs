using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace generating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] letters = "Everybody in this country should learn how to program a computer because it teaches you how to think".ToCharArray();
            Random C = new Random();
            //MessageBox.Show(letters[C.Next(0, 25].ToString());
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[c.Next(0, 25)].ToString();
            }
            MessageBox.Show(randomString);
        }
    }
}
