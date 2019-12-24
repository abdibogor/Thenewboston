<?php
	$video = simplexml_load_file('http://gdata.youtube.com/feeds/api/videos/JpM2AAF8v8');
	
	echo '<strong>Title</strong>:<br>'.$video->title.'<br>';
	echo '<strong>Description:</strong><br>'.$video->content;
	?>