using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor
{
    class MyClass
    {
        enum Names : byte
        { 
          Adam = 1, 
          Joe = 4,
          Bob,
        }
        string Name;
        public MyClass(string name)
        {
           Name: name;
        }
        
           string name()
        {
            return Name;
        }

        namespace myName = Names.Adam;

        public static void ShowMessage(string message) 
        {
            System.Windows.form.MessageBox.show(message);
        }
        public static void ShowMessage(string message)
        {
            System.Windows.form.MessageBox.show(message.ToString);
        }
    }
}

