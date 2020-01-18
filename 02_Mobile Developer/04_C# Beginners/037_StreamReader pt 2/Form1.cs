using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofd.Filename));
                sr.BaseStream.Position = 4;
                byte[] buffer = new byte[3];
                sc.BaseStream.read[buffer, 0, 3];
                foreach (byte myByte in buffer)
                    textBox1.text += myByte.ToString["x"] + " ";    
                sr.Dispose();
            }
        }
    }
}
