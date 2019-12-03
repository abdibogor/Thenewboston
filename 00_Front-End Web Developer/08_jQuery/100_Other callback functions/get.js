$('#button').click(function() {
	var name = $('#name').val();
		var string = $('#string').val();
		
		$.post('reverse.php', { string : string, name: name }, function(data) {
				$('#feedback').html(data);
		}).error(function() {
			$('#messages').text('An error occured ');
		}).complete(function() {
			$('#messages').text('Request complete ');
		}).success(function() {
			$('#messages').text('Request successful '); 
		});		
});