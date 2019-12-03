(function($) {
	$.fn.hoverText = function() {
		$(this).after('<div id="hoverText"></div>');
			
			$(this).focusIn(function() {
				
				var title = $(this).attr('title');
				$(this).attr('title', '');	
				
			}).mousemove(function(e) {
				var title = $(this).attr('title');
				
				var top = e.clientY + 10;
				var left = e.clientX + 10;
				
				$('#hoverText').css('top', top).css('left', left).text(title).show();  
				 
			}).mouseout(function() {
				$(this).attr('title', title);
				$('# hoverText').hide();
			});
			
	}
})(jQuery);