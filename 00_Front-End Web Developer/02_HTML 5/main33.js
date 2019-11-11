function doFirst(){
		barSize=600;
		myMovie=document.getElementById('myMovie');
		playButton=document.getElementById('PlayButton');
		bar=document.getElementById('defaultBar');
		ProgressBar=document.getElementById('ProgressBar');
		
		playButton.addEventListener('click',playOrPause, false);
		bar.addEventListener('click',clickedBar, false);
}
function PlayorPause(){
	   if(!myMovie.paused && !myMovie.ended){
		   myMovie.pause();
		   playButton.innerHTML='Play';
		   window.clearinterval(updateBar);
	   }else{
		   myMovie.play();
		   playButton.innerHTML='Pause';
		   updateBar=setInterval(update, 500);   
	   }
	 }
	 
function update(){
	if(!myMovie.ended){
		var size=parseInt(myMovie.currentTime*barSize/myMovie.duration);
		progressBar.style.width=size+'px';
	}else{
		progressBar.style.width='0px';
		playButton.innerHTML='Play';
		
	}
}