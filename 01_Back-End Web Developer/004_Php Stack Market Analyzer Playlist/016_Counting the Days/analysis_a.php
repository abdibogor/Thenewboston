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
				
				// 16. Counting the Days
				if($numOfRows==1){
					 $row2 = mysql_fetch_row($result2);
					 $tom_date = $row2[0];
					   $tom_percent_change = $row2[1];
					   
			   if($tom_percent_change > 0)  {
						   $nextDayIncrease++;
						   $sumofIncreases += $tom_percent_change;
						   $total++;
			    }else if($tom_percent_change < 0){
					 $nextDayDecrease++;
					 $sumOfDecreases += $tom_percent_change;
					 $total++;
				} else {
						$nextDayNoChange++;
						$total++;
				}
			 }
		   }	
	     }
       }	
	}	
?> 
