function doFirst(){
    barSize=600;
    myVideo=document.getElementById('myVideo');
    playButton=document.getElementById('playButton');
    defaultBar=document.getElementById('defaultBar');
    progressBar=document.getElementById('progressBar'); 

    playButton.addEventListener('click', playOrPause, false);
    defaultBar.addEventListener('click', clickedBar, false);
}

function playOrPause(){
    if(!myVideo.paused && !myVideo.ended){
        myVideo.pause();
        playButton.innerHTML='Play';
        window.clearInterval(updateBar);
    } else{
        myVideo.play();
        playButton.innerHTML='Pause';
        updateBar=setInterval(update, 500);
    }
}

function update(){
    if(!myVideo.ended){
        var size=parseInt(myVideo.currentTime*barSize/myVideo.duration);
        progressBar.style.width=size+'px';
    } else{
        progressBar.style.width='0px';
        playButton.innerHTML='Play';
        window.clearInterval(updateBar);
    }
}

function clickedBar(e){
    if(!myVideo.paused && !myVideo.ended){
        var mouseX=e.pageX-bar.offsetLeft;
        var newtime=mouseX*myVideo.duration/barSize;
        myVideo.currentTime=newtime;
        progressBar.style.width=mouseX+'px';
    }
}

window.addEventListener('load', doFirst, false);