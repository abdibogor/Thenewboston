using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Color
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
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Color c = cd.Color;
                //if (c.IsNameColor) MessageBox.Show(c.Name);

                if (c.IsKnounColor) MessageBox.Show(c.ToKnounColor().ToString());
            }
                */

                /*
            Color c = Color.MintCream;
            MessageBox.Show(c.Name);
               */

            //Color c = Color.FrontKnowColor(KnownColor.GradientActiveCaption);
            Color c = Color.Black;
            //MessageBox.Show(c.ToknownColor().ToString());
            int i = c.ToArgb();
            Color b = Color.FromArgb(i);
            //MessageBox.Show(C.ToArgb().ToString("x"));
            button1.BackColor = b;
        }
    }
}
