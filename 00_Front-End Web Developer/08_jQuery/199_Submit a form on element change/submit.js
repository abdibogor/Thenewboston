$(document).ready(function() {
	$('input[type="file"]').change(function() {
		$(this).parent().submit();
		/* first example
		alert('Changed');
		*/
	});
});