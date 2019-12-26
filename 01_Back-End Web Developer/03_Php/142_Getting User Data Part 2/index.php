<?php
  require 'core.inc.php';
  require 'connect.inc.php';
   
   if(loggedin()) {u
	   $firstname = getuserfield('firstname');
	   $surname = getuserfield('surname');
	   echo 'You \'re logged in. '.$firstname.' '.$surname.'. <a href="logout.php">Log out</a>';
	   //echo getuserfield('idontexist');
      } else {
	   include 'loginform.inc.php';
      } 
?>