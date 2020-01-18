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
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20, 20), new Point(70, 70), Color.Red, Color.Yellow);
            Graphics g = panel1.CreateGraphics();
            //g.FillRectangle(lgb, 20, 20, 50, 50);
            g.FillEllipse(lgb, 20, 20, 50, 50);
        }
    }
}