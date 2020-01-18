using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string word = "";
        List<Label> labels = new List<Label>();

        enum BodyParts
        { 
            Head,
            Left_Eye,
            Right_Eye,
            Mouth,
            Right_Are,
            Left_Are,
            Body,
            Right_leg,
            Left_leg
        }

        void DrawHangPost()
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Brown, 10);
            g.DrawLine(p, new Point(130, 218), new Point(130, 5));
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            g.DrawLine(p, new Point(60, 0), new Point(60, 50));
            DrawBodyPart(BodyParts.Head);
            DrawBodyPart(BodyParts.Left_Eye);
            DrawBodyPart(BodyParts.Right_Eye);
            DrawBodyPart(BodyParts.Mouth);
            DrawBodyPart(BodyParts.Body);
            DrawBodyPart(BodyParts.Left_Arm);
            DrawBodyPart(BodyParts.Right_Arm);
            DrawBodyPart(BodyParts.Left_leg);
            DrawBodyPart(BodyParts.Right_leg);
            MessageBox.Show(GetRandomWord());
        }

        void DrawBodyPart(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);
            if (bp == BodyParts.Head)
                g.DrawEllipse(p, 40, 50, 40, 40);
            //DrawBodyPart(BodyParts.Head);
            else if (bp == BodyParts.Left_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 50, 60, 5, 5);
            }
            else if (bp == BodyParts.Right_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 63, 60, 5, 5);
            }
            else if (bp == BodyParts.Mouth)
                g.DrawArc(p, 50, 60, 20, 20, 45, 90);
            else if (bp == BodyParts.Body)
                g.DrawLine(p, new Point(60, 60), new Point(60, 170));
            else if (bp == BodyParts.Left_Arm)
                g.DrawLine(p, new Point(60, 100), new Point(30, 85));
            else if (bp == BodyParts.Right_Arm)
                g.DrawLine(p, new Point(60, 100), new Point(90, 85));
            else if (bp == BodyParts.left_Leg)
                g.DrawLine(p, new Point(60, 170), new Point(30, 190));
            else if (bp == BodyParts.Right_leg)
                g.DrawLine(p, new Point(60, 170), new Point(90, 190));
        }

        void MakeLabels()
        {
           word = GetRandomWord();
           char[] chars = word.ToCharArray(); //\n
           int between = 330 / chars.Length - 1;
           for (int i = 0; i < chars.Length - 1; i++)
           { 
               labels.Add(new Label());
               labels[i].Location = new Point((i * between) + 10, 80);
               labels[i].Text = "_";
               labels[i].Parent = groupBox2;
               labels[i].BringToFront();
               labels[i].CreateControl();
           }
           label1.Text = "Word Length: " + (chars.Length - 1).ToString();
        }

        string GetRandonWord()
        {
            WebClient wc = new WebClient();
            string wordList = wc.DownloadString("http://dictionary-thesaurus.com/wordlists/Adjectives%28929%29.txt");
            string[] words = wordList.Split('\n');
            Random ran = new Random();
            return words[ran.Next(0, words.Length - 1)];
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawHangPost();
        }
    }
}
