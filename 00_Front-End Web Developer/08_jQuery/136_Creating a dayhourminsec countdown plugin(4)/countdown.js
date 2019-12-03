(function($) {
	$.fn.countdown = function(options) {
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
			
			seconds =			 eventDate - currentDate;
			
			days = 				Math.floor(seconds / (60 * 60 * 24));
			seconds = 		    days * 60 * 60 * 24;
			
			hours =  			Math.floor(seconds / (60 * 60));
			seconds -= 		    hours * 60 * 60;
			
			minutes = 		Math.floor(seconds /60);
			seconds -= 		 minutes * 60;
			
			
			
			this_sel.find('.days').text(days);
			this_sel.find('.hour').text(hours);
			this_sel.find('.mins').text(minutes);
			this_sel.find('.secs').text(seconds);
			
		}
	
		countdown_exec();	
		interval = setInterval(count_exec, 1000);
	}
})(jQuery);