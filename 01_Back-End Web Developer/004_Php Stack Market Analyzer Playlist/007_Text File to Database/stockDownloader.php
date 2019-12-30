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
   
 //this function gets the content of the url provided and saves the content as a string, without a header, on an output filepath provided.
 // 6. Downloading and Saving Data
function getCSVfile($url , $outputFile){
	$content = file_get_contents($url);
	$content = str_replace("Date,Open,High,Low,Close,Volume,Adj Close","",$content);
	$content = trim($content);
	//echo $content;  - was done for testing reasons
	file_put_contents($outputFile, $content);
}
  
//this function takes the data from the csv file and saves it into sql
         //7. Text File to Database
 function fileToDatabase($txtFile, $tableName){
	$file = fopen($txtFile, "r");
	  while(!feof($file)){
		$line = fgets($file);
		$pieces = explode(",", $line);

  
?>