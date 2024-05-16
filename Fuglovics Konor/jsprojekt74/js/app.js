function Person(name)
{
    this.name = name;
}

/*Person.prototype.FriendsES5 = function(buddies)
{
    var obj = this;
    var block = buddies.map(function(element)
    {
        return `${obj.name} barátja ${element}.`
    });
    console.log(block);
}
var buddies = ["Jóska", "Pista", "Ödön"];
new Person('Géza').FriendsES5(buddies);

//ES6

Person.prototype.FriendsES6 = function(buddies)
{
    const block = buddies.map(element => `${this.name} barátja ${element}.`);
    console.log(block);
}
new Person('Gábor').FriendsES6(buddies);*/

//Destructuring

//ES5
var Ödön = ['Ödön', 50];
var username = Ödön[0];
var age = Ödön[1];

console.log(username);
console.log(age);

//ES6
const [name2, age2] = ['Ödön', 50];

console.log(name2);
console.log(age2);

const obj =
{
    firstname: "Ödön",
    lastname: "Bödön"
};

const{firstname: x, lastname: y} = obj;

console.log(x);
console.log(y);

function AgesAndRetires(yearobirth)
{
    let RetiringDeadline = 65;
    const age = new Date().getFullYear() - yearobirth;

    return[age, RetiringDeadline - age];
}

const[age3, retire] = AgesAndRetires(1978);

console.log(age3);
console.log(retire);
