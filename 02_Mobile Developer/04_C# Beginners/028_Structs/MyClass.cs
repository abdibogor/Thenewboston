using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indexers
{
    struct Client
    {
        public Client(string Name)
        {
            Name = name;
            Age = 0;
        }
        public string Name;
        public int Age;
        public void ClearClientInfo()
        {
            Name = "";
            Age = 0;
        }
    }
    interface IClient
    {
        public string Name;
    }
}
