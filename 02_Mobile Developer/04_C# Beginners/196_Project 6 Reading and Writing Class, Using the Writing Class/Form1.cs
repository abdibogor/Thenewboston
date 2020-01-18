using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdamsIO;

namespace Writing
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
                /*
                Writer w = new Writer(ofd.FileName);
                w.ChangeByteOrder(BaseIO.ByteOrder.LittleEndian);
                w.Position = 0 * 10;
                w.WriteUnicodeString("Adam");
                w.Close();
                */

                Writer w = new Writer(ofd.FileName);
                w.Position = 0*20;
                w.WriteUInt32(0*FFFFFDFC);
                w.Close();

            }
        }
    }
}
