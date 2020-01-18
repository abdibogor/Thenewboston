using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class UserControl1 : Button
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private override string text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (value == "Adam")
                {
                    MessageBox.Show("You are not authorized to use that name.");
                    base.Text = "UserControl1";
                    return;
                }
                    base.Text = value;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("Hello");
            base.OnClick(e);
        }
    }
}
