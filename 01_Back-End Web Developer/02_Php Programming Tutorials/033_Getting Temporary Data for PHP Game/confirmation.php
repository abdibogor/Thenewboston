<?php
include('connect.php');
	 
//set variable
$passkey=$_GET['passkey'];

$sql="SELECT * FROM temp WHERE code='$passkey'";
$result1=mysql_query($sql1);

//if successfully queried
if($result1){
	
	//how many rows have key
	$count=mysql_num_rows($result1);
	
	//if passkey is in database, retrieve data
	if($count==1){
		
	$rows=mysql_fetch_array($result1);
    $namex=$rows['username'];	
	$emailx=$rows['email'];
    $passwordx=$rows['password'];
	
	//takeoutspace
	$name=str_replace(' ','',$namex);
	$email=str_replace(' ','',$emailx);
	$password=str_replace(' ','',$passwordx);
}
	
}

?>