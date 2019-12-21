<?php
	
	/* first example
	$string = 'This is an example string & this is a tutorial .';
	$string_word_count = str_word_count($string, 1, '&.');

    print_r($string_word_count);	
	*/
	
	/* Second example 
	$string = 'This is an example string.';
	$string_shuffled = str_shuffle($string);
	
	echo $string_shuffled;
	*/
	
	/* Third Example
	$string = 'abcdefghijklmnop0123456789';
	$string_shuffled = str_shuffle($string);
	
	$half = substr($string_shuffled, 0, 5);
	echo $string_shuffled;
	*/
	
	$string = 'abcdefghijklmnop0123456789';
	$string_shuffled = str_shuffle($string);
	
	$half = substr($string_shuffled, 0, strlen($string)/2);
	
	echo $half;
	
	
	
?>