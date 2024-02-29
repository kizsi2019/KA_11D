/*function jatek() {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
}

jatek();
(function() {
    var pont = math.random() * 10;
    console.log(pont >=5);
})();

(function(teszt) {
    var pont = math.random() * 10;
    console.log(pont >= 5);
    console.log(teszt);
})('Hello');*/


function nyugdij(ev) {
    var szoveg = "A nyugdíjazásig hátralévő évek száma: "
    return function(szuletesiEv) {
        var datumObjektum = new Data();
        var aktualisEv = datumObjektum.getFullYear();
        var kor = aktualisEv - szuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdíjazasUSA = nyugdij(66);
nyugdíjazasUSA(1959);
nyugdij(66)(1959);

/* Closure összefoglaló
Egy belső függvény mindig képes hozzáférni az őt tartalmazó külsö függvény paramétereihez és változóihoz, még azután is, hogy a külső függvény befejzte futását
*/