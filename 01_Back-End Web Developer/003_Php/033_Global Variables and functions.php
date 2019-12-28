<?php
/*
		$user_ip = $_SERVER['REMOTE_ADDR'];	
		echo $string = 'Your IP address is: '.$user_ip;	
		function echo_ip() {
			$string = 'You IP address is:'.$user_ip;
		}
*/

/* second example
    $user_ip = $_SERVER['REMOTE_ADDR'];		
	function echo_ip() {
		global $user_ip;
			$string = 'Your IP address is: '.$user_ip;
	       echo $string;
		}
		
		echo_ip();
	*/	
	 $user_ip = $_SERVER['REMOTE_ADDR'];	
	
	function echo_ip() {
		  $user_ip = $_SERVER['REMOTE_ADDR'];	
		  $string = 'Your IP address is: '.$user_ip;
	      echo $string;
		}
		
		echo_ip();	
?>