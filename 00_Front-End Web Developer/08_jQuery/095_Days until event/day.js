 $(document).ready(function(){
    eventTime =  Date.parse('10 September 2013) /1000; //seconds
    currentTime = Math.floor(jQuery.now()/1000);
    seconds = eventTime - currentTime;
    days = Math.floor(seconds/(60*60*24));
   $('#days').text('Only ' = days + ' days until the events');
		
		/* fourth example
		alert(days);
		*/
		
		/* Third example
		alert(seconds);
		*/
		
		/* Second example
		alert(currentTime);
		*/
		
		/* first example
		alert(eventTime);
		*/
 });