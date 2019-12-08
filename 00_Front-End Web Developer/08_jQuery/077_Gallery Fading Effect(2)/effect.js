$(document).ready(function() {
	$('.fadeto').css('opacity', '0.4');
	$('.fadeto').mouseover(function() {
		$(this).fadeTo(500, 1);
		$('.fadeto').not(this).fadeTo(500, 0.4);
	});
});
