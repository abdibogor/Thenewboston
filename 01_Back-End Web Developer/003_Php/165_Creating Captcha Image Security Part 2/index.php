<?php
session_start();
$_SESSION['secure'] = rand(100,999);
?>

<img src="generate.php" />