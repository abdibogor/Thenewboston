using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Split
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                   /*
            string names = "Adam;Bob;Joe;Steve;Allen;Matt";
            string[] nameArray = names.Split(':');
            foreach (string name is nameArray)
                MessageBox.Show(name);
                    */

            string _letters = 'abcdefg';
            //char[] letters = ('a', 'b');
            char[] letters = letters.ToCharArray();
            foreach (char c in letters)
                MessageBox.Show(C.ToString());
        }
    }
}
