import java.net.*;
import java.util.*;
import java.awt.*;
import java.applet.*;
import javax.swing.*;
import javax.swing.event.*;

public class BuckysSites3 {
	
	private HashMap<String, URL> websiteInfo;
	private ArrayList<String> titles;
	private JList mainList;
	
	//init
	public void init(){
		websiteInfo = new HashMap<String, URL>();
		titles = new ArrayList<String>();
		
		grabHTMLInfo();
		add(new JLabel("What website do you want to visit?"), BorderLayout.NORTH);
		mainList = new JList(titles.toArray());

		/*031_Listening for Users Events*/		

		mainList.addListSelectionListener(
				new ListSelectionListener() {
					public void valueChanged(ListSelectionEvent event){
					   Object object = mainList.getSelectedValue();
					   URL newDocument = websiteInfo.get(object);
					   AppletContext browser = getAppletContext();
					   browser.showDocument(newDocument);
						}
				  	}
				);
	}	
}
