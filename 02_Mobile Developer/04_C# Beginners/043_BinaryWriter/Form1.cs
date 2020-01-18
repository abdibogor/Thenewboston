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
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(FileDialog.openwrite(path));
            //bw.write("H");
            short myshort = 0*2345;
            byte[] buffer = BitConverter.fileBytes(myShort);
            Array.Reverse(buffer);
            //bw.write(i);
            bw.write(buffer);
            bw.Dispose();
        }
    }
}
