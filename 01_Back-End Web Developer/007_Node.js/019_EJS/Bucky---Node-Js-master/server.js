/**
 * Created by jayweb on 10/30/2015.
 */
var connect = require('connect');
var http  = require('http');

var app = connect();

http.createServer(app).listen(8888);
console.log('server is running ....');