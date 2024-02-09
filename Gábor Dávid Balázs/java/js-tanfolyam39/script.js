// IIFE
/*
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

//Closure-ök
function nyugdij(ev) {
    var szoveg = "A nyugdíjazásig hátralévő évek száma: "
    return function(szuletesiEv) {
        var datumObejktum = new Date();
        var aktualisEv = datumObejktum.getFullYear();
        var kor = aktualisEv - szuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdijazasUSA = nyugdij(66);
nyugdijazasUSA(1959);
nyugdij(66)(1959);

/* Closure összefoglaló
Egy belső függvény mindig képes hozzáférni az öt tartalmazó
külső függvény paraméteréhez és változóihoz, még aztuán is,
hogy a külő függvény befejezte futását.
*/
/*
var nyugdijazasHUN = nyugdij(65);
var nyugdijazasIZL = nyugdij(67);
nyugdijazasHUN(1959);
nyugdijazasIZL(1959);

/////////
var szamlalo = 0;

function leptet() {
    var szamlalo = 0;
    szamlalo++;
    console.log(szamlalo);
}
leptet();
leptet();
leptet();
*/

/*
var szamlalo = 0;

function leptet() {
    var szamlalo = 0;

    return function() {
        szamlalo++;
        console.log(szamlalo)
    }
}
var hozzaad = leptet();
hozzaad();
hozzaad();
hozzaad();
*/

var leptet = (
    function() {
        var szamlalo = 0;

        return function() {
            szamlalo++;
            console.log(szamlalo);
        }
    }
)();

leptet();
leptet();
leptet();