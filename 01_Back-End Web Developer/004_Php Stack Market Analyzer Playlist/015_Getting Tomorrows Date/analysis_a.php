<?php 
   include ('connect.php'); //my connect is on the same work-folder
   
   function masterLoop(){
	$mainTickerFile = fopen("tickerMaster.txt","r");
	while(! feof($mainTickerFile)){
		$companyTicker = fgets($mainTickerFile);
		$companyTicker = trim($companyTicker){
		
			// 14 Starting to Crunch The numbers

			$nextDayInc = 0;
		    $nextDayDec = 0;
		    $nextDayNoC = 0;
		     $total = 0;	
			 
			 $sumOfInc = 0;
		     $sumOfDec = 0;
			 
			 $sqlSel = "SELECT Date, percentage_change FROM $companyTicker WHERE percentage_change < '0' ORDER BY Date ASC"; //
		     $resultSel = mysql_query($sqlSel);
			
			// 15. Getting Tomorrows Date
			 if($resultSel){
			       while($row = mysql_fetch_array($resultSel)){
				$date1 = $row['Date'];
				$percent_change = $row['percentage_change'];
				
				$sql2 = "SELECT Date, percentage_change FROM $companyTicker WHERE Date > '$date1' ORDER BY Date ASC LIMIT 1";
				$resultSel2 = mysql_query($sql2);
				$numOfRows = mysql_num_rows($resultSel2);
		}		
	}	
?> 
