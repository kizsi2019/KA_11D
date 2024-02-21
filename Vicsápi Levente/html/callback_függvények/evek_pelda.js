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
*/

//Visszaadott függvények

/*
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
*/

/*
function jatek(){
    var pont = Math.random() * 10;
    console.log(pont >= 5);
}

jatek();
(function(){
    var pont = Math.random() * 10;
    console.log(pont >= 5);
})();

(function(teszt){
    var pont = Math.random() * 10;
    console.log(pont >= 5);
    console.log(teszt);
})('Hello');
*/

//Clousure-ök


function nyugdij(ev){
    var szoveg = "A nyugdíjazásig hátralévő évek szánma: "
    return function(szuletisiEv){
        var datumObjektum = new Date();
        var aktualisEv = datumObjektum.getFullYear();
        var kor = aktualisEv - szuletisiEv;
        console.log(szoveg + (ev - kor))
    }
}


/*
var nyugdijazasUSA = nyugdij(66);
nyugdij(66)(2004);


/* Clousure összefoglaló
Egy belső függvény mindig képes hozzáférni az őt tartalmazó
külső függvény paramétereihez és változóhoz, még azután is,
hogy a külső függvény befejezte futásait
*/

/*
var nyugdijazasHUN = nyugdij(65);
var nyugdijazasIZL = nyugdij(67);
nyugdijazasHUN(2004);
nyugdijazasIZL(2004);
*/

/*
var szamlalo = 0;

function leptet(){
    szamlalo++;
    console.log(szamlalo);
}*/

/*
var szamlalo = 0;
function leptet(){
    var szamlalo = 0;
    szamlalo++;
    console.log(szamlalo);
}
*/

/*
var szamlalo = 0;
function leptet(){
    var szamlalo = 0;

    return function(){
        szamlalo++;
        console.log(szamlalo);
    }
}

var hozzaad = leptet();
*/
/*
hozzaad();
hozzaad();
hozzaad();
*/

/*
var leptet = (
    function(){
        var szamlalo = 0;

        return function(){
            szamlalo++;
            console.log(szamlalo);
        }
    }
)();

leptet();
leptet();
leptet();
*/

/*
var odon = {
    nev: 'Ödön',
    kor: 45,
    foglalkozás: 'csillagász',
    udvozlet: function(stilus, napszak){
        if (stilus === 'hivatalos'){
            console.log('Üdvözlöm, jó ' + napszak + ' kívánok! ' + this.nev + ' vagyok');
        } else if (stilus === 'baráti'){
            console.log('Szia, jó ' + napszak + '!');
        }
    }
}

odon.udvozlet('hivatalos', 'hajnalt');
odon.udvozlet('baráti', 'estét');

var bela = {
    nev: 'Béla',
    kor: 62,
    foglalkozás: 'portás'
}
*/

/*
odon.udvozlet.call(bela, 'baráti', 'estét');

odon.udvozlet.apply(bela, ['baráti', 'estét']);
*/

/*
var odonBarati = odon.udvozlet.bind(odon, 'baráti');
odonBarati('napot');
odonBarati('estét');
*/

/*
var belaHivatalos = odon.udvozlet.bind(bela, 'hivatalos');
var belahivatalosReggeli = odon.udvozlet.bind(bela, 'hivatalos', 'reggelt');

belaHivatalos('estét');
belahivatalosReggeli();
*/

var evek = [1954, 1990, 1963, 2000, 2010];

function tombMuvelet(tomb, fv){
    var eredmeny = [];

    for (var i = 0; i < tomb.length; i++){
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;
};

function korszamitas(elem){
    return 2024 - elem;
};

function felnott(korhatar, elem){
    return elem >= korhatar;
};

var korok = tombMuvelet(evek, korszamitas);
console.log(evek);
console.log(korok);


var felnottkorJapanban = tombMuvelet(korok, felnott.bind(this, 20));
console.log(felnottkorJapanban);