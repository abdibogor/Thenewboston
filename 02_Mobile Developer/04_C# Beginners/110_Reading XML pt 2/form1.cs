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
               XmlDocument xDoc = new XmlDocument();
               xDoc.Load(ofd.FileName);
               //xDoc.Load("itzadam5x.webs.com/People.xml");
               //MessageBox.Show(xDoc.SelectSingleMode("People/Person/Name").InnerText);
               foreach (xmlcode node In xDoc.SelectNodes("People/Person"))
                    MessageBox.Show(node.SelectingleNode["Name"].InnerText);
            }
        }
    }
}
