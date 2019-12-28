<?php
require 'conf.inc.php';

// first example echo $ip_address;	

foreach($ip_blocked as $ip) {
	//echo $ip.'<br>';
	if ($ip==$ip_address) {
		die('Your IP address, '.$ip_address.' has been blocked.');
	}
}
?>

