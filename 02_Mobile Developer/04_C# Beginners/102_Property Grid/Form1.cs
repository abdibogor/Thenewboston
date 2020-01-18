using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Property
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p.name = "Adam";
            p.Age = 15;
            p.Email = "abdi@gmail.com";
            propertyGrid1.SelectedObject = p;
            Reload();
        }
        void Reload()
        {
            textBox1.Text = p.Name;
            textBox2.Text = p.Age.ToString();
            textBox3.Text = p.Email;
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Reload();
        }
    }
    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
    }
}
