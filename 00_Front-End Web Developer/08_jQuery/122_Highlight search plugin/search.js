$(document).ready(function() {
		$('#search_button').click(function() {
			var search_term = $('#search_term').val();
			$('*').removeHighlight().highlight(search_term);
		});
});