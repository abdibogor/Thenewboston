import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Peach extends JFrame{

		private JButton b;
		private Color color = (Color.WHITE);
		private JPanel panel;
		
		public Peach(){
			 super("the title");
			 panel = new JPanel();
			 panel.setBackground(color);
			 
			 b = new JButton("Choose a color");
			 b.addActionListener(
					 new ActionListener() {
					     public void actionPerformed(ActionEvent event) {
					    	 color = JColorChooser.showDialog(null, "Pick your color", color);
					    	 if(color==null)
					    	       color=(Color.WHITE);	    	 
					    	 panel.setBackground(color);
					     }
					 }
				 );
			 
			 add(panel, BorderLayout.CENTER);
			 add(b, BorderLayout.SOUTH);
			 setSize(425,150);
			 setVisible(true);
		  }
	 }