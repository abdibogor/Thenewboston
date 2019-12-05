$(document).ready(function(){
    var user_name = prompt('Enter your user name');
	// send user_name to users.php, action: joined

	setInterval(function(){
		// get list of users, action: list
		}, 500);
		
		$(window).unload(function(){
			// remove user_name, action: left
			});	
	});