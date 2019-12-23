<?php
	echo $name = $_FILES['file']['name'];
	$size = $_FILES['file']['size'];
	$type = $_FILES['file']['type'];
	
	$tmp_name = $_FILES['file']['tmp_name'];
?>

<form action="upload.php" method="POST" enctype="multipart/form-data">
		<input type="file" name="file"><br><br>
		<input type="submit" value="Submit">
</form>