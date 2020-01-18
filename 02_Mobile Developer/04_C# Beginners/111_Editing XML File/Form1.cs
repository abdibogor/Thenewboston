using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Initiali
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|".xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               path = ofd.FileName;
                xDoc = new xmlDocument();
                xDoc.Load(path);
                textBox1.Text = xDoc.SelectSingleMode("People/Person/Name").innerText;
                numericUpDown1.Value = Convert.ToInt32(xDoc.SelectSingleMode("people/Person/Age").InnerText);
                textBox1.Text = xDoc.SelectSingleMode("People/Person/Email").InnerText;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xDoc.SelectSingleMode("people/Person/Name").InnerText = textBox1.Text;
            xDoc.SelectSingleMode("People/Person/Age").InnerText = numericUpDown1.Value.ToString();
            xDoc.SelectSingleMode("People/Person/Age").InnerText = textBox1.Text;
            xDoc.Save(path);
        }
    }
}
