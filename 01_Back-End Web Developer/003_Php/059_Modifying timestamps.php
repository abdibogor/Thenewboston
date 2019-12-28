<?php

$time = time();
$time_now = date('d M Y @ H:i:s', $time);
$time_modified = date('d M Y @ H:i:s', $time-(7*2*30*30));

echo 'The time now is '.$time_now.'<br>The time modified is '.$time_modified;

echo $actual_time;
?> 