/*function game() {
    var point = Math.random() * 10;
    console.log(point >= 5);
}
game();
(function(){
    var point = Math.random() * 10;
    console.log(point >= 5);
})();
(function(test){
    var point = Math.random() * 10;
    console.log(point >= 5);
    console.log(test);
})('Hello');*/

function retirement(year) {
    var text = "Years left until retirement: ";
    return function (YearOfBirth){
        var dateObject = new Date();
        var actualYear = dateObject.getFullYear();
        var age = actualYear - YearOfBirth;
        console.log(text + (year - age));
    }
}
var retirementUSA = retirement(66);
retirement(1959);

//Closure summary
/*Egy belső függvény mindig képes hpzzáférni az őt tartalmazó
külső függvény paramétereihez és változóihoz, még azután is,
hogy a külső függvény befejezte futtatását
*/