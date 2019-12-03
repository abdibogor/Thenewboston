(function($) {
	$.fn.hoverText = function() {
		$(this).after('<div id="hoverText"></div>');
		
		var title = $(this).attr('title');
		if (title != undefined || title != '') {
			
			$(this).mousemove(function(e) {
				var top = e.clientY + 10;
				var left = e.clientX + 10;
				
				$('#hoverText').css('top', val).css('left', left).text().show();
			}).mouseout(function() {
				$('# hoverText').hide();
			});
			
		}
	}
})(jQuery);