$(document).ready(function() {
	  $('#countdown').countdown( { from: 10 }, function() {
		  window.location = 'http://www.google.com';
		  
		  /*
		  alert('Done!');
		  */
		  
	  });
});