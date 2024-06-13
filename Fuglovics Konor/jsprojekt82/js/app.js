//Subclasses
//ES5
var PersonES5 = function(name, yearobirth, interest)
{
    this.name = name;
    this.yearobirth = yearobirth;
    this.interest = interest;
}
PersonES5.prototype.agecalculate = function()
{
    var age = new Date().getFullYear() - this.yearobirth;
    console.log(age);
}
var SoldierES5 = function(name,yearobirth, interest, grade, squad)
{
    PersonES5.call(this, name, yearobirth, interest)
    this.grade = grade;
    this.squad = squad;
}
SoldierES5.prototype = Object.create(PersonES5.prototype);
SoldierES5.prototype.rankobtain = function(rank)
{
    this.grade = rank;
    console.log(this.grade);
}
var ÖdönKatona = new SoldierES5('Ödön', 1970, 'Pék', 'közlegény', 'harcosok');
ÖdönKatona.agecalculate();
ÖdönKatona.rankobtain('százados');

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
        let age = new Date().getFullYear() - this.yearobirth;
        console.log(age);
    }
}
class SoldierES6 extends PersonES6
{
    constructor(name, yearobirth, interest, grade, squad)
    {
        super(name, yearobirth, interest);
        this.grade = grade;
        this.squad = squad;
    }
    rankobtain(rank)
    {
        this.grade = rank;
        console.log(this.grade);
    }
}
const NándiKatona = new SoldierES6('Nándi', 1960, 'Tiszt', 'harcosok osztaga');

NándiKatona.rankobtain('százados');
NándiKatona.agecalculate();