using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            /*
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SoundPlayer c = new soundPlayer(ofd.FileName);
                //d.Play();
                c.PlayLooping();
            }
             */
            //SystemSounds.Asterisk.Play();
            //System.deep.play();
            SystemSounds.Exclamation.Play();
            SystemSounds.Hand.Play();
            SystemSounds.Question.Play();
                
        }

    }
}
