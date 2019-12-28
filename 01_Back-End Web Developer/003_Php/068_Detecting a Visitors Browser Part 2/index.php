<?php
 
 $browser = get_browser(null, true);
 //echo $browser['browser'];
 $browser = strtolower($browser['browser']);
 
 //echo $browser;
 //die();
 
 if ($browser!='chrome') {
		echo 'You\' not using Google Chrome: Please do!';
 }

?>