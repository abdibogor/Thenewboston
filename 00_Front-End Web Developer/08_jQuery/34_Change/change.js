$('#list').change(function() {
	    /*
		alert('Changed');
		*/
		var list_value = $('#list').val();
		$('#list_feedback').html('You have selected: ' +list_value);
});
