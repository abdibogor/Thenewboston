<?php
/*
     echo $_GET['text']; 
 */

     mysql_connect('localhost', 'root', '');
     mysql_select_db('ajax');

if (isset($_POST['text'])) {
	 //echo 'ok';
	$text = $_POST['text'];
	if (!empty($text)) {
		//echo 'OK.';

		$query = "INSERT INTO `data` VALUES ('', '".mysql_real_escape_string($text)."')";
		if($query_run = mysql_query($query)) {
			echo 'Data inserted.';
		} else {
			echo 'Failed.';
		}
	} else {
		echo 'Please type something.';
	}
}
?>