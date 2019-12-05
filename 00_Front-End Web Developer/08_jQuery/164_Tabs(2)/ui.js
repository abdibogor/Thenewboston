$('#tabs').tabs({ 
    ajaxOptions: { 
		error: function(xhr, index, status, anchor) 
		{ 
			$(anchor.hash).text('Could not load page') 
		}
		}, /* event: 'mouseover' */ collapsible: true }).sortable({ axis: 'x' });