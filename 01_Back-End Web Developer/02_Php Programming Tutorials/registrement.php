<?php
include('connection.php');
	
//test to see if username is alphannumeric
$test=$_POST[username];

if(!eregi("([^A-Za-zo-9]"),$test)){
	
}else{
	header("location:invalidname.html");
}

?>