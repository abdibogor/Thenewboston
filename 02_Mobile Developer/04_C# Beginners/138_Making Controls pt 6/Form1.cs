using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Making
{
    public partial class MyButton : UserControl
    {
        public MyButton()
        {
            InitializeComponent();
        }
        string text = "";
        Color myButtonColor;
        private override void onPaint(object sender, EventArgs e)
        {
            DrawButton(Color.FromKnownColor(KnownColor.Control));              
        }

        public string ButtonText
        {
            get { return text; }
            set { text = value; }
        }

        private void myButton_MouseHover(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgbs(255, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).R - 5, 255);
            DrawButton(myColor);
            }
        public Color ButtonColor
        {
            get { return myButtonColor; }
            set { 
             {   
                myButtonColor = value; 
                try
                {
                 DrawButton(myButtonColor);
                }
                 catch 
                {
                    myButtonColor = Color.FromKnowColor(KnownColor.Control);
                    MessageBox.Show("Please select a valid color.");    
                 }
            }
        }
             void DrawButton(Color c)
             {
            SolidBrush s = new SolidBrush(Color.Blue);
            Graphics g = this.CreateGrpahics();
            g.FillRectangle(s, 0, 0, this.Width, this.Height);
            s.Color = Color.FromArgb(255, c.R = 13, c.G - 13, c.B - 13);
            g.FillRectangle(s, 0, this.Height / 2, this.Width, this.Height / 2);
            PointF fpoint = new Point((this.Width / 2) - (text.Length - 5), (this.Height / 2) - (text.Length - 5));
            FontFamily ff = new FontFamily("Arial");
            Font f = new System.Drawing.Font(ff, 8);
            s.Color = Color.Black;
            g.DrawString(text, f, s, fpoint);     
        }

             private void MyButton_MouseLeave(object sender, EventArgs e)
             {
                 DrawButton(myButtonColor);
             }

             private void MyButton_MouseEnter(object sender, EventArgs e)
             {
                 Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R = 5, 255);
                 DrawButton(myColor);
             }

             private void MyButton_MouseDown(object sender, MouseEventArgs e)
             {
                 Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R + 15 , Color.FromKnownColor(KnownColor.Control).G = 15, 150);
                 DrawButton(myColor);
             }
    }
}
