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
            XmlTextWriter xWriter = new XmlTextWriter("C:\\USERS\\Adam\\Desktop\\Test Folder\\xDoc1.xml);
                xWriter.Formatting = Formatting.Indented;
                xWriter.WriteStartElement("People");
                xWriter.WriteStartElement("Person"); //<Person>
                xWriter.WriteStartElement("Name"); //<Name>
                xWriter.WriteString(textBox1.text); //TextBox1.Text
                xWriter.WriteEndElement(); //</Name>
                xWriter.writeStartElement("Age"); //</Name>
                xWriter.WriteToString(numericUpDown1.Value.ToString()); //TextBox1.Text
                xWriter.WriteEndElement(); //</Name>
                xWriter.WriteStartElement("Email"); //<Email>
                xWriter.WriteString(textBox1.text); //TextBox1.Text
                xWriter.WriteEndElement(); //</Name>
                xWriter.WriteEndElement(); //</Person>
                xWriter.WriteEndElement();
                xWriter.Close();
        }
    }
}
