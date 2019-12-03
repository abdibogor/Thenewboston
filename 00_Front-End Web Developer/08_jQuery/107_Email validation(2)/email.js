$('#email').focusin(function() {
	 if($('#email').val() === '') {
		$('#email_feedback').text('Go on, enter a valid email address...');
	}else {
		
	}
		}).blur(function() {
	    $('#email_feedback').text('');
});
