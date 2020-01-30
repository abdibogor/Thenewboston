import java.awt.*;
import java.awt.event.*;
import java.swing.*;
import java.swing.event.*;

import javax.swing.JList;

public class Gui extends JFrame{
	
	private JList<E> leftlist;
	private JList rigthlist;
	private JButton movebutton;
	private static String[] food = {"bacon", "wings", "ham", "beef", "morebacon"}
	
	public Gui() {
		super("title");
		setLayout(new FlowLayout());
		
		leftlist = new JList(foods);
		leftlist.setVisibleRowCount(3);
		leftlist.setSelectionMode(ListselectionModel.MULTIPLE_INTERVAL_SELECTION);
	        add(new JScrollPane(leftlist));
	    
	    movebutton = new JButton("Move -->");
	    movebutton.addActionListener(
	    		new ActionListener(){
	    			  public void actionPerformed(ActionEvent event) {
	    				   rightlist.setListData(leftlist.getSelectedValues());
	    			   }
	    	    }
	      );
	    add(movebutton);
	}
	
}