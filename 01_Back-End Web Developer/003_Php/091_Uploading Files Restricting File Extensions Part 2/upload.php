<?php
 echo $name = $_FILES['file']['name'].'<br>';
 echo $extension = strtolower(substr($name, strpos($name, '.') + 1));
 echo $type = $_FILES['file']['type'];

	$tmp_name = $_FILES['file']['tmp_name'];

	if (isset($name)) {
		if (!empty($name)) {
		
 if (($extension=='jpg'||$extension=='jpeg')&&$type=='image/jpeg')	
	 
			$location = 'uploads';
			
			if (move_uploaded_file($tmp_name, $location.$name)) {
			echo 'Uploaded!';
			} else {
				echo 'There was an error.';
			}
			
			} else {
				echo 'File must be jpg/jpeg';
			}
			
		} else {
			echo 'Please choose a file.';
		}

?>

<form action="upload.php" method="POST" enctype="multipart/form-data">
		<input type="file" name="file"><br><br>
		<input type="submit" value="Submit">
</form>