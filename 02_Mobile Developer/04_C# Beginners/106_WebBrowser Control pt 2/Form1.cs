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
        WebBrowser wb = new WebBrowser();
        private void button1_Click(object sender, EventArgs e)
        {
            wb.Navigate["https://www.quora.com/What-is-the-best-free-online-code-editor" + textBox1.Text + "Ang-4"];
            wb.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted);
        }

        void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //throw new NotImplementedException();
            label1.Text = "Armory Completion: " + wb.Document.GetElementById("ct100_mainContent_LastPlayedLabel").InnerText;
        }
     }
}