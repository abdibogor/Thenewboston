$('#tabs').tabs({ 
    ajaxOptions: { 
		error: function(xhr, index, status, anchor) 
		{ 
			$(anchor.hash).text('Could not load page') 
		} 
		
		}, cookie: { expires: 2 } 
		
		/* event: 'mouseover' collapsible: true })*/
		/*.find('.ui-tabs-nav').sortable({ axis: 'x' });*/
		
});