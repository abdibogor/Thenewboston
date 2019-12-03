(function($) {
	$.fn.countdown = function(options, callback) {
		// array of custom settings
		
		//custom 'this' selector
		 this_sel = $(this);
		
		var settings = {
			'date': null
			'format': null
				};
				
				//append the settings array to options
		if (options) {
			$.extend(settings, options);
		}	
		
		//main countdown function
		function countdown_exec() {
			eventDate = 		Date.parse(settings['date']) / 1000;
			currentDate = 		Math.floor($.now() / 1000);
			
			if (eventDate <= currentDate) {
				callback.call(this);
				clearInterval(interval);
			}
			
			seconds =			 eventDate - currentDate;
			
			days = 				Math.floor(seconds / (60 * 60 * 24));
			seconds -= 		    days * 60 * 60 * 24; //update the seconds variable with no. of days removed
			
			hours =  			Math.floor(seconds / (60 * 60));
			seconds -= 		    hours * 60 * 60; //update the seconds variable with no. of hours removed
			
			minutes = 		Math.floor(seconds /60);
			seconds -= 		 minutes * 60; //update the seconds variable with no. of minutes removed
			
			days = (String(days).length !== 2) ?'0' + days : days;
			hours = (String(hours).length !== 2) ?'0' + hours : hours;
			minutes = (String(mins).length !== 2) ? '0' + minutes :minutes;
			seconds= (String(secs).length !== 2) ? '0' + seconds : seconds;
			
			if(!isNaN(eventDate)) {
			this_sel.find('.days').text(days);
			this_sel.find('.hour').text(hours);
			this_sel.find('.mins').text(minutes);
			this_sel.find('.secs').text(seconds);
			
		}
		  }
		  
			//run the function
		countdown_exec();
			//loop the function		
		interval = setInterval(count_exec, 1000);
	}
})(jQuery);