<?PHP

function getUserIP()
{
    // Get real visitor IP behind CloudFlare network
    if (isset($_SERVER["HTTP_CF_CONNECTING_IP"])) {
              $_SERVER['REMOTE_ADDR'] = $_SERVER["HTTP_CF_CONNECTING_IP"];
              $_SERVER['HTTP_CLIENT_IP'] = $_SERVER["HTTP_CF_CONNECTING_IP"];
    }
    $client  = @$_SERVER['HTTP_CLIENT_IP'];
    $forward = @$_SERVER['HTTP_X_FORWARDED_FOR'];
    $remote  = $_SERVER['REMOTE_ADDR'];

    if(filter_var($client, FILTER_VALIDATE_IP))
    {
        $ip = $client;
    }
    elseif(filter_var($forward, FILTER_VALIDATE_IP))
    {
        $ip = $forward;
    }
    else
    {
        $ip = $remote;
    }

    return $ip;
}


$user_ip = getUserIP();

echo $user_ip; // Output IP address [Ex: 177.87.193.134]


/*
    false code

		$http_client_ip = $_SERVER['HTTP_CLIENT_IP'];
	  $http_x_forwarded_for = $_SERVER['HTTP_X_FORWARDED_FOR'];
	  $remote_addr = $_SERVER['REMOTE_ADDR'];
	  
	  if (!empty($http_client_ip)) {
		  $ip_address = $http_client_ip;
	  } else if (!empty($http_x_forwarded_for)) {
		  $ip_address = $http_x_forwarded_for;
	  } else {
		   $ip_address = $remote_addr;
	  }
	  
	  echo $ip_address;
	

*/

?>