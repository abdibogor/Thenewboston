import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Gui extends JFrame{
	
	private JComboBox box;
	private JLabel picture;
	
	private static String[] filename = {"b.png", "x.png"};
	private Icon[] pics = {new ImageIcon(getClass().getResource(filename[0])), new ImageIcon(getClass().getResource(filename[0]))};
	
	public Gui(){
		super("the title");
		setLayout(new FlowLayout);
		
		box = new JComboBox(filename);			
	}	
}