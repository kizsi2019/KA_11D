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

var nyugdijazasHUN = nyugdij(65);
var nyugdijazasIZL = nyugdij(67);

nyugdijazasHUN(2005);
nyugdijazasIZL(2005);
/////////////////////////////////////////////
var szamlalo = 0;

function leptet() {
    szamlalo++;
    console.log(szamlalo);
}
leptet();
leptet();
leptet();


var szamlalo = 0;

function leptet() {
    var szamlalo = 0;
    szamlalo++;
    console.log(szamlalo);
}
leptet();
leptet();
leptet();

var szamlalo = 0;

function leptet() {
    var szamlalo = 0;
    return function() {
        szamlalo++;
        console.log(szamlalo);
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
