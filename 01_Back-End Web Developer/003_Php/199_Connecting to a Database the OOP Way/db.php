<?php
	 
   class DatabaseConnect {
		   public function __construct($db_host, $db_username, $db_password) {
			   //echo 'Hello.';
			   //echo $db_host.'<br>'.$db_username.'<br>'.$db_password;
			  
			if (!@$this->Connect($db_host, $db_username, $db_password)) {
			  echo 'Connection failed.';
			} echo 'Connected to '.$db_host;
			 }
			   
		   }
		   
		   public function Connect($db_host, $db_username, $db_password) {
    
		   }
		   
	  }

	  
	  //$connection = new DatabaseConnect('localhost','root','password');	  
	  
?>