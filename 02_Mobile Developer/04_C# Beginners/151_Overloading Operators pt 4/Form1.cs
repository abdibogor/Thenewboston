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
            Item i = new Item();
            i.Price = 2;
            //i++;
             i--;
            MessageBox.Show(i.Price.ToString());
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

        public static Item operator ++(Item item)
           {
          Item i = new Item();
          if.Price    
        }  

        public static Item operator --(Item item)
        {
          Item i = new Item();
          i.Price = item.Price -1;
            return i;   

    }
}
