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
            TreeNode tn = new TreeNode();
            tn.Text = "Person";
            tn.ImageIndex = 3;
            tn.SelectedImageIndex = 3;
            treeView1.Nodes.Add(tn);
            TreeNode t = new TreeNode();
            t.Text = "Animal";
            t.ImageIndex = 0;
            t.SelectedImageIndex = 0;
            treeView1.Nodes.Add(t);
            TreeNode tc = new TreeNode();
            tc.Text = "Cat";
            tc.ImageIndex = 2;
            tc.SelectedImageIndex = 2;
            treeView1.Nodes[1].Nodes.Add(tc);
        }
    }
}
