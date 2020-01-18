using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNamespace
{
    class MyClass
    {
        public string Name = "Bob";
        protected int Age = 10;
        public virtual void ShowMessage(string Message)
        {
            System.Windows.Forms.MessageBox.Show(Message);
        }
    }

        class MySecondClass : MyClass
        {
            public string MainColor = "Brown";    
            public override void ShowMessage(string message)
            {
               System.Windows.Forms.MessageBox.Show(Message, "My title");
            }
    }
}

