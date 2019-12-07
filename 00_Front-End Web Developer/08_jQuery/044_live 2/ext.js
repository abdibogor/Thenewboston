$(document).ready(function() {
	$(".file").bind({
		change: function() {
			$(this).after('<input class="file" type="file" />');
		}
	});
	
	/*
	$('.duplicate').bind({
	   click: function() {
		   alert('You have cliked!');
	   }
	});
	
	*/
});