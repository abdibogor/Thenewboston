"use strict";

function addNumbers(a, b, c){
	console.log(a + b +c);
}

var nums =  [3, 4, 7];
addNumbers(...nums);

var meats =  ['bacon', 'bacon'],
var food =  ['supples', ...meats, 'kiwi', 'rice'];
console.log(food);