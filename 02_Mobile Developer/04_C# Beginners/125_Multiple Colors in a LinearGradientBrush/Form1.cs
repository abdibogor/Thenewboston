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

        private void panel1_Click(object sender, PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20, 20), new Point(70, 70), Color.Red, Color.Yellow);
            Graphics g = panel1.CreateGraphics();
            ColorBlend cb = new ColorBlend();
            cb.Colors = new Color[] { Color.Black, Color.Blue, Color.SkyBlue, Color.White };
            //cb.Positions = new float[] { 0, 5F, 1F };
            cb.Positions = new float[] { 0, .33F, .66F, 1F };
            lgb.InterpolationColors = cb;
            g.FillRectangle(lgb, 20, 20, 50, 50);
        }
    }
}