<?php
   /*
  preg_match();
 */
 $string = 'This is a string.';
 
 if (preg_match('/ /', $string)) {
	 echo 'Match found.';
 }   else {
	 echo 'No match found.';
 }
?>