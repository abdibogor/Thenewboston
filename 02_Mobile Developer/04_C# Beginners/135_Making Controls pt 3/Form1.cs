using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Making
{
    public partial class MyButton : UserControl
    {
        public MyButton()
        {
            InitializeComponent();
        }

        private override void onPaint(object sender, EventArgs e)
        {
              /*
            SolidBrush s = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
            Graphics g = this.CreateGrpahics();
            g.FillRectangle(s, 0, 0, this.Width, this.Height);
            s.Color = Color.FromKnownColor(KnownColor.ControlDark);
            g.FillRectangle(s, 0, this.Height / 2, this.Width, this.Height / 2);
            label1.Location = new Point((this.Width / 2) - (label1.Width / 2), (this.Height / 2) - (label1.Height / 2));
              */
            SolidBrush s = new SolidBrush(Color.Blue);
            Graphics g = this.CreateGrpahics();
            g.FillRectangle(s, 0, 0, this.Width, this.Height);
            s.Color = Color.SkyBlue;
            g.FillRectangle(s, 0, this.Height / 2, this.Width, this.Height / 2);
            label1.Location = new Point((this.Width / 2) - (label1.Width / 2), (this.Height / 2) - (label1.Height / 2));
               }

        public string ButtonText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
    }
}
