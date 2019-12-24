<?php
$conn_error = 'Could not connect.';

$mysql_host = 'http://localhost:8080/dashboard/';
$mysql_user = 'root';
$mysql_pass = '';

$mysql_db = 'a_database';

@mysql_connect($mysql_host, $mysql_user, $mysql_pass) or die('$conn_error');
mysql_select_db($mysql);

echo 'Connected!';
?>