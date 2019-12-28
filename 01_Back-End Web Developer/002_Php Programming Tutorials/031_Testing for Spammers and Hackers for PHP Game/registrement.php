<?php
include('connection.php');	
//test to see if username is alphannumeric
$test=$_POST[username];

if(!eregi("([^A-Za-zo-9]"),$test)){
	
	//test for duplicate names
	$query="SELECT * FROM users WHERE username = '$_POST[username]'";
	$result=mysql_query($query);
	$num=mysql_num_rows($result);
	
	if ($num == 0){
		
	}else{
		header ("Location:nameinuse.html");
	}
	
}else{
	header("location:invalidname.html");
}

?>