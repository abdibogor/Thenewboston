using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter =  "10% |". xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                xmlDocument xBox = new xmlDocument();
                xBox.LoadOfd.FileName();
               MessageBox.Show(XDoc.SelectSingleMode("People/Peson/Name").innerText);
            }
       
    }
}
