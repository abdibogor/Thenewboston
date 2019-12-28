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
	
} 

$query = "SELECT `food`, `calories`, FROM `food` WHER  `healthy_unhealthy`='u' AND `calories`='700' ORDER BY `id` DESC";

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
/*
 else {
	//echo 'Query failed.';
	echo mysql_error();
}
*/
?>