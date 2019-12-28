<?php
	
	$ip_address = $_SERVER['REMOTE_ADDR'];
	
	function hit_count() {
			$ip_file = file('ip.txt');	
			foreach($ip_file as $ip) {
			//echo $ip.'<br>';
			echo trim($ip).',';
		}
	}	
?>