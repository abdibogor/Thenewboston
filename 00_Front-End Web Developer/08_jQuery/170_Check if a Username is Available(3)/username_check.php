<?php

require 'db.php';

if (isset($_POST['username'])) {
    $username = mysql_real_escape_string($_POST['username']);

    if (!empty($username)) {
        $username_query = mysql_query("SELECT COUNT user_id
                                       FROM users
                                       WHERE username = '$username'");
         echo $username_result = mysql_result($username_query, 0);
    }
}

?>