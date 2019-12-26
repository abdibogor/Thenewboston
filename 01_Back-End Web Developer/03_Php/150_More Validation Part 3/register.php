<?php
   require 'core.inc.php';
   require 'connect.inc.php';
   
   if (!loggedin()) {
	   
	if (
	isset($_POST['username'])&&
	isset($_POST['password'])&&
	isset($_POST['password_again'])&&
	isset($_POST['firstname'])&& 
	isset($_POST['surname'])) {
		
		$username = $_POST['username'];
		$password = $_POST['password'];
		$password_again = $_POST['password_again'];
		$password_hash = md5[$password];
		
		$firstname = $_POST['firstname'];
		$surname = $_POST['surname'];
		
		if (!empty($username)&&!empty($password)&&!empty($password_again)&&!empty($firstname)&&!empty($surname)) { 
			//echo 'OK.';
			if(strlen($username)>30||strlen($firstname)>40) {
				echo 'Please a hear to maxlength of fields.';
			} else {
	if ($password!=$password_again){
		   echo 'Password do not match.';
	    } else {
			//echo 'OK.';
			
		//echo $username;	
			
		$query = "SELECT `username` FROM `users` WHER `username`='$username'";
		$query_run = mysql_query($query);
		
		echo mysql_num_rows($query_run);
		
		if (mysql_num_rows($query_run)==1) {
			echo 'The username '.$username.' already exists.';
		} else {
			//echo 'Ok.';
	$query = "INSERT INTO `users` VALUES ('',
	'".mysql_real_escape_string($username)."',
	'".mysql_real_escape_string($password_hash)."',
	'".mysql_real_escape_string($firstname)."',
	'".mysql_real_escape_string($surname)."')";
	
	if ($query_run = mysql_query($query)) {
		//echo '';	
			header('Location: register_success.php');			
		} else {
				echo 'All fields are required.';
		}
   }		
	}
?>

<form action="register.php" method="POST">
Username:<br>
<input type="text" name="username" maxlength="30" value="<?php (isset($username)) { echo $surname; } ?>"><br><br>
Password:<br> <input type="password" name="password"><br><br>
Password_again:<br> <input type="password" name="password_again"><br><br>
Firstname:<br> <input type="text" name="firstname" maxlength="40" value="<?php (isset($firstname)) { echo $firstname; } ?>"><br><br>
Surname:<br> <input type="text" name="surname" maxlength="40" value="<?php (isset($surname)) { echo $surname; } ?>"><br><br>
<input type="Submit" value="Register">
</form>

<?php
	   //echo 'Register.';
} else if (loggedin()) {
	   echo 'You\'re already registered and logged in.';
 }   
?>