<?php
/*
$filename = 'names.txt';
$handle = fopen($filename, 'r');
//echo fread($handle, 1000);

//echo fread($handle, filesize($filename));
echo fread($handle, 5);
*/

$filename = 'names.txt';
$handle = fopen($filename, 'r');

$datain = fread($handle, filesize($filename));

$names_array = explode(', ', $datain);

//foreach($names_array as $name) {
	//echo $name.'.<br>';
//}

echo $names_array[0];


?>

