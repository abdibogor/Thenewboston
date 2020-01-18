using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IDisposable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                using (MyClass mc = new MyClass())
                { 
                   
                }
            }
        }
        class MyClass : IDisposable
        {
            Image i;
            public MyClass()
            {
                i = Image.FromFile("c:\\Users\\Adam\\publicField.png");
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        
            protected virtual void Dispose(bool b)
            {
                 if (b)
                 {
                     i.Dispose();
                 }
            }

            MyClass()
            {
               MessageBox.Show("Adam");
            }

    }
}