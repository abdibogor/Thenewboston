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
        List<Person> people = new List<Person>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\Address Book - Adam"))
                 Directory.CreateDirectory(path + "\\Address Book - Adam");
            if (!File.Exists(path + "\\Address Book - Adam\\settings.xml"));
                 File.Create((path + "\\Address Book - Adam\\settings.xml"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = textBox1.Text;
            p.StreetAddress = textBox3.Text;
            p.Email = textBox2.Text;
            p.Birthday = dateTimePicker1.Value;
            p.AdditionNotes = textBox4.Text;
            people.Add(p);
            listView1.Items.Add(p.Name);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        { 
           textBox1.Text = people[listView1.SelectedItems[0].Index].Name;
           textBox2.Text = people[listView1.SelectedItems[0].Index].Email;
           textBox3.Text = people[listView1.SelectedItems[0].Index].StreetAddress;
           textBox4.Text = people[listView1.SelectedItems[0].Index].AdditionNotes;
           dateTimePicker1.Value = people[listView1.SelectedItems[0].Index].Birthday;         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remove();
        }

        void Remove()
        {
            try
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                people.RemoveAt(listView1.SelectedItems[0].Index);
            }
            catch 
            { }
        }
        
        private void removeToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
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
