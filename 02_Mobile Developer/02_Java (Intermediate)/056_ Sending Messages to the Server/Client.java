import java.io.*;
import java.net.*;
import java.awt.*;
import java.awt.event.*;

import javax.swing.*;

public class Client extends JFrame{
	
	private JTextField userText;
	private JTextArea chatWindow;
	private ObjectOutputStream output;
	private ObjectInputStream input;
	private String message = "";
	private String serverIP;
	private Socket connection;
	
	//constructor
	public Client(String host){
		super("Client");
		serverIP = host;
		userText = new JTextField();
		userText.setEditable(false);
		userText.addActionListener(
				new ActionListener(){
				public void actionPerformed(ActionEvent event){
					sendMessage(event.getActionCommand());
					userText.setText("");
				}
			}
		);
		add(userText, BorderLayout.NORTH);
		chatWindow = new JTextArea();
		add(new JScrollPane(chatWindow));
		setSize(300, 150); //Sets the window size
		setVisible(true);
	}
	
	//connect to server
	public void startRunning(){
		try{
			connectToServer();
			setupStreams();
			whileChatting();
		}catch(EOFException eofException){
			showMessage("\n Client terminated the connection");
		}catch(IOException ioException){
			ioException.printStackTrace();
		}finally{
			closeConnection();
		}
	}
	
	//connect to server
	private void connectToServer() throws IOException{
		showMessage("Attempting connection... \n");
		connection = new Socket(InetAddress.getByName(serverIP), 6789);
		showMessage("Connection Established! Connected to: " + connection.getInetAddress().getHostName());
	}
	
	//53_ Setting Up the Client Streams 
	//set up streams
	private void setupStreams() throws IOException{
		output = new ObjectOutputStream(connection.getOutputStream());
		output.flush();
		input = new ObjectInputStream(connection.getInputStream());
		showMessage("\n The streams are now set up! \n");
	}

	//053_Setting Up the client Streams
	//Set up streams to send and receive messages

	private void setupStreams() throws IOException{
		output = new ObjectOutputStream(connection.getOutputStream());
		output.flush();
		input = new ObjectInputStream(connection.getInputStream());
		showMessage("\n Dude your streams are now good to go! \n");
    }

      //054_WhileChatting Client
	//while chatting with server

	private void whileChatting() throws IOException{
	    ableToType(true);
		do{
		   try{
			message = (String) input.readObject();
			showMessage("\n" + message);
	     }catch(ClassNotFoundException classNotfoundException){
		   showMessage("\n I dont know that object type");
	     }
	}while(!message.equals("SERVER - END"));
   }

	//close the streams and sockets
	private void closeConnection(){
		showMessage("\n Closing the connection!");
		ableToType(false);
		try{
			output.close();
			input.close();
			connection.close();
		}catch(IOException ioException){
			ioException.printStackTrace();
		}
       }

		//056_Sending Messages to the Server
	        // Send messages to server
	  private void sendMessage(String message){
	  try{
		output.writeObject("CLIENT - " + message);
		output.flush();
		showMessage("\nCLIENT - " + message);
	   }catch(IOException ioException){
	  	chatWindow.append("\n something messed up sending message hoss!");
	} 
    }
}