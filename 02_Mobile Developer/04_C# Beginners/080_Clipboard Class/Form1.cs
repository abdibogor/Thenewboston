using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            pictureBox1.ImageLocation = "http://i.dailymail.co.uk/i/pix/2015/09/01/18/2BE1E88B00000578-3218613-image-m-5_1441127035222.jpg";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox2.Text = Clipboard.GetText();
            //pictureBox2.Image = Clipboard.GetImage();
            try
            {
                //Clipboard.SetText("Bob");
                Clipboard.SetImage(pictureBox1.Image);
            }
                /*
            catch ( )
            pictureBox2.Image = Clipboard.GetImage();
                 */
            Clipboard.Clear();
        }
    }
}
