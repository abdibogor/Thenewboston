using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add('Ecole');
            treeView1.Nodes.Add('Animals');
            treeView1.Nodes[0].Nodes.Add("Adam");
            treeView1.Nodes[0].Nodes.Add("Bob");
            treeView1.Nodes[0].Nodes.Add("Joe");
            treeView1.Nodes[1].Nodes.Add("Dog");
            treeView1.Nodes[1].Nodes.Add("Cat");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Spot");
        }
    }
}
