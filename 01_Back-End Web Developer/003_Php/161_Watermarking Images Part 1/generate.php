<?php
 header('Content-type: image/jpeg');
 
 if (isset($_GET['source'])) {
	 $source = $_GET['source'];
	
	$watermark = imagecreatefrompng('clavier.jpg');	
	
 }
 
?>