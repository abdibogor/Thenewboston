<?php
	
	function hit_count() {
		$filename ='count.txt';
		 $handle = fopen('count.txt', 'r');
		 $current = fread($handle, filesize($filename));	 
		 //echo $current;
		 fclose($handle);
		//echo $current_inc = $current + 1;
		$current_inc = $current + 1;
		
		$handle = fopen($filename, 'w');
		fwrite($handle, $current_inc);
		fclose($handle);
	}
	
?>