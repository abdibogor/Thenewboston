<?php
$conn_error = 'Could not connect.';

$mysql_host = 'http://localhost:8080/dashboard/';
$mysql_user = 'root';
$mysql_pass = '';

$mysql_db = 'bogoreh';

/*
@mysql_connect($mysql_host, $mysql_user, $mysql_pass);
@mysql_select_db($mysql_db);

echo 'Ok.';
*/

/*
if(!mysql_connect($mysql_host, $mysql_user, $mysql_pass)) {
	if (!mysql_select_db($mysql_db)) {
		echo 'Ok.';
	}
 }
*/

f(!@mysql_connect($mysql_host, $mysql_user, $mysql_pass)||!@mysql_select_db($mysql_db)) {
    die($conn_error);
 } 
 
//echo 'Connected!';
?>