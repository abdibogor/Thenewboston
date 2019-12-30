<?php
$connect = mysql_connect('localhost','danielle_sally','pass123');
if(!$connect){die('Could not connect to database!');}
mysql_select_db("danielle_youtube", $connect);
?>