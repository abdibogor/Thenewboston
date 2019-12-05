$(document).ready(function() {
	$('.emoticon').click(function() {
		var textarea_val = $('#comment').val();
		var emoticon_val =  $(this).attr('value');
		
		$('#comment').val(textarea_val + ' ' + emoticon_val + ' ');
	});
});