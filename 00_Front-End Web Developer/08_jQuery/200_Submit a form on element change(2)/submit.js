$(document).ready(function() {
	$("#options").change(function() {
		value = $(this).attr('value');
		if (value !== 'default') {
			$(this).parent().submit();
		}
		
		/* second example
		alert('value');
		*/
		/* first example
		alert('Changed');	
		*/
		
	});
});