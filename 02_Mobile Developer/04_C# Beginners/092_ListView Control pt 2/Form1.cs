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
                MessageBox.Show(listView1.SelectedItem[0].SubItem[0].Text);
            }
        }
    }
}
