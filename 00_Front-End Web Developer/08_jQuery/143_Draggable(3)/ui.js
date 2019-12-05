$( function() {
    $( "#drag" ).draggable({ cursor: 'pointer', opacity: 0.60, revert: true, 
	start: function() {
			$('#event').text('Dragging started');
		}, 
		drag: function()  {
			$('#event').text('Dragging');
		}, 
		stop: function() {
			$('#event').text('Dragging Stopped');
		} } );
	});
  
  /*
		containement: 'document'
		containement: 'window'
		containement: 'parent'
		containement: [0, 0, 200, 200]
		cursor: 'crosshair' 
		cursor: 'pointer' 
		revertDuration: 5000
  */