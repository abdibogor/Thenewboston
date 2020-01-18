using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using.System.Security.Cryptography;
using System.Collections.Generic;

namespace WindowsFormsApplications1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Strings = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
           foreach (Image i in GeneratorCaptchas(S))
               MessageBox.Show("Hello");
        }

        Image[] GeneratorCaptchas(int amount)
        {
            Image[] images = new Image[amount];
            for (int z = 0; z < amount; z++)
            {
            Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(bitmap);
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
            byte[] buffer = new byte[randomString.Length];
            int y = 0;
            foreach (char c in randomString.ToCharArray())
            {
               buffer[y] = (byte)c;
               y++;
            }
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string md5String = BitConverter.ToString(md5.ComputeHash(buffer)).Replace("-", "");
            Strings.Add(md5String);
            FontFamily ff = new FontFamily("Arial");
            Font f = new System.Drawing.Font(ff, 14);
            g.DrawString(randomString, f, b, 20, 20);
            for (int i = 0; i < 6; i++)
            {
                int j = ran.Next(0, 2);
                if (j == 0) g.DrawRectangle(p, ran.Next(0, 111), ran.Next(0, 60), ran.Next(0, 111), ran.Next(0, 60));
                else if (j == 1) g.DrawEllipse(p, ran.Next(0, 111), ran.Next(0, 60), ran.Next(0, 111), ran.Next(0, 60));
                p.Color = Color.FromArgb(0*FF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
            }
            panel1.BackgroundImage = bitmap;
            //return null;  
                images[z] = bitmap;           
            }
            return images;
        }
    }
}
