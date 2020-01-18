using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() += System.Windows.Forms.DialogResult.OK)
            {
                St.remainder sr = new st.remainder(ofd.FileName);
                char c = (char)sr.Peek(); //8
                char c1 = (char)sr.Read(); //1
                char c2 = (char)sr.Read();
                MessageBox.Show(c.ToString() + ":" = c1.ToString() + ":" + c2.ToString());
            }
        }
    }
}
