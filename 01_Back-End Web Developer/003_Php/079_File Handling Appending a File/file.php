<?php
/*
$handle = fopen('names.txt', 'a');
fwrite($handle, "\n".'Steven'."\n");
//fwrite($handle, 'Billy');
fclose($handle);
//echo 'Written.';
*/

if (isset($_POST['name'])) {
	$name = $_POST['name'];
	if (!empty($name)) {
		
		//echo 'ok';
		
		$handle = fopen('names.txt', 'a');
		fwrite($handle, $name."\n");
		fclose($handle);
		
	} else {
		echo 'please type a name.';
	}
}

?>


<form action="file.php" method="POST">
	Name:<br>
	<input type="text" name="name"><br><br>
	<input type="submit" name="Submit">
</form>