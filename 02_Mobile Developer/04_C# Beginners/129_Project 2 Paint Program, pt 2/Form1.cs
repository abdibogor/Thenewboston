using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }
        bool canPaint = false;
        Graphics g;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            canPaint = true;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            canPaint = false;
            prevX = null;
            prevY = null;
        }
        int? prevX = null;
        int? prevY = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (canPaint)
            {
                Pen pen = new Pen(Color.Black, float.Parse(toolStripTextBox1.Text));
                g.DrawLine(pen, new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y));
                prevX = e.X;
                prevY = e.Y;
            }
        }
    }
}
