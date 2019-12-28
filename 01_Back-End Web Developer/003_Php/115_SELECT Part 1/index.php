<?php
require 'connect.inc.php';

//echo 'Ok';

$query = "SELECT `food`, `calories` FROM `food` ORDER BY `id`";
$query_run = mysql_query($query) or die;

if ($query_run = mysql_query($query)) {
	echo 'Query success.';
} else {
	echo 'Query failed.';
}

?>