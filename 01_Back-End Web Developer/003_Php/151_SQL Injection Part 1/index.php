<?php
	$username =$_POST['username'];
	$password =$_POST['password'];
	
	SELECT `id` FROM `users` WHERE `username`=`$username`  AND `password`=`$password`

?>