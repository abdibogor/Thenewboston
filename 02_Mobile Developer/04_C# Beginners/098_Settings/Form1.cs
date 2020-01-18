using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Settings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = WindowsFormsApplication1.Properties.Settings.Default.Save();
            textBox2.Text = WindowsFormsApplication1.Properties.Settings.Default.Age.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsFormApplication1.Properties.Settings.Default.Name = textBox1
                .text;
            WindowsFormApplication1.Properties.Settings.Default.Age = Convert.ToInt32(textBox2.Text);
            WindowsFormApplication1.Properties.Settings.Default.ButtonA = button1; 
            WindowsFormsApplication1.Properties.Settings.Default.Save();
        }
    }
}
