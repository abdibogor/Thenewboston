$(document).ready(function(){
    var user_name = prompt('Enter your user name');
   $.post("php/users.php",{user_name: user_name, action: 'joined'});

    setInterval(function(){
      $.post("php/users.php",{action: 'left'}, function(data){
           $('#users_onlne').html(data);
      });
    }, 500);

  $(window).unload(function(){
   $.post("php/users.php",{user_name: user_name, action: 'left'}) 
	});    
});