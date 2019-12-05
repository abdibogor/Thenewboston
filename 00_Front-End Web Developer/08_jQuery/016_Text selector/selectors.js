/*
$(':text').focusin(function() {
	/* alert('Hello');  */
	/* $(this).css('background-color', 'yellow'); 
});
*/

/*
$(':text').blur(function() {
		$(this).css('background-color', 'red');	
	});
	*/
	
$(':text').focusin(function() {
	 $(this).css('background-color', 'yellow'); 
});	

$(':text').focuseout(function() {
		$(this).css('background-color', 'red');	
	});