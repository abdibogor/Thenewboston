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
	
	
	//inster into users table
	$sql2="INSERT INTO users SET username='$name', email='$email'";
	$result2=mysql_query($sql2);
	
	//gamestats table 
	$sql3="INSERT INTO gamestats SET username='$name', money='0'";
	$result3=mysql_query($sql3);
}else{
	echo "Wrong confirmation code";
 }
	
	if($result2){
	header("Location:confirmation2.html");
		
	//remove from temp
	$sql5="DELETE FROM temp WHERE code='passkey'";
	$result5=mysql_query($sql5);
	}
	
	
	
}

?>