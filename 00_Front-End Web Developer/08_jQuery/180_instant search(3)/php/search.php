<?php
	require 'db.php';
	
if(isset($_POST['search_term'])) {
      $search_term = mysql_real_escape_string(htmlentities($_POST['search_term']));

	if(!empty($search_term)) {
              $search = mysql_query("SELECT `place`, `description` FROM `place` WHERE `places` LIKE '%$search_term%'");
              $result_count = mysql_num_rows($search);       
      
      } 

}
?>