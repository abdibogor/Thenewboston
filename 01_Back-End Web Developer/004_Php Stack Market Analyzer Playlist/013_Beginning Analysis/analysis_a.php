<?php 
   include ('connect.php'); //my connect is on the same work-folder
   
   function masterLoop(){
	$mainTickerFile = fopen("tickerMaster.txt","r");
	while(! feof($mainTickerFile)){
		$companyTicker = fgets($mainTickerFile);
		$companyTicker = trim($companyTicker){
			 
		}		
	}	
?> 
