function jatek() {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
}
jatek();
(function() {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
})();
(function(teszt) {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
    console.log(teszt);
})('Hello');

//Closure-ok

function nyugdij(ev) {
    var szoveg = "A nyugdíjazásig hátralévő évek száma: "
    return function(szuletesiEv) {
        var datumObjektum = new Date();
        var aktualisEv = datumObjektum.getFullYear();
        var kor = aktualisEv - szuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}
var nyugdijazasUSA = nyugdij(66);
nyugdijazasUSA(2005);
nyugdij(66)(2005)
/*closure össefoglaló
egy belső függvény mindig képes hozzáférni az őt tartalmazó külső függvény paramétereihez
és változóihoz, még azután is , hogy a külső függvény befejezte a futását
*/
