<?php	  
require 'connect.inc.php';

if (isset($_POST['search_name'])) {
	$search_name = $_POST['search_name'];
	if (!empty($search_name)) {
		//echo 'OK.';
		
		$query = "SELECT `name` FROM `names` WHERE `name` like '%".mysql_real_escape_string($search_name)."%'";
		$query_run = mysql_query($query);
		
		if (mysql_num_rows($query_run){
		  
		  while ($query_row = mysql_fetch_assoc($query_run)) {
			  
		  }
		  
		} else {
		  echo 'No result found';
		}
	}
}		
		
?>

<form action="index.php" method="POST">
Name: <input type="text" name="search_name"> 
			 <input type="submit" value="Search">
</form>