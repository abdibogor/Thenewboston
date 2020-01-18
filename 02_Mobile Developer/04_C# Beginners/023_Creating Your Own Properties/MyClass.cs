using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor
    class MyClass
    {
        string myString;
        public MyClass(string name)
        {
            myString = name;
            //Name = name;
            name = name;
        }

        public string name
        {
            //get;
            get { return myString;}
            set 
            {
                 if (value == "") System.Windows.Forms.MessageBox.Show("You can't do what");
            }
        }
    }
}

