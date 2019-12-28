<?php
	/* first example
	$string = 'I Could be Any Case.';
	$string_lower = strtolower($string);
	$string_upper = strtoupper($string);
	
	echo $string_upper;
	*/
	
	if (isset($_GET['user_name'])&&!empty($_GET['user_name'])) {
		 $user_name = $_GET['user_name'];
	     $user_name_lc = strtolower($user_name);
		 
	if ($user_name_lc=='alex') {
		echo 'You are the best, '.$user_name;
	   }	
	} 
?>

		<form action="index.php"  method="GET">
 Name: <input type="text" name="user_name"><br><br>
		  <input type="submit" Value="Submit">
		</form> 