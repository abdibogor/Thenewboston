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
            SolidBrush ab = new SolidBrush(Color.Green);
           Graphics g = panel1.CreateGraphics();
           //g.FillRectangle(ab, 20, 20, 50, 50);
           //g.FillEllipse(ab, 50, 50, 50, 50);
           g.FillEllipse(ab, 50, 50, 50, 100);
        }
    }
}