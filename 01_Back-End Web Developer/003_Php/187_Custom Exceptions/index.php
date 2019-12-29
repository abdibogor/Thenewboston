<?php

	$mysql_host = 'localhost';
	$mysql_user = 'root';
	$mysql_pass = '';
	$mysql_db = 'a_database';

	class ServerException extends Exception {}
	class DatabaseException extends Exception {}

try {

if (!@mysql_connect($mysql_host, $mysql_user, $mysql_pass)) {
	   throw new ServerException('Could not connect to server.');
} else if (!@mysql_select_db($mysql_db)) {
   throw new DatabaseException ('Could not select to database.');
} else if {
	echo 'Connected.';
}

}  catch (ServerException $ex){
   echo 'Error: '.$ex->getMessage();
} catch (DatabaseException $ex) {
	  echo 'Error : '.$ex->getMessage();
}



?>