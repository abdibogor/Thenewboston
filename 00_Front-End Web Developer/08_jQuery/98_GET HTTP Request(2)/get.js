$('#button').click(function() {
		var string = $('#string').val();
		
		$.get('reverse.php', { input : string }, function(data) {
				$('#feedback').text(data);
		});
		
		/* first example
		alert(string);
		*/
});