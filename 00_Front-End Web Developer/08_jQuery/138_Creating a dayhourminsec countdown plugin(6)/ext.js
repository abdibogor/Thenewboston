$(document).ready(function() {
	$('#countdown').countdown({ date: '15 June 2018 22:00:30'}, function() {
		$('#countdown').text('We\re live!');
		
		/*
		alert('Done'!);
		*/
		
	});
  });

