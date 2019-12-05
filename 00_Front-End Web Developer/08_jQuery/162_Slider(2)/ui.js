var min_value = 0;
var max_value = 100;

$("#slider").slider({ 

min: min_value,
max: max_value,
orientation: 'vertical',


	slide: function(event, ui) {
		$('#slider_value').html(ui.value);
		
		/*
		$('#slider_value').html('&pound;' + ui.values[0] + ' to &pound;' + ui.values[1]);
		*/
		}, 
			stop: function(event, ui) {
				alert(ui.value);
			}
});