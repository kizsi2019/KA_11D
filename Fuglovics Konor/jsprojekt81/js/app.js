//Classes
//ES5
var PersonES5 = function(name, yearobirth, interest)
{
    this.name = name;
    this.yearobirth = yearobirth;
    this.interest = interest;
}
PersonES5.prototype.agecalculate = function()
{
    var age = new Date().getFullYear - this.yearobirth;
    console.log(age);
}
var Ödön = new PersonES5('Ödön', 1810, 'ghost');

//ES6

class PersonES6
{
    constructor(name, yearobirth, interest)
    {
        this.name = name;
        this.yearobirth = yearobirth;
        this.interest = interest;
    }
    agecalculate()
    {
        let age = new Date().getFullYear - this.yearobirth;
        console.log(age);
    }
    static welcome()
    {
        console.log('Hello');
    }
}

const Nándi = new PersonES6('Nándi', 1960, 'Pék');
PersonES6.welcome();
PersonES6.agecalculate();