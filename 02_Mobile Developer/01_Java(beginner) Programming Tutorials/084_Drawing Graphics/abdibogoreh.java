import javax.swing.*;

public class abdibogoreh {
	public static void main(String[] args) {

		JFrame f = new JFrame("Title");
		f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		Peach p = new Peach();
		f.add(p);
		f.setSize(400,250);
		f.setVisible(true);
		
	  }
}