<?php
  require 'core.inc.php';
  require 'connect.inc.php';
   
   if(loggedin()) (isset($_SESSION['user_id'])&&!empty($_SESSION['user_id'])) {
	   echo 'You \'re logged in.';
   } else {
	   include 'loginform.inc.php';
   } 
?>