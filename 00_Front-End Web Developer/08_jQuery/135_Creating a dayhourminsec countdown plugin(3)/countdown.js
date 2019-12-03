(function($) {
	$.fn.countdown = function(options) {
		
		var settings = { 'date': null };
		if (options) {
			$.extend(settings, options);
		}
		
		 this_sel = $(this);
		
		function count_exec() {
			eventDate = 		Date.parse(settings['date']) / 1000;
			currentDate = 		Math.floor($.now() / 1000);
			
			/*
			alert(eventDate + ' ' + currentDate);
			*/
			
			seconds =			 eventDate - currentDate;
			
			days = 				Math.floor(seconds / (60 * 60 * 24));
			alert(days);
		}
	
		count_exec();	
	}
})(jQuery);