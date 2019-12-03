$(document).ready(function(){
	$('#agree').attr('disabled', 'disabled');
	$('#terms').scroll(function() {
		  var textarea_height = $(this) [0].scrollHeight;
		  var scroll_height = textarea_height - $(this).innerHeight(); 
		  var scroll_top = $(this).scrollTop();
		 
		 /* first example
		 $('#feedback').text(scroll_top);
		 */
		 
		 if (scroll_top == scroll_height) {
			 $('#agree').removeAttr('disabled');	 
		 }
	});
});