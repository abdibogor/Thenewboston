<?php
	  require 'connect.inc.php';
	  $user_ip = $_SERVER['REMOTE_ADDR'];
	  
	  //echo $user_ip;
	  
	  function ip_exists($ip) {
		   global $user_ip;
		   echo $user_ip;
	  }
	  
	  //ip_exists('127.0.0.1')
	  
	  function update_count() {
		  
	  }
	  
	  ip_exists('1');
	  
?>