function Person(type, name){
    this.type = type;
    this.name = name;
    this.status = 'alive';

}

Person.prototype.speak = function(words){
    this.words = words;
    console.log(this.name + " says '" + this.words + "'.");
}

var george = new Person('victim', 'George');
console.log(george.name + ' the ' + george.type + ', is '+ george.status + ".");

var bob = new Person('zombie', 'Bob');
bob.status = 'undead';
console.log(bob.name + ' the ' + bob.type + ' is ' + bob.status + ".");

bob.speak("I hate you");