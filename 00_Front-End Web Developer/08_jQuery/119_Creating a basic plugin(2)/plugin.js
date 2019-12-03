(function($) {
	$.fn.targetBlank = function() {
		var targetArray = ['_blank', '_self', '_parent', '_top'];
		var target = jQuery.trim($(this).attr('target'));
		
		if (target == undefined || target == '') {
				// apply target_blank
		}
		
		/* Second example
		alert(target);
		*/
		
		/* first example
		alert('Working');
		*/
		
	}
}) (jQuery);