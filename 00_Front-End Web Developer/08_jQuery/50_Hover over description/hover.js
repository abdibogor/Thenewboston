$('.hover').mousemove(function(e) {
	var hovertext = $(this).attr('hovertext');
	$('#hoverdiv').css('top', e.clientY).css('left', e.clientX);
	
	/*
	alert(hovertext);
	*/	
});