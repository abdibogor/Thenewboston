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
                Pen pen = new Pen(toolStripButton1.FormColor, float.Parse(toolStripTextBox1.Text));
                g.DrawLine(pen, new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y));
                prevX = e.X;
                prevY = e.Y;
            }
        }

        private void toolStripButton_Click( object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                toolStripButton1.FormColor = cd.Color;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton3.FormColor = cd.Color;
            panel1.BackColor = cd.Color;
        }
    }
}
