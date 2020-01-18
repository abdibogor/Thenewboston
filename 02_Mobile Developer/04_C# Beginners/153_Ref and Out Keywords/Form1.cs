using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forms1.cs
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
            int Age = 3;
            Modify(Age);
            MessageBox.Show(Age.ToString());
            */
            int Age = 3;
            string name;
            Modify(ref Age, out name);
            MessageBox.Show(Age.ToString() + "::" + name);
        }

        void Modify(int age, out string Name)
        {
            Name = "Adam";
            age += 5;
        }
    }
}
