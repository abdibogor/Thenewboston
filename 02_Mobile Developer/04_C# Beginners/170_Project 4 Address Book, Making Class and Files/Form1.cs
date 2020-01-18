using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\Address Book - Adam"))
                 Directory.CreateDirectory(path + "\\Address Book - Adam");
            if (!File.Exists(path + "\\Address Book - Adam\\settings.xml"));
                 File.Create((path + "\\Address Book - Adam\\settings.xml"));
        }
    }

    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string StreetAddress
        {
            get;
            set;
        }
        public string AdditionNotes
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }
    }
}
