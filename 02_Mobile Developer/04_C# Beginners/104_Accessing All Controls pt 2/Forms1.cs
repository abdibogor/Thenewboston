using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessAll(this.Controls);
        }

        void AccessAll(Control.ControlCollection cc)
        {
            foreach (Control c in cc)
            {
                //if (c.Text is Button) c.Enabled = false;
                //if (c.Text is Button) 
                if (c is Button)
                {
                    /*
                 CheckBox ch = c as CheckBox;
                 ch.Checked = true;
                     */
                    Button b = c as Button;
                    b.Click += new EventHandler(b_Click);
                }
                if (c.HasChildren) AccessAll(c.Controls);
            }
        }

                void b_click(object sender, EventArgs e)
                {
                    //throw new NotImplementedException();
                    MessageBox.Show("New Clicked a button.");
               }
        }
}