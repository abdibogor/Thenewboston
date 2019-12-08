$(document).ready(function(){
	var div_height = parseInt($('#div').css('height'));
	var div_width = parseInt($('#div').css('width'));
	$('#div').append('Width: ' + div_width + ' / Height: ' + div_height);
});