<?php
database : phpacademy
---------------------
table: users
-------------------
id      username  password     firstname       surname       website
1		alex 	   pass123		Alex			Garrett       phpacademy.org
2		billy      pass456		Billy            Garrett	 
	 
	table: uploads
	--------------
id			user_id 			location
1			1					logo.png						
2			1					php.jpg
3			2					art.jpg						
	
select location from 'uploads' where user_id is 1	

php.jpg
art.jpg	

	
/*select the username form 'users' where the id is equal to 2*/



	
?>