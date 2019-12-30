<?php
   include("includes/connect.php");
   
 function createUrl($ticker){
	   $currentMonth = date("n");
	$currentMonth -= 1;
	$currentDay = date("j");
	$currentYear = date("Y");
	// echo "http://real-chart.finance.yahoo.com/table.csv?s=$ticker&d=$currentMonth&e=$currentDay&f=$currentYear&g=d&a=7&b=19&c=2014&ignore=.csv";
	// was done for testing reasons
	return "http://real-chart.finance.yahoo.com/table.csv?s=$ticker&d=$currentMonth&e=$currentDay&f=$currentYear&g=d&a=3&b=15&c=2016&ignore=.csv"; //I did it for 2 weeks
}
   
   
   
?>