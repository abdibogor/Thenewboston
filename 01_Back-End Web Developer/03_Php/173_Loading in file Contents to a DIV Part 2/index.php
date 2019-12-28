<!DOCTYPE html>
<html dir="ltr" lang="en">
<head>
<title>Abdibogoreh</title>
<script type="text/javascript">
	function load() {
		if (window.XMLHttpRequest) {
		  xmlhttp = new XMLHttpRequest();
		} else {
		  xmlhttp = new ActivexObject('Microsoft.XMLHTTP');
		}

		xmlhttp.onreadystatechange = function() {
			if (xmlhttp.readystate == 4 && xmlhttp.status == 200) {
				document.getElementById('adiv').innerHTML = xmlhttp.responseText;
			}
		}

		xmlhttp.open('GET', 'include.inc.php', true);
		xmlhttp.send();
}

</script>
</head>
<body>

<input type="submit" onclick="load();">

<div id="adiv">
 
</div>
</body>
</html> 
