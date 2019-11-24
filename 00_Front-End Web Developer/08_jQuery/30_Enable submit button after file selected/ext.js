$(document).ready(function() {
	$('input[type="file"]').change(function() {
		alert('Changed');
		$(this).next().removeAttr('disabled');
	}).next().attr('disabled', 'disabled');
		
	});
	
	
	
	/*
	
	$('#file').change(function() {
		$('#submit').removeAttr('disabled');
  });
  
  */