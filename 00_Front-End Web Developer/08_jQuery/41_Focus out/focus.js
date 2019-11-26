$('#name').focusin(function(){
	 $('#name_span').html('Enter your full name');
});

$('#name').focusout(function(){
	 $('#name_span').html('');
});

$('#age').focusin(function(){
	 $('#age_span').html('Enter your current age');
});

$('#age').focusout(function(){
	 $('#age_span').html('');
});