$('#username').keyup(function() {
	var username = $(this).val();
	
	$('#username_status').text('Searching...');
	/* second example
	alert(username);
	*/
	/* first example
	alert('Key up');
	*/
});