/*function retirement(year) {
    var text = "Years left until retirement: ";
    return function (YearOfBirth){
        var dateObject = new Date();
        var actualYear = dateObject.getFullYear();
        var age = actualYear - YearOfBirth;
        console.log(text + (year - age));
    }
}
var retirementUSA = retirement(66);
retirement(1959);*/

//Closure summary
/*Egy belső függvény mindig képes hpzzáférni az őt tartalmazó
külső függvény paramétereihez és változóihoz, még azután is,
hogy a külső függvény befejezte futtatását
*/

/*var retirementHUN = retirement(65);
var retirementISL = retirement(67);
retirementHUN(2005);
retirementISL(2005);*/

/*var counter = 0;
function step(){
    counter++;
    console.log(counter);
}
step();
step();
step();*/
/*var counter = 0;
function step(){
    var counter = 0;
    counter++;
    console.log(counter);
}
step();
step();
step();*/

/*var counter = 0;
function step(){
    var counter = 0;
    return function(){
        counter++;
        console.log(counter);
    }
}
var add = step();
add();
add();
add();*/

var step = (
    function(){
        var counter = 0;
        return function(){
            counter++;
            console.log(counter);
        }
    }
)();
step();
step();
step();