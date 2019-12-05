$('#names, #places').sortable({ containment: 'document', tolerance: 'pointer', 
		cursor: 'pointer', revert: true, opacity: 0.60, connectWith: '#names, #places',
				update: function() {
					content = $(this).text();
					$('#sort_status').text(content);
					/* first example
					alert('Sorted');
					*/
			}
		});
		
