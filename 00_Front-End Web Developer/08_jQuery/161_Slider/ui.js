var min_value = 1;
var max_value = 400;

$("#slider").slider({ 

min: min_value,
max: max_value,
step: 5,

	slide: function(event, ui) {
		$('#slider_value').html('&pound;' + ui.value);
} 
});