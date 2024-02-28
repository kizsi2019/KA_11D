// Objektum létrehozása
/*
var odon = {
nev: 'Ödön',
születésÉv:  1978,
 foglalkozás: 'grafikus'
};

var Szemely = function(nev, születésÉv, foglalkozás) {
this.nev = nev
this.születésÉv = születésÉv
this.foglalkozás = foglalkozás

};
Szemely.prototype.Korszamitas = function() {
    console.log(2024 - this.születésÉv)
}
Szemely.prototype.teszt = 'teszt';

var odon = new Szemely('ödön', 1978, 'grafikus');
odon.Korszamitas();

var  erzsi = new Szemely('Erzsi', 1950, 'nyugdíjas')
erzsi.Korszamitas();

console.log(Szemely);
console.log(odon);
console.log(odon.teszt)
s
*/
// Visszaadott fügvények
/*
function interjuKerdes(foglalkozás) {
    if (foglalkozás == 'tanar') {
        return function(nev) {
            console.log(nev + ', meg tudná mondani, hogy milyen tárgyakat tanít?')
        }
    } else if (foglalkozás == 'elado') {
        return function(nev) {
            console.log(nev + ',hogyan kezel egy vevő reklamációt?')
        }
    } else {
        return function(nev) {
            console.log('Mi a foglalkozása kedves ' +  nev + '?')
        }
    }
}



var kerdesTanaroknak = interjuKerdes('tanar');
kerdesTanaroknak('pál')
var kerdesEladoknak = interjuKerdes('elado')
kerdesEladoknak('Teri')
kerdesEladoknak('Feri')
kerdesEladoknak('Ági')

interjuKerdes('tanar')('Péter')
interjuKerdes('programozo')('Ödön')

*/
/*
function jatek() {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
    
}


jatek();
*/
/*
(function () {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
})();
*/
/*
(function(teszt) {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
    console.log(teszt);
}) ('Hello');
*/
// Closere-ök

function nyugdíj(ev) {
    var szoveg = "A nyugdíjazásig háralévő évek száma:"
    return function(szuletesíEv) {
        var dataumOjectum = new Date();
        var aktualisEv = dataumOjectum.getFullYear();
        var kor = aktualisEv - szuletesíEv;
        console.log(szoveg + (ev - kor));
    }

}
/*
var nyugdijazasUSA = nyugdíj(66);
nyugdijazasUSA(2005);
nyugdíj(66)(2005);

/* Clousere öszefoglaló
Egy belső függvény mindig képes hozzáférni az őt tartalmazó 
külső függvény paramétereihez és változóihoz, még azután is,
hogy a külső függvény befejezte futását.

*/
/*
var nyugdijazasHun = nyugdíj(65)
var nyugdijazasIZL = nyugdíj(67)
nyugdijazasHun(2005)
nyugdijazasIZL(2005)
*/

//////////////////////////////////////////////////////////////////////////////
//// BOSS INCUMING AHHH //////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////
/*
var szamlalo = 0;
function leptet() {
    szamlalo++;
    console.log(szamlalo);
}
leptet();
leptet();
leptet();
*/
/* var szamlalo = 0;

*/
/*
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
    console.log(szamlalo);
}

}
var hozzaad = leptet();
hozzaad();
hozzaad();
hozzaad();
*/
// 39 //
/*
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
leptet();
leptet();
leptet();
*/

// 40

/*
var odon = {
    nev: 'Ödön' ,
    kor: 45,
    foglalkozás: 'csillagász',
    üdvözlet: function(stilus, napszak) {
        if (stilus == 'hivatalos ') {
            console.log('Üdvözlöm, jó' + napszak + 'kívánok' + this.nev + 'Vagyok')
        } else if (stilus === 'baráti') {
            console.log('Szia, Jó '  + napszak + '!');
        }
        
    }
}

// odon.üdvözlet('hivalatos', 'Hajnalt')
// odon.üdvözlet('baráti', 'HMMMMT')

var béla = {
    nev: 'Béla',
    kor: 62,
    foglalkozás: 'portás'

}

// Call metódus
 //odon.üdvözlet.call(béla, 'baráti', 'Palacsintát')
/*
// apply 
odon.üdvözlet.apply(béla, ['baráti', 'Palacsintát'])

//bind
var odonBarati = odon.üdvözlet.bind(odon, 'baráti');
odonBarati('Palacsintát')
odonBarati('sexet')

 var belaHívatalos = odon.üdvözlet.bind(béla, 'hivatalos');
 var belaHívatalosNappszaki = odon.üdvözlet.bind(béla, 'hivatalos' , 'világvégét');

belaHívatalos('estét');
belaHívatalosNappszaki();
*/

var evek = [1954, 1990, 1990, 1963, 2000 , 2010];

function tombMuvelet(tomb, fv) {
    var eredmény = [];

    for (var i = 0; i < tomb.length; i++) {
        eredmény.push(fv(tomb[i]));
    }
    return eredmény;
};

function korszamitas(elem) {
    return 2024 - elem;
};

// console.log(korok) után
function felnott(korhatar, elem) {
    return elem >= korhatar;
};

var korok = tombMuvelet(evek, korszamitas);
console.log(evek);
console.log(korok);

var felnottkorJapanban = tombMuvelet(korok, felnott.bind(this, 20));

console.log(felnottkorJapanban);