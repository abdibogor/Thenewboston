(function($) {
	$.fn.hoverText = function() {
		$(this).after('<div id="hoverText"></div>');
		
		var title = $(this).attr('title');
		if (title != undefined || title != '') {
			
			$(this).mousemove();
			
		}
	}
})(jQuery);