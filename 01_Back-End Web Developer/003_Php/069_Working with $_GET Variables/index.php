<?php
     /*
1. Does it exist? or "Has it been submitted?"
2. Is it empty? or "Does Value == NULL"
3. Display back to user 
	 */
	 
	/* if (isset($_GET['day'])) */
	
	if (isset($_GET['day'])&&isset($_GET['date'])&&isset($_GET['year'])) {
		  //echo 'Ok.';
		$day = $_GET['day'];
		$date = $_GET['date'];
		$year = $_GET['year'];
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