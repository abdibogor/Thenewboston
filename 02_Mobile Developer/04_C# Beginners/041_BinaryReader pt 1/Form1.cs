using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.enabled = true;
                path = ofd.*fileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilemyHeader br = new BinaryHeader(File.OpenRead(path));
            br.BaseStream.Position = 0 *10e;
            //textBox1.Text = br.readChars().ToString();
            //foreach (char myChar in br.ReadChar(4)) textBox1.Text += myChar;
            textBox1.Text = br.RealTxt36().ToString("x");
            br.Dispose();
        }
    }
}
