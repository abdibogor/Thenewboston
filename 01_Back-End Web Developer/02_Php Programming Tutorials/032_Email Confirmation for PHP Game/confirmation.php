<?php
include('connect.php');
	 
//set variable
$passkey=$_GET['passkey'];

$sql="SELECT * FROM temp WHERE code='$passkey'";
$result1=mysql_query($sql1);



?>