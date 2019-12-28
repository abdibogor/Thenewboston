<?php
$xml = simplexml_load_file('example.xml');

/*
echo $xml=>producer[1]->name.' is '.$xml=>producer[1]->age;
*/

	foreach ($xml->producer as $producer) {
	//echo $producer->name.'<br>';
	echo $producer->name.' ('.$producer->age.')<br>';
	//echo $producer->show->showname.'<br>';
	foreach ($producer->show as $show) {
		echo $show->showname.' on '.$show->showdate.'<br>';
	}
}

?>