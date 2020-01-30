import java.awt.*;
import java.awt.Event.*;
import javax.swing.*;

public class Gui extends JFrame{
      private JPanel mousepanel;
      private JLabel statusbar;
      
      public Gui(){
          super("title");
          
          mousepanel = new JPanel();
          mousepanel.setBackground(Color.WHITE);
          add(mousepanel, BorderLayout.CENTER);
          
          statusbar = new JLabel("default");
          add(statusbar, BorderLayout.SOUTH);
          
          Handlerclass Handler = new Handlerclass();
          mousepanel.addMouseListener(handler);
          mousepanel.addMouseMotionListener(handler);
      }
      
	/*075_MouseListener interface*/
        private class HandlerClass implements MouseListener, MouseMotionListener{
            public void mouseClicked(MouseEvent event) {
                statusbar.setText(String.format("Clicked at %d,%d", event.getX(), event.getY()));
            }
            public void mousePressed(MouseEvent event) {
                   statusbar.setText("you pressed down the mouse"); 
            }    
            public void mouseReleased(MouseEvent event) {
            statusbar.setText("you released the button");
            }   
            public void mouseEntered(MouseEvent event) {
             statusbar.setText("you entered the area");
             mousepanel.setBackground(Color.RED);
           }              
           public void mouseExited(MouseEvent event) {
                statusbar.setText("the mouse had left the window");
                mousepanel.setBackground(Color.WHITE);
           }       
     }
}