function validate_email(email) {
	$.post('email.php', { email: email }, function(data) { 
	return data;
	/* $('#email_feedback').text(data); */
	});
}

$('#email').focusin(function() {
	 if($('#email').val() === '') {
		$('#email_feedback').text('Go on, enter a valid email address...');
	}else {
		  var result = validate_email($('#email').val());
	}
		}).blur(function() {
	    $('#email_feedback').text('');
}).keyup(function() {
			var result = validate_email($('#email').val());
});
