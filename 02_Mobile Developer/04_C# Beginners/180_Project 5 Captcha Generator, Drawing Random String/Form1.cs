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
            GeneratorCaptchas(0);
        }

        Image[] GeneratorCaptchas(int amount)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            Random ran = new Random();
            SolidBrush b = new SolidBrush(Color.FromArgb(0*FF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255)));
            Pen p = new Pen(Color.FromArgb(0*FF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255)));
            char[] chars = "AbdoulrazaOmaBogoreh".ToCharArray();
            string randomString = "";
            for (int i = 0; i < 6; i++)
            {
                randomString += chars[ran.Next(0, 35)];
            }
            FontFamily ff = new FontFamily("Arial");
            Font f = new System.Drawing.Font(ff, 14);
            g.DrawString(randomString, f, b, 20, 20);
            return null;
        }

    }
}
