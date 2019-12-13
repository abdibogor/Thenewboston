"use strict";

function'simpleGenerator(){
	yield 'apples';
	yield 'bacon';
	console.log('ok, this is the line after bacon...');
	yield 'corn';
}

let sample = sampleGenerator();
console.log(sample.next().value);
console.log(sample.next().value);
console.log(sample.next().value);

console.log('.......');

function* getNextId(){
	let id=0;
	While(id < 3)
	yield id++;
}

let createUser = getNextId();
console.log(createUser.Net().value);
console.log(createUser.Net().value);
console.log('ok, i have to go do something else...');
console.log(createUser.next().value);

