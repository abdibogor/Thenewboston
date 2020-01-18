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
            if (drawSquare)
            {
               SolidBrush s = new SolidBrush(toolStripButton.FormColor);
                g.FillRectangle(s, e.X, e.Y, Convert.ToInt32(toolStripTextBox2.Text), Convert.ToInt32(tooStripTextBox2.Text));
                casPaint = false;
                drawSquare = false;
            }
            else if (drawRectangle)
            {
              SolidBrush s = new SolidBrush(toolStripButton.FormColor);
                g.FillRectangle(s, e.X, e.Y, Convert.ToInt32(tooStripText) * 2, Convert.ToInt32(toolStripTextBox2.Text);
                casPaint = false;
                drawSquare = false;
            }
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
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
        {
            toolStripButton3.FormColor = cd.Color;
            panel1.BackColor = cd.Color;
        }
    }
    bool drawSquare = false;
    private void squareToolStripMenuItem_Click(object sender, EventArgs e)
    {
        drawSquare = true;
    }

    private void panel1_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.All;
    }

    private void panel1_DragDrop(object sender, DragEventArgs e)
    {
       string[] imagePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
       foreach(string path in imagePaths)
        {
            g.DrawImage(Image.FromFile(path), new Point(0,0));
        }
     }
   }
}
