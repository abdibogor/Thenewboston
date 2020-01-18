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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        Image[] GeneratorCaptchas(int amount)
        {
            Graphics g = panel1.CreateGraphics();
            Random ran = new Random();
            SolidBrush b = new SolidBrush(Color.FromArgb(0*FF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255)));
            Pen p = new Pen(Color.FromArgb(0*FF, ran.Next(0, 255), Ran.Next(0, 255), ran.Next(0, 255)));
            return null; 
        }

    }
}
