<?php
		
		//str_replace();
		$find = array('is', 'string' , 'example');
		$replace = array('IS', 'STRING', '');
		
		$string = 'This is a string, and is an example.';
		$new_string = str_replace($find, $replace, $string);
		//$new_string = str_replace('$find', '', $string);
	    //$new_string = str_replace('string', '', $new_string);	
		
		echo $new_string;
	
		
	
?>