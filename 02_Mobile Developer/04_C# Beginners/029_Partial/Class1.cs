using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Partial
{
    partial class MyClass
    {
        public string MainColor = "Brown";
        public bool classes = false;
        partial void Message(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        public void ShowMessage(string message)
        {
            Message(message);
        }
    }
}