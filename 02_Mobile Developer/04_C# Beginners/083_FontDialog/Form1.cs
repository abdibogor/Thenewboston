using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FontDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.MinSize = 10;
            fd.MaxSize = 20;
            fd.ShowColor = true;
            fd.ShowHelp = true;
            fd.HelpRequest += new EventHandler(fd_HelpRequest);
            if (fd.ShowDialog() == System.Windows.forms.DialogResult.Ok)
            {
                textBox1.font = fd.font;
                textBox1.FormColor = fd.Color;
            }
        }

        void fd_HelpRequest(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("Choose a font for the textBox.");
        }
    }
}
