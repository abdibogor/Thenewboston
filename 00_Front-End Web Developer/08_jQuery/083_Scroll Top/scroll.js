 $(document).ready(function(){
		$('#textarea').scroll(function(){
			 var scroll_top = $(window).scrollTop();
			 $('#feedback').text('Currently at position: ' + scroll_top);
	 });
 });