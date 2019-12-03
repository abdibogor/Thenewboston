<?php
include "init.php';

if (isset($_POST['name'])) {
	$name = mysql_real_escape_string(htmlentities($_POST['name'])); 
	
	$update = mysql_query("UPDATE `users` SET `name`=`'$name' WHERE `user_id`="$_SESSION['user_id']);
	if ($update === true) {
		echo 'Settings have been updated.';
	} else if($update === false) {
		echo 'There was an erro updating your settings.';
	}
	} 
?>