<?php
require "db.php'

if (isset($_POST['username'])) {
		$username = mysql_real_escape_string($_ POST['username']);
		if (!empty($username))  {
			$username_query = mysql_query("SELECT COUNT(`user_id`) FROM `users` WHERE `username`=`$username`");
			
		}
}
?>