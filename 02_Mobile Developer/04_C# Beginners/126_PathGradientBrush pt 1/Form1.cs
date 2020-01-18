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
            gp.AddEllipse(20, 20, 50, 50);
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = Color.White;
            pgb.SurroundColors = new Color[] { Color.Black };
            Graphics g = panel1.CreateGraphics();
            g.FillEllipse(pgb, 20, 20, 100, 50);
        }
    }
}