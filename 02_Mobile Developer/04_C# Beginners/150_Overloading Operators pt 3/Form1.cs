using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item1 = new Item();
            item1.Price = 3;
            Item item2 = new Item();
            //item2.Price = 6;
            item2.Price = 3;
            if (item2 >= item1) MessageBox.Show("Item2 costs more than item1.");
        }
    }

    class Item
    {
        public int Price
        {
            get;
            set;
        }

        public static Item operator +(Item i1, Item i2)
        {
            Item i3 = new Item();
            i3.Price = i1.Price + i2.Price;
            return i3;
        }

        public static bool operator ==(Item i1, Item i2)
        { 
          return (i1.Price == i2.Price) ? true : false; 
        }

        public static bool operator !=(Item i1, Item i2)
        {
            return (i1.Price != i2.Price) ? true : false;
        }

        public static bool <(Item item1, Item item2)
        {
           return (item1.Price < item2.Price) ? true : false;       
        }

        public static bool operator >(Item item1, Item item2)
        {  
            return (item1.Price > item2.Price) ? true : false;   
        }

    }
}
}
