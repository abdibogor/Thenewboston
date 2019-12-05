$(document).ready(function() {
		$('#add_more').click(function() {
				var current_count = $('input[type="file"]').length;
				var next_count = current_count + 1;
	$('#file_upload').prepend('<p><input type="file" name="file' + next_count + '" /></p>');
				
				/* first example
				alert(current_count);
				*/
		});
});