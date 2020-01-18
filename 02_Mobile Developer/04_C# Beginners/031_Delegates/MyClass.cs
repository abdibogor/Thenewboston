using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    class MyClass
    {
        delegate void MyDelegate(string myString);
        public void ShowThoseMessages()
        {
            MyDelegate ad = new MyDelegate(ShowMessage);
            ad += Showanothermessage;
            ad("Adam");
        }
        void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        void ShowAnotherMessage(string e)
        {
            System.Windows.Forms.MessageBox.Show(e, "Test");
        }
    }
}
