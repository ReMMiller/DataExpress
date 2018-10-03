console.log('Hello World!');

var a = 100;
a = "Bob";
a = ["Fred", 32, false, "Green"];

console.log(a);

a.push("FuckMyLife"); //Adds to end of array
console.log(a);

a.push([4,3,2]);
console.log(a[4][1]); // Prinst off the [1]char of a[4] if they are an array/string.

a.pop(); // Removes the last element
console.log(a);

a.unshift('Puppies'); // Adds element to the front.
console.log(a);


//OBJECTS open with curling braces

b = {
    x: 50, 
    y: 150,
    arr: a,
    name: "Deadly Deaderson"
};
console.log(b);
console.log(b.name);
console.log(b.arr[3]);


//FUNCTIONS

function hello(name){
    console.log("Hello, " + name);
};
hello("Fuck, Dis ma name??");

var bye = function(name){
    console.log("Goodbye, " + name);
};
bye("Nope");

var global = {
    whatever: function(name){
        console.log("whatever, " + name);
    }
};
global.whatever("Uhhhg again?");

global.bye = function(name){
    console.log("The world cries " + name);
};
global.bye("sharol")

//Contained within object -> No semicolon