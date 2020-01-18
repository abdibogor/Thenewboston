using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Multi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Form2 f = New Form2();
            f.MdiParent = this;
            f.Show();
            Form2 f1 = New Form2();
            f.MdiParent = this;
            f.Show();
            Form2 f2 = New Form3();
            f.MdiParent = this;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.LayoutMdi(MdiLayout, ArrangeIcons);
            //this.LayoutMdi(MdiLayout, Cascade);
            this.LayoutMdi(MdiLayout, Filevertical);
        }
    }
}
