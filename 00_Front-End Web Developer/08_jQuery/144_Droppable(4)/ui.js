$(document).ready(function() {
		$("#drag").draggable({ containment: 'document', revert: true });
		
		$("#drop").droppable({ drop: function() {
			alert('Dropped');
		}} );
		
});
