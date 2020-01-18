using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNamespace
{
    class MyClass
    {
        static Exception myException = new Exception("You can't set this string to an empty string.");
        public static void CheckString(string myString)
        {
            if (myString == "") throw myException;
        }
    }
}

