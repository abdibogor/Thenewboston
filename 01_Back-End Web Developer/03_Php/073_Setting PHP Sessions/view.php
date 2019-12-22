<?php
session_start();

//echo $_SESSION['name'];

if (isset($_SESSION['username'])) {
	echo 'Welcome, '.$_SESSION['username'];
 }  else {
	echo 'Please log in.';
 }

?>