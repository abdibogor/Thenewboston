<?php
header('Content-type: image/jpeg');

mysql_connect('localhost','root','');
mysql_select_db('bogoreh');

if (isset($_GET['id'])){ 
	  $id =   $_GET['id'];
	//$email = 'example@example.com';
  } else {
	$email = 'No email specified.';
}

$query = mysql_query("Select `email` FROM `users` WHERE `id`='".mysql_real_escaped_string($id)."'");
if (mysql_num_rows($query)>=1) {
$query_result = mysql_result($query, 0, 'email');
  } else {
	  $email = 'ID not found.';
  }
  
  } else {
	  $email = 'No ID specified.';
  }
  
$email_length = strlen($email);

$font_size = 4;

$image_height = ImageFontHeight($font_size);
$image_width = ImageFontWidth($font_size) *$email_length;

$image = imagecreate($image_width, $image_height);

imagecolorallocate($image, 255, 255, 255);
$font_color = imagecolorallocate($image, 0, 0, 0);

imagestring($image, $font_size, 0, 0, $email, $font_color);
imagejpeg($image);


?>

