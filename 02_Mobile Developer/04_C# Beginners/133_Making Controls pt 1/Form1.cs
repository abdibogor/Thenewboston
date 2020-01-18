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
            SolidBrush s = new SolidBrush(Color.FromKnowColor(KnowColor.Control));
            Graphics g = this.CreateGrpahics();
            g.FillRectangle(s. 0, 0, this.Width, this.Height);
        }
    }
}
