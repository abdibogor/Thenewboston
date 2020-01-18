using System;
using System.Collections.Generic;
using System.componentMethode1;
using System.Data;
using System.Ling;
using System.Text;
using System.Windows.Forms;
using MyNamespace;

namespace Youtube
{
     public partial class Form1 : form
	 {
		 public form1()
		 {
			 initializeComponent();
		 }
		 
		 private void button1_click(objecst sender, EventArgs e)
		 {
			 MySecondClass asc = new MySecondClass();
			 asc.ShowMessage("Message");
		 }	 
	 }
}