import java.awt.*;
import java.awt.event.*;
import java.swing.*;
import java.swing.event.*;
import javax.swing.JList;

public class Gui extends JFrame{
	
	private JList leftlist;
	private JList rigthlist;
	private JButton movebutton;
	private static String[] foods = {"bacon", "wings", "ham", "beef", "morebacon"};
	
	public Gui(){
		super("title");
		setLayout(new FlowLayout());
		
		leftlist = new JList(foods);
		leftlist.setVisibleRowCount(3);
		leftlist.setSelectionMode(ListselectionModel.MULTIPLE_INTERVAL_SELECTION);
	        add(new JScrollPane(leftlist));
	    
	    movebutton = new JButton("Move -->");
	    movebutton.addActionListener(
	    		new ActionListener(){
	    			  public void actionPerformed(ActionEvent event){
	    				  rightlist.setListData(leftlist.getSelectedValues());
	    			   }
	    	    }
	      );
	    add(movebutton);
	    
	    rightlist = new JList();
	    rightlist.setVisibleRowCount(3);
	    rightlist.setFixedCellWidth(100);
	    rightlist.setFixedCellHeight(15);
	    rightlist.setSelectionMode(ListSelectionModel.MULTIPLE_INTERVAL_SELECTION);
	    add(new JScrollPane(rightlist));
	    
	}	
}