$(document).ready(function() {
	$('.menu').find('li').first().addClass('bold').click(function() {
			$(this).nextAll().toggle(); /* before show an after toggle */
			/*
			alert('You clicked me');
			*/
	}).nextAll().hide();

	
	
	});
