<!DOCTYPE html>
<html dir="ltr" lang="en">
<head>
<title>Abdibogoreh</title>

<script type="text/javascript">
	
	function findmatch() {
		if (window.XMLHttpRequest) {
			xmlhttp = new XMLHttRequest();
		} else {
	  xmlhttp = new ActiveXObject('Microsoft.XMLHTTP');
		}

		xmlhttp.onreadystatechange = function() {
			if (xmlhttp.readystate == 4 && xmlhttp.status == 200) {
				document.getElementById('results').innerHTML = xmlhttp.responseText;
			}
		}

		xmlhttp.open('Get', 'search.inc.php', true);
		xmlhttp.send();

	}

</script>

</head>
<body>

	<form id="search" name="search">
		Type a name:<br>
		<input type="text" name="keyword" onkeydown="findmatch();">
	</form>

	<div id="results">
		
	</div>

</body>
</html> 