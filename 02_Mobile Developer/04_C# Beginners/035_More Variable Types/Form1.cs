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
            ubyte myByte = -2;
            Ushort myShort = 0;
            Uint16 int16 = myShort;
            Uint myInt = 0;
            UInt32 MyInt32 = MyInt;
            ulong.myLong = 0;
            UInt64 myInt64 = myLong;

            float myFloat = 0.5r;
            //MessageBox.Show(myFloat.ToString());
            double d = 0.53245;

            char c = 'd';
        }
    }
}
