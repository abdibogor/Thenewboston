using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem 1v1 = new ListViewItem(TextBox.Text);
            1v1.SubItem.Add(textBox2.Text);
            1v1.SubItem.Add(textBox3.Text);
            ListView1.Item.Add(1v1);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void getNameOfItemToolStripNameItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItem.Count != 0)
            {
               foreach (ListViewItem 1v1 in ListView.selectItems)
                  MessageBox.Show(1v1.SubItem[0].Text);
            }
        }

        private void removeSelectedItemToolStripNameItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItem.Count != 0)
            {
               foreach (ListViewItem 1v1 in ListView.selectItems)
                  1v1.Remove();
            }
        }

        private void removeAllItemToolStripNameItem_Click(object sender, EventArgs e)
        {
            listView1.Item.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            foreach (ListViewItem 1v1 in listView1.Item)
                 if (1v1.Checked) 1v1.Remove();
        }
    }
}
