<?php

$offset = 0;

$find = 'string';
$find_length = strlen($find);

$string = 'This is a string, and it is an example.';

//echo strpos($string, $find, 10);

while ($string_position = strpos($string, $find, $offset)) {
	echo '<strong>'.$find.'</strong> found at '.$string_position.'<br>';
	$offset = $string_position + $find_length;
}

?>