<?php
require 'connect.inc.php';
?>

<form action="index.php" method="GET">
Choose a food type:
	<select name="uh">
	   <option>UnHealthy</option> 
	   <option>Healthy</option> 
	</select>
	<input type="submit" value="Submit"><br> 

</form>

<?php

if (isset($_GET['uh'])&&!empty($_GET['uh'])) {
	
	echo $uh = strtolower($_GET['uh']);

if ($uh=='u'||$uh=='h'){
$query = "SELECT `food`, `calories`, FROM `food` WHER  `healthy_unhealthy`='$uh' ORDER BY `id` DESC";

  if ($query_run = mysql_query($query)) {
	//echo 'Query success.';
	
	if (mysql_num_rows($query_run)==NULL) {
		echo 'No results found.';
	} else {
	while ($query_row = mysql_fetch_assoc($query_run)) {
		 $food = $query_row['food'];
		 $calories = $query_row['calories'];
		 
		 echo $food.' has '.$calories.' calories.<br>';		
    }		 
	  }      	
} else {
	echo mysql_error();
}
} else {
	echo 'Must be u . or h.';
}
?>