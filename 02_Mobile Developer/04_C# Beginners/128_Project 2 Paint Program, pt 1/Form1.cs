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
            g = panel1.CreateGraphics();
        }
        bool CanPaint = false;
        Graphics g;
        private void panel1_MouseDown(object sender, PaintEventArgs e)
        {
            CanPaint = true;  
        }

        private void panel1_MouseUp(object sender, PaintEventArgs e)
        {
            CanPaint = false;
        }

        private void panel1_MouseMove(object sender, PaintEventArgs e)
        {
            if (CanPaint)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.fillEllipse(s, e.X, e.Y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
            }
        }
    }
}