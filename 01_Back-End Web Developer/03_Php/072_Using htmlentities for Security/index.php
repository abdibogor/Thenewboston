<?php	
	if (isset($_GET['day'])&&isset($_GET['date'])&&isset($_GET['year'])) {
		  //echo 'Ok.';
		$day = htmlentities($_GET['day']);
		$date = htmlentities($_GET['date']);
		$year = htmlentities($_GET['year']);
		if(!empty($day)&&!empty($date)&&!empty($year)) {
			echo 'It is '.$day.' '.$date.' '.$year;
		} else {
			echo 'Fill in all fields.';
		}
	}
	 
?>

   <form action="index.php" method="Get">
		 Day:<br><input type="text" name="username"><br>
		 Date:<br><input type="text" name="username"><br>
		 Year:<br><input type="text" name="username">
		 <br><br>
		 <input type="submit" value="Submit">
	</form> 