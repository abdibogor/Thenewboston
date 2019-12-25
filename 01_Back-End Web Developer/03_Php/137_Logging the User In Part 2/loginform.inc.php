<?php
/*
require 'core.inc.php';
echo $current_file;
*/

if (isset($_POST['username'])&&isset($_POST['Password'])) {
	$username = $_POST['username'];
	$password = $_POST['password'];
	
	 if (!empty($username)&&!empty($password)) {
		 echo 'Ok.';
	 } else {
		 echo 'You must supply a username and password.';
	 }
}

?>

<form action="<?php echo $current_file; ?>" method="POST">
Username : <input type="text" name="username">
Password: <input type="password">
<input type="submit" value="Log in">

</form>