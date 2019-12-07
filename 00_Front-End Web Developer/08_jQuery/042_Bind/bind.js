$('a').bind('mouseenter mouseleave', function() {
	$(this).toggleClass('bold');
});


/* Second example
$('a').bind('mouseenter mouseleave', function() {
	$(this).addClass('bold');
}).bind('mouseleave', function(){
	$(this).removeClass('bold');
});

*/

/* first example
$('a').mouseenter(function() {
	$(this).addClass('bold');
	/*
		alert('Enter');
		*/
		/*
}).mouseleave(function() {
		 $(this).removeClass('bold');
});
*/