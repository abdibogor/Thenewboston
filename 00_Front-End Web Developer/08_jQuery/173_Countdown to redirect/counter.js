function counter(time, url) {
	 var interval = setInterval(function() {
		 $('#counter').append('a');
	}, 1000);
}

$(document).ready(function() {
    counter(10, "http://www.google.dj");
});