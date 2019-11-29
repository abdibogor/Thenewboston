$(document).ready(function() {
	$('.fadeto').css('opacity', '0.4');
	$('.fadeto').mouseover(function() {
		$(this).fadeTo(100, 1, function() {
			
			/*
	$('.fadeto').click(function(){
		$(this).fadeTo('normal', 0.4, function(){
			*/
			/*
				alert('Animation complete');
				*/
		});
	});
});
