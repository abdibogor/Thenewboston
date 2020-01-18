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
            GraphicsPath gp = new GraphicsPath();
            //Rectangle r = new Rectangle(20, 20, 50, 50);
            Point[] points = { new Point(20, 20), new Point(20, 70), new Point(70, 20), new Point(70, 70) };
            gp.AddPolygon(points);
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = Color.White;
            pgb.SurroundColors = new Color[] { Color.Black };
            Graphics g = panel1.CreateGraphics();
            //g.FillRectangle(pgb, r);
            g.FillPolygon(pgb, points);
        }
    }
}