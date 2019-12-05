 $('.menu_top').click(function() {
	 var href = $(this).attr('href');
	 /*second example
		alert('href');
		*/
		$(' #content_area').load(href);
		
	 /* first example
	 alert('Cliked');
	 */
	 
	 return false;
 });