using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class MyClass
    {
        public event EventHandler OnPropertyChanged;

            string name = "";
            public string Name
        {
            get { return name; }
            set
            {
                Name = value;
                OnPropertyChanged(this, new EventArgs());
            }
        }
    }
}
