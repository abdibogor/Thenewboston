<?php
   require 'core.inc.php';
   
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
		$firstname = $_POST['firstname'];
		$surname = $_POST['surname'];
		
		if (!empty($username)&&!empty($password)&&!empty($password_again)&&!empty($firstname)&&!empty($surname)) { 
			echo 'OK.';
			} else {
				echo 'All fields are required.';
			}	
	}
?>

<form action="register.php" method="POST">
Username:<br>
<input type="text" name="username" value="<?php echo $surname; ?>"><br><br>
Password:<br> <input type="password" name="password"><br><br>
Password_again:<br> <input type="password" name="password_again"><br><br>
Firstname:<br> <input type="text" name="firstname" value="<?php echo $surname; ?>"><br><br>
Surname:<br> <input type="text" name="surname" value="<?php echo $surname; ?>"><br><br>
<input type="Submit" value="Register">
</form>


<?php
	   //echo 'Register.';
   } else if (loggedin()) {
	   echo 'You\'re already registered and logged in.';
 }
   
?>