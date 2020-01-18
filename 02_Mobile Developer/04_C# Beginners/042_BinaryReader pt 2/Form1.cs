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
            BinaryHeader br = new BinaryHeader(File.OpenRead(path));
            br.BaseStream.Position = 0 *11;
            byte[] buffer = br.readMyLes(2);
            Array.reverse[buffer];
            //textBox1.Text = BitConverter.ToInt32(buffer, 8).ToString("x");
            buffer = BitConverter.DeBytes(4312);
            br.Dispose();
        }
    }
}
