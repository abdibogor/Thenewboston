 $("#save").click(function() {
	 $("#dialog").attr('title', 'Saved').text('Settings were saved').dialog({ buttons: { 'ok': function() {
		$(this).dialog('close');
		/* first example
		alert('Hello');
		*/
	 } }, closeOnEscape: true, draggable: false, resizable: false, modal: true, 
	 });			
 });