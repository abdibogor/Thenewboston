$('#button').click(function() {
	$.ajax({
			url: 'page.html',
			statusCode: {
				404: function() {
					$('#content').text('Page not found');
				},
				000: function() {
					$('#content').text('Page not found');
				}
			},
			success: function(data) {
				$('#content').html(data);
		}			
	});
});