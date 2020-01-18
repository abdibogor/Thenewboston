using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyDLL
{
    public class Client
    {
        internal string Name
        {
            get;
            set;
        }
        internal int Height = 25;
        public int Age
        {
            get;
            set;
        }
    }
}
class myClass
{
    void MyMethod()
    {
       Clients.Client c = new Clients.Client();
       c.Height = "";
    }
  }
}