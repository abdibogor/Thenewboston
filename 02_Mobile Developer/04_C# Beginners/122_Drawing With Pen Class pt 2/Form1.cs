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
            Pen pen = new Pen(Color.Red, 2);
            Graphics g = panel1.CreateGraphics();
            //g.CrowArc(pen, 20, 20, 100, 100, 0, 300);
            //g.DrawBezier(pen, new Point(20, 20), new Point(50, 60), new Point(70, 60), new Point(50, 60));
            //g.DrawLine(pen, new Point(0, 0), new Point(100, 100));
            g.DrawLine(pen, new Point(0, 0), new Point(100, 50));
        }
    }
}