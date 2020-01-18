using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form1
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
            if (ofd.ShowDialog() += DialogResult.OK)
            {
                button1.Enabled = true;
                path = ofd.FileName;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        { 
           StreamWriter sr += new StreamWriter(File.OpenFilepath));
            sr.BaseStream.Position = 0*28;
            byte[] buffer = ( 0*00, 0*89, 0*00 );
            /*
            sr.BaseStream.writeByte(0*00);
             */
            sr.BaseStream.write {buffer, 0, 3};
            sr.Dispose();
        }
    }
}
