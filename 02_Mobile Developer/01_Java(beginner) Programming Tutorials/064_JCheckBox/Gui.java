import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Gui extends JFrame{
	private JTextField tf;
	private JCheckBox boldbox;
	private JCheckBox italicbox;
	
	public Gui() {
		super("the title");
		setLayout(new FlowLayout());
		
		tf = new JTextField("This is a sentence", 20);
		tf.setFont(new Font("Serif", Font.PLAIN, 14));
		add(tf);
		
		boldbox = JCheckBox("bold");
		italicbox = new JCheckBox("italic");
		add(boldbox);
		add(italicbox);
		
		HandlerClass handler = new HandlerClass();
		boldbox.addItemListener(handler);
		italicbox.addItemListener(handler);
	}
	
}