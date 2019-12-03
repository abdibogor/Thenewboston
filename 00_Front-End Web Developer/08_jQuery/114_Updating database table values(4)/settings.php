<?php
include "init.php';

if (isset($_POST['name'], $_POST['email'])) {
	$name = mysql_real_escape_string(htmlentities($_POST['name'])); 
	$email = mysql_real_escape_string(htmlentities($_POST['email'])); 
	
	$update = mysql_query("UPDATE `users` SET `name`=`'$name', email`='$email' WHERE `user_id`="$_SESSION['user_id']);
	if ($update === true) {
		echo 'Settings have been updated.';
	} else if($update === false) {
		echo 'There was an erro updating your settings.';
		}
	} 
?>