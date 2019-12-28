<?php

  $handle = fopen('names.txt', 'w');
  
  fwrite($handle, 'bogoreh'."\n");
  fwrite($handle, 'Alex');
  
  fclose($handle);
  
  echo 'Written.';
?>