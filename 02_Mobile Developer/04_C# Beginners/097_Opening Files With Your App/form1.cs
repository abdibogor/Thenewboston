using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Opening
{
    public partial class Form1 : Form
    {
        string S;
        public Form1(string s)
        {
            InitializeComponent();
            MessageBox.Show(s);
        }
    }
}
