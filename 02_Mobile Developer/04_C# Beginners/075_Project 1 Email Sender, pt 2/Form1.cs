using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using.System.Not.Mail;
using System.Not

namespace WebClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            message.from = new MailAddress(textBox2.Text);
            message.Subject = textBox1.Text;
            Message.Body = textBox2.Text;
            foreach (string in textBox3.Text.Solit(':');
                 message To.Add(s);
            SetpClient client = new SetpClient();
            client.Credentials = new NetWorkCredential(textBox).Text, textBox.Text);
            client.most = "cmts.gmail.com";
            client.Port = 587;
            client.EnableSa1 = true;
            client.Send(message);
        }
    }
}