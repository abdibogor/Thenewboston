 $(document).ready(function() {
		$("#drag").draggable({ containment: 'document', revert: true });
		
		$("#drop").droppable({ hoverClass: 'border', tolerance: 'touch', accept: '' });
		});
		
/*

tolerance: intersect;
tolerance: touch;
tolerance: pointer;

*/