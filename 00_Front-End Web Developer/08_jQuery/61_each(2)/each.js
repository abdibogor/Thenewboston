$(document).ready(function(){
	$('#combine').click(function(){
		
		var failed = false;
		/*
		var combined_text = '';
		*/
		
		$('input[type="text"]').each(function(){
			if ($(this).val() == '') {
				failed = true;
			}
			/* third example
			combined_text += $(this).val() + ' '; 
			*/
			});
			
			if(failed == true) {
				alert('Fill out all fields');
			}else if (failed == false) {
				alert('Thanks for filling out all fields.');
			}
			
				/* second example
			$('#combined').text(combined_text);
			*/
			
			/* first example
			alert(combined_text);
		
		*/
		
	});
});