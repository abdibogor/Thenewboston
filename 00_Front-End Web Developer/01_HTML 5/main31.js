function doFirst(){
		barSize=600;
		myMovie=document.getElementById('myMovie');
		playButton=document.getElementById('PlayButton');
		bar=document.getElementById('defaultBar');
		ProgressBar=document.getElementById('ProgressBar');
		
		playButton.addEventListener('click',playOrPause, false);
		bar.addEventListener('click',clickedBar, false);
}