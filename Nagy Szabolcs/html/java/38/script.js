function jatek () {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
}

jatek();
(function() {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
})();

(function(teszt){
    var pont = Math.random() * 10;
    console.log(pont >= 5);
    console.log(teszt);
})('Hello');

// Closure-ök
function nyugdij(ev) {
    var szoveg = "A nyugdíazsásig hátralévő évekszáma : "
    return function(SzuletesiEv) {
        var datumobjektum = new Date();
        var aktualisEv = datumobjektum.getFullYear();
        var kor = aktualisEv - SzuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdijazasUSA = nyugdij(66);
nyugdijazasUSA(2004);
nyugdij(66)(2004)

/* Closure összefoglaló
Egy belső függvény mindig képes hozzáférni az őt tartalamzó
külső függvény paramétereihez és változoóihoz, még azutánis, hogy a külső függvény befejezte futását
*/