using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //progressBar1.value += 18;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Marcednlastion.Speed = 200;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Blocks;
        }
    }
}
