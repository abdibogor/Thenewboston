$(document).ready(function() {
	  	$('input[type="password"]').after('<input type="checkbox" class="sp_checkbox" /> Show password');
		$('.sp_checkbox').change(function() {
			var prev = $(this).prev();
			
			var value = prev.val();
			var type = prev.attr('type');
			
			var name =  prev.attr('name');
			var id =    prev.attr('id');
			var class = prev.attr('class');
			
			/*
			if (type == 'password') {
				var new type = 'text';
			} else if (type == 'text') {
				var new_type = 'password';
			} 
			*/
			
			var new_type = (type == 'password') ? 'text' : 'password';
			
			prev.remove();
			$(this).before('<input type="' + new_type + '" value="' + value + '"  name="' + name + '" id="' + id + '" class="' + class + '" />');
			});
		});