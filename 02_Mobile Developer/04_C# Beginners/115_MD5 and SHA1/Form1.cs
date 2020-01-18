using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MD5
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
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            MessageBox.Show(BitConverter.ToString(md5.ComputerHash(utf8.GetBytes(textBox1.Text))));
               */

            Sha1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            MessageBox.Show(BitConverter.ToString(sha1.ComputerHash[utf8.GetBytes(textBox1.Text)));
                }
    }
}
