<?php
//opens connection to mysql server
$dbc = mysql_connect('loacalhost','bogoreh','password');
if (!$dbc) {
	 die('Not connected' : . mysql_error());
 }
 
 //select database
 $db_selected = mysql_select_db("bogoreh", $dbc);
 if (!$db_selected)
 {
	 die ("cant connect :" .  mysql_error);
 }
 
 //test
 $query="UPDATE game SET email='hopethisworks' WHERE username='abdibogoreh'";
  $result=mysql_query($query);
?>