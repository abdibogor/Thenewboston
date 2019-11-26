$(document).ready(function(){
	$('.duplicate').click(function() {
		alert('You have cliked.');
		$(this).after('<input class="duplicate" type="button" value="click" />');
	});
});