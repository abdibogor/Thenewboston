$('#button').click(function() {
	var name = $('#name').val();
	
		$.ajax({
			url: 'page.php',
			data: 'name='+name,
			success: function(data) {
				$('#content').html(data);
		}
		}).error(function() {
			alert('An error occured');
		}).success(function() {
			
		}).complete(function() {
			
		});
});