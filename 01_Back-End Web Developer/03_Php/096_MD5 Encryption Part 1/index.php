<?php

	/* first example
	$string = 'password';
	$string_hash = md5($string);
	echo $string_hash;
	*/
	
	if (isset($_POST['user_password'])&&!empty($_POST['user_password'])) {
		// second example echo 'ok.';
		$user_password = $POST['user_password'];
		
		
		
	} else {
		echo 'Please enter a password.';
	}
	
?>

<form action="index.php" method="POST">
Password: <input type="text" name="user_password"><br><br>
<input type="submit" value="Submit">
</form>