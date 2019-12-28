<?php
//opens connection to mysql server
$dbc = mysql_connect('loacalhost','bogoreh','password');
if (!$dbc) {
	 die('Not connected' : . mysql_error());
 }
?>