$(document).ready(function() {
	  	$('input[type="password"]').after('<input type="checkbox" class="sp_checkbox" /> Show password');
		$('.sp_checkbox').change(function() {
			var prev = $(this).prev();
			/* first example
			alert('Changed');
			*/
		});
		});