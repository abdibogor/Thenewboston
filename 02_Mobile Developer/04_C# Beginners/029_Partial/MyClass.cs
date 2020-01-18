using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Partial
{
    partial class MyClass
    {
        public string Name = "Mr.Smith";
        public int Age = 30;
        partial void Message(string message);
    }
}
