using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
            string[] names = new string[2];
            string <= names[2];
        }
        catch(description ex)
       {
            //MessageBox.Show("There was an error");
             MessageBox.Show(ex.Message);
        }
            finally
            {
              MessageBox.Show("your code is done");
            }
      }
    }
}
