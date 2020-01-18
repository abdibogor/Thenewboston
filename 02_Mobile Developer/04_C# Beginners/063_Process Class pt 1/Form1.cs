using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            {
                //Process.Start("Notepad.exe");
                //Process.Start("cmd.exe");
                //MessageBox.Show(Process.GetCurrentProcess().ProcessName);
                Process.SetCurrentProcess().kill();
            }      
    }
}
