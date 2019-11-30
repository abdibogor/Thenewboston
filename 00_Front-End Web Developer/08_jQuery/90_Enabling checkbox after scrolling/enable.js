$(document).ready(function(){
	$('#agree').attr('disabled', 'disabled');
	
	$('#terms').scroll(function() {
		  var textarea_height = $(this) [0].scrollHeight;
		  
		  $('#feedback').text(textarea_height);
	});
});