<?php
	
	function hit_count() {
		
			$ip_address = $_SERVER['REMOTE_ADDR'];
		
			$ip_file = file('ip.txt');	
			foreach($ip_file as $ip) {
			//echo $ip.'<br>';
			$ip_single = trim($ip);
			if ($ip_address==$ip_single) {
				$found = true;
				break;
			} else {
				$found = false;
			}
		}
		
		if ($found==true) {
			echo 'Found.';
		}
		
	}	
?>