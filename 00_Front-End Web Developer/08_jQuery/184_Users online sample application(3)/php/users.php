<?php
require 'db.php';

function user_joined($user_name){  
	$user_name = mysql_real_escape_string(htmlentities($user_name));
    mysql_query(" INSERT into `users` VALUES ('$username') ");
}

function user_left($user_name){
}

function user_list($user_name){
	
}

if(isset($_POST['user_name'], $_POST['action'])){
    $user_name = $_POST['user_name'];
    $action =    $_POST['action'];

		if($action = 'joined') {
        user_joined($user_name);
	}
}

?>