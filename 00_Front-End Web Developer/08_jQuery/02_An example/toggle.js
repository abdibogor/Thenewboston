 $('#toggle_message').click(function() {
	 var value= $('#toggle_messag').attr('value');
	 $('#message').toggle('fast');
	 
	 if (value == 'Hide'){
		$('toggle_message').attr('value', show');
		} else if (value == 'show') {
			$ ('#toggle_message').attr('value', 'Hide');
   }
      });