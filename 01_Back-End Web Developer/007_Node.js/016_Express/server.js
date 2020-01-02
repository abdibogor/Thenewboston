var connect = require('connect');
var http = require('http');

var app = connect();

/*
function doFirst(request, response, next){
	 console.log("Bacon");
	 next();
}

function doSecond(request, response, next){
	 console.log("Bacon");
}

app.use(doFirst);
app.use(doSecond);
*/

function profile(request, response){
	     console.log('Use requested pofile');
}

function forum(request, response){
	     console.log('Use requested forum');
}

app.use('/profile', profile);
app.use('/forum', forum);

http.createServer(app).listen(8888);
console.log("Server is running...");