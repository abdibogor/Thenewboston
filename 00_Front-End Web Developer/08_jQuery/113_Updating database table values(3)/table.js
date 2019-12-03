$('#save_button').click(function() {
	// grab values
		var name = $('#name').val();
		
		// show loading text	
		$('#save_status').text('Loading...');
		
		// perform http request
		$.post('settings.php', { name: name }, function(data) {
			$('#save_status').text(data);
		});				
});