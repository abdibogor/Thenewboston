 $(document).ready(function(){
		 var names = ['Alex', 'Bily', 'Dale'];
		 
		 /*
		 if (jQuery.inArray('Billy', names) != '-1') {
			 alert('Found');
		 }
		 */
		 
		  $('#check').click(function() {
			  var name= $('#name').val();
			  if (jQuery.inArray(name, names)  != '-1'){
				  alert(name + ' is in the array!');
			  }else {
				  alert(name + ' is Not in the array!');
				  }
			  /* second example
			  alert(name);
			  */
		  });
 });