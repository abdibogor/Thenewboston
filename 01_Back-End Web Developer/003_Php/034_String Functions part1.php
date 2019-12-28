<?php
    
	/* first example
	$string = 'This is an example string.';
	$string_word_count = str_word_count($string, 1);

     echo $string_word_count;	
	*/
	
	/* second example
	$string = 'This is an example string.';
	$string_word_count = str_word_count($string, 0, '.');

     print_r($string_word_count);
	*/
	
	/* third example
	$string = 'This is an example string.';
	$string_word_count = str_word_count($string, 0, '.');

    echo $string_word_count;
	*/
	
	$string = 'This is an example string .';
	$string_word_count = str_word_count($string, 1, '.');

    print_r($string_word_count);
	
	
?>