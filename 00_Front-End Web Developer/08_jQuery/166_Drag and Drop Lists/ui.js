$(document).ready(function() {
	$('li').draggable({ containment: 'document', revert: true });
  
	$('# list').droppable({ drop: function() {
		alert('Dropped');
	} });
});
    