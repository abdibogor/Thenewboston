$(document).ready(function() {
	/* first example
	var timestamp = jQuery.now();
	*/
	setInterval(function() { 
		var timestamp = jQuery.now();
	$('#time').text(timestamp);
	}, 1);
});