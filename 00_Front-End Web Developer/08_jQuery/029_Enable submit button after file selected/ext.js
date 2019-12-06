$(document).ready(function() {
		$('#file').change(function() {
			value = $(this).attr('value');
			alert(value);
			/*
			alert('Something has changed');
			*/
		});
});