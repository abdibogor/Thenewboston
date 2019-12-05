$(document).ready(function(){
    var user_name = prompt('Enter your user name');
	// send user_name to users.php, action: joined
    $.post("php/users.php",{user_name: user_name, action: 'joined'});

	setInterval(function(){
		$.post("php/users.php",{action: 'left'}, function(data){
           $('#users_onlne').html(data);});
		}, 500);
		
		$(window).unload(function(){
			// remove user_name, action: left
			});	
	});