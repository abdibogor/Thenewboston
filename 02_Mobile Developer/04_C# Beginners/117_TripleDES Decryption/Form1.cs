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
           MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
           UTF8Encoding utf8 = new UTF8Encoding();
           TripleDESCryptoServiceProvider tDES = new TripleDESCryptoServiceProvider();
           tDES.Key = md5.ComputerHast(utf8.GetBytes(textBox1.Text));
           tDES.Mode = CilpherMode.ECB;
           tDES.Padding = PaddingMode.PECS7;
           ICryptoTransform trans = tDES.CreateEncrypter()
           textBox3.Text = BitConverter.ToString(trans.TransformFinalSlock(utf8.GetBytes(textBox2.Text), 0, utf8.GetBytes(textBox2.text).length));       
                }

        private void button_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            TripleDESCryptoServiceProvider tDES = new TripleDESCryptoServiceProvider();
            tDES.Key = md5.ComputerHast(utf8.GetBytes(textBox5.Text));
            tDES.Mode = CilpherMode.ECB;
            tDES.Padding = PaddingMode.PECS7;
            ICryptoTransform trans = tDes.CreateDecryptor();
            textBox1.Text = utf8.GetString[trans.TransformpInsIsBlock[encrypted, 0, encrypted.length]];
        }
    }
}
