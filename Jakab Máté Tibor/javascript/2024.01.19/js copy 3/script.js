// objektum létrehozása

/*
var odon = {
    nev: 'Ödön',
    szuletesiEv: 1978,
    foglalkozas: 'grafikus'
};

var Szemely = function(nev, szuletesiEv, foglalkozas) {
    this .nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas
};

Szemely.prototype.korszamitas = function() {
    console.log(2021 - this.szuletesiEv);
};

Szemely.prototype.teszt = 'teszt';

var odon = new Szemely('ödön', 1978, 'grafikus');
odon.korszamitas();

var erzsi = new Szemely('Erzsi', 1950, 'nyugdíjas');
erzsi.korszamitas();

console.log(Szemely);
console.log(odon);
console.log(odon.teszt);



// Object.create

var SzemelyProto = {
    korszamitas: function() {
        console.log; 2024 - this.szuletesiEv();
    }
};

var odon = Object.create(SzemelyProto);

odon.nev = 'Ödön';
odon.szuletesiEv = 1960;
odon.foglalkozas = 'pék';

var kati = Object.create(SzemelyProto, {
    nev: {value: 'Kati'},
    szuletesiEv: {value:1990},
    foglalkozas: {value: 'kozmetikus'}
});



//Egyszerű adattípusok és objektumok

var x = 10;
var y = x;
x = 100;
console.log(x)
console.log(y)

var o1 = {
    sz: 100,
    m: 200
};

var o2 = o1;
o1.sz = 158;
console.log(o1.sz);
console.log(o2.sz);

var a = 10;
var o = {
    nev: 'Ödön',
    kor: 35
};

function mondosit(a, b) {
    a = 40;
    b.nev = 'Lajos'
};

mondosit(a, o);

console.log(a);
console.log(o.nev);*/

/*var evek = [1954, 1990, 1963, 200, 2010];

function tombMuvelet(tomb, fv) {
    var eredmeny = [];

    for (var i = 0; i < tomb.length; i++) {
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny
}

function korszamitas(elem) {
    return elem >= 18;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(korok);

var felnottek = tombMuvelet(korok, felnott);
console.log(felnottek);    */

/*function jatek() 
{
    var pont = Math.random()* 10;
    console.log.pont >= 5;
}
jatek();
(function() {
    var pont = Math.random()*10;
    console.log(pont >= 5);
})();

(function(teszt)
{
var pont = Math.random() * 10;
console.log(pont >=5);
console.log(teszt);
})("Hello"); */

//Closure-ők
/*function nyugdíj(ev) {
    var szoveg = "A nyugdíjazásig hátralévő évek száma: "
    return function (szuletesiEv) {
        var datumOvjektum = new Date();
        var aktualisEv = datumOvjektum.getFullYear();
        var kor = aktualisEv - szuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdíjazasUSA = nyugdíj(66);
nyugdíjazasUSA(1959);
nyugdíj(66)(1959); 
/* Closure összefoglaló
Egy belső fügvény mindig képes hozzáférni az öt tartalmazó
külső függvény paramétereihez és változóihoz, még azután is,
hogy a külső függvény befejezte futását


var nyugdíjazasHUN = nyugdíj(65);
var nyugdíjazasIZL = nyugdíj(67);
nyugdíjazasHUN(1959);
nyugdíjazasIZL(1959);

////////
var szamlalo = 0;

function leptet() {
    szamlalo++;
    console.log(szamlalo);
}
leptet();
leptet();
leptet();
*/

//var szamlalo = 0

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