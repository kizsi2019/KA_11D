/*
var evek = [1954, 1990, 1963, 2000, 2010];

function tombMuvelet(tomb, fv){
    var eredmeny = []

    for (var i = 0; i < tomb.length; i++){
        eredmeny.push(fv(tomb[i]))
    }
    return eredmeny
}

function korszamitas(elem){
    return 2024 - elem;
}

function felnott(elem){
    return elem >= 18;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(korok);

var felnottek = tombMuvelet(korok, felnott);
console.log(felnottek);


//Visszaadott függvények

function interjuKerdes(foglalkozas){
    if (foglalkozas == 'tanar'){
        return function(nev){
            console.log(nev + ', meg tudná mondani, hogy milyen tárgyakat tanít?');
        }
    }

    else if (foglalkozas == 'elado'){
        return function(nev){
            console.log(nev + ', hogyan kezel egy vevő reklamációt?');
        }
    }
    else{
        return function(nev){
            console.log('Mi a foglalkozása kedves ' + nev + '?')
        }
    }

   
}

var kerdesTanaroknak = interjuKerdes('tanar');
kerdesTanaroknak('Pál');

var kerdesEladoknak = interjuKerdes('elado');
kerdesEladoknak('Tomi');
kerdesEladoknak('Teri');
kerdesEladoknak('Feri');
kerdesEladoknak('Ági');

interjuKerdes('tanar')('Péter');
interjuKerdes('programozó')('Ödön');


function jatek() 
{
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
})("Hello");

*/

//Closure-ök
function nyugdij(ev) {
    var szoveg = "A nyugdíjazásig hátralévő évek száma: "
    return function (szuletesiEv) {
        var datumOvjektum = new Date();
        var aktualisEv = datumOvjektum.getFullYear();
        var kor = aktualisEv - szuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdijazasUSA = nyugdij(66);
nyugdijazasUSA(1959);
nyugdij(66)(1959);

// closure összefoglaló
// egy belső függvény mindig képest hozzáférni az őt tartalmazó külső függvny paramétereihez
// még aztuán is hogy a külső függvény befejezte a futtatását

var nyugdijazasHUN = nyugdij(65);
var nyugdijazasIZL = nyugdij(67);
nyugdijazasHUN(1959);
nyugdijazasIZL(1959);

var szamlalo = 0;

function leptet() {
    var szamlalo = 0;

    return function() {
        szamlalo++;
        console.log(szamlalo);
    }
}

var hozzaad = leptet();
leptet();
leptet();
leptet();