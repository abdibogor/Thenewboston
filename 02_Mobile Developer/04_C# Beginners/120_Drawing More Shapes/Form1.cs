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
            SolidBrush ab = new SolidBrush(Color.Blue);
            Graphics g = panel1.CreateGraphics();
            //g.FillPie(ab, 20, 20, 60, 60, 0, 180);
            Point[] points = { new Point(0, 20), new Point(0,0), new Point(20, 0), new Point(20, 20) };
            g.FillPolygon(sb, points);
        }
    }
}