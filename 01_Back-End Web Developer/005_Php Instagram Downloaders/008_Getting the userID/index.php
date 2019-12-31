<?php

set_time_limit(0); 							
ini_set('default_socket_timeout', 300);		
session_start();

/******Instagram API Keys*******/

define('clientID', 'fd56a9ca4b334360b5a91e9af9715c38');
define('clientSecret', 'a759d78e8ba540f99df66f5999d71592');
define('redirectURI', 'http://gregjw.com/instagramdl/index.php');
define('imageDirectory','archive/');

//Connect with Instagram     /*7.Creating an easier Connect Function */
function connectToInstagram($url){
	$ch = curl_init();						
	
	curl_setopt_array($ch, array(			
		CURLOPT_URL => $url,				
		CURLOPT_RETURNTRANSFER => true,		
		CURLOPT_SSL_VERIFYPEER => false,	
		CURLOPT_SSL_VERIFYHOST => 2			
	));
	
	$result = curl_exec($ch);				
	curl_close($ch);						
	return $result;							
}

//Instagram UserID
function getUserID($userName){
	$url = 'https://api.instagram.com/v1/users/search?q='. $userName .'&client_id='. clientID;
	$instagramInfo = connectToInstagram($url);
	$results = json_decode($instagramInfo, true); 	
	return $results['data'][0]['id'];
}



if($_GET['code']){
	$code = $_GET['code'];
	$url = "https://api.instagram.com/oauth/access_token";
	$access_token_settings = array(
			'client_id'                =>     clientID,
			'client_secret'            =>     clientSecret,
			'grant_type'               =>     'authorization_code',
			'redirect_uri'             =>     redirectURI,
			'code'                     =>     $code
	);
    $curl = curl_init($url);    									
	curl_setopt($curl,CURLOPT_POST,true);   						
	curl_setopt($curl,CURLOPT_POSTFIELDS,$access_token_settings);   
	curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1);   				
	curl_setopt($curl, CURLOPT_SSL_VERIFYPEER, false);
     	
	$result = curl_exec($curl);   									
	curl_close($curl);

    $results = json_decode($result,true);
	$userName = $results['user']['username']; 
	
	
	}else{ ?>

	
<!DOCTYPE html>
<html dir="ltr" lang="en">
<head>
<title>Abdibogoreh</title>
</head>
<body>

		<a href="https://api.instagram.com/oauth/authorize/?client_id=<?php echo clientID; ?>&redirect_uri=<?php echo redirectURI; ?>&response_type=code">Log in to Instagram</a>

		
		
</body>
</html> 