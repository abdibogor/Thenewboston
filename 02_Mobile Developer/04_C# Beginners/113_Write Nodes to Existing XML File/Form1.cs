using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Writing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Adam\\Desktop\\Test Folder\\xDoc1.Xml");
            xmlMode person = doc.CreateElement("Person");
            XmlNode name = doc.CreateElement("Name");
            Name.innerText = textBox1.Text;
            person.AppendChild(name);
            XmlNode Age = doc.CreateElement("Age");
            age.innerText = numericUpDown1.Value.ToString();
            person.AppendChild(age);
            XmlNode email = doc.CreateElement("email");
            email.innerText = textBox1.Text;
            person.AppendChild(email);
            doc.DocumentElement.AppendChild(person);
            doc.Save["C:\\Users\\Adam\\Desktop\\Test Folder\\xDoc1.Xml"];
        }
    }
}
