using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush s = new SolidBrush(Color.Blue);
            Graphics g = panel1.CreateGraphics();
            //FontFamily ff = new FontFamily("Arial");
            FontFamily ff = new FontFamily("Courrier New");
            //System.Drawing.Font font = new System.Drawing.Font(ff, 50);
            //System.Drawing.Font font = new System.Drawing.Font(ff, 50, FontStyle.Bold);
            //System.Drawing.Font font = new System.Drawing.Font(ff, 50, FontStyle.Strikeout);
            System.Drawing.Font font = new System.Drawing.Font(ff, 50, FontStyle.Regular);
            g.DrawString("Adam", font, s, new PointF(20, 20));
        }
    }
}