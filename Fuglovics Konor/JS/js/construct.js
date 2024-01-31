//Object literal
/*var Ödön = {
    name: "Ödön",
    dateofbirth: 1978,
    work: "graphic designer",
};*/

//Constructor function
var Person = function(name, dateofbirth, work){
    this.name = name;
    this.dateofbirth = dateofbirth;
    this.work = work;
};

//Prototype
Person.prototype.AgeCalculate = function(){
    console.log(2024 - this.dateofbirth);
};

Person.prototype.test = "test";

var Ödön = new Person('Ödön', 1978, 'graphic designer');
Ödön.AgeCalculate();

var Erzsi = new Person('Erzsi', 1950, 'retired');
Erzsi.AgeCalculate();

console.log(Person);
console.log(Ödön); 
console.log(Ödön.test);
console.log(Person.prototype);
console.log(Ödön.hasOwnProperty('name'));