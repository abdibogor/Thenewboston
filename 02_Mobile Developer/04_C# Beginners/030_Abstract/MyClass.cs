using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Partial
{
    abstract class MyClass
    {
        public string Name = "Mr.Smith";
        public int Age = 30;
        partial void Message(string message);
     {
         System.Windows.Forms.MessageBox.Show(message);
      }
      public abstract void showMessage(string message)
    }
    class MySecondClass MyClass
    {
        public override void ShowMessage(string message)
        {
           System.Windows.Forms.MessageBox.Show(message);
        }
    }
}
