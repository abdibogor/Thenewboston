using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Folder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fsd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.syncInFolder.Mydocuments;
            fbd.Description = "Adam was here.";
            if (fbd.showDialog() == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show.(fbd.SelectedPath);
        }
    }
}
