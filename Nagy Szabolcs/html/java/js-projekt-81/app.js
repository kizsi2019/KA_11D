/*function parosVagyParatlanES6(...szamok) {
    console.log(szamok);
    szamok.forEach(aktualisElem => {
        if (aktualisElem % 2 === 0) {
            console.log('Paros');
        }else {
            console.log('Paratlan');
        }
    });
}

parosVagyParatlanES6(1, 2, 3);

function parosVagyParatlanES5(teszt) {

    var argumentumokTomb = Array.prototype.slice.call(arguments, 1);
    //console.log(argumentumokTomb);
    argumentumokTomb.forEach(function(aktualisElem) {
        if (aktualisElem % 2 ===0) {
            console.log('Paros');
        } else{
            console.log("Paratlan");
        }
    });
}
parosVagyParatlanES5(('teszt'),1, 2, 3, 100, 5,20);

function parosVagyParatlanES6(teszt, ...szamok) {
    //console.log(szamok);
    szamok.forEach(aktualisElem => {
        if (aktualisElem % 2 ===0 )
            console.log('Paros'); {
        }
    
    })
} 

//////////
function AdamsFamily(keresztnev, szueletsiEv, csaladiNev) {
    csaladiNev === undefined ? csaladiNev = 'Adams' : csaladiNev = csaladiNev;
    this.keresztnev = keresztnev;
    this.szueletsiEv = szueletsiEv;
    this.csaladiNev = csaladiNev;

}

var Fester = new AdamsFamily("Fester", 1940);
var Mortisha = new AdamsFamily("Mortisha", 1965);
var kuzin = new AdamsFamily("kuzin", 1800, 'Hogyishívják');

//es6
function AdamsFamily(keresztnev, szueletsiEv, csaladiNev = 'Adams') {

    this.keresztnev = keresztnev;
    this.szueletsiEv = szueletsiEv;
    this.csaladiNev = csaladiNev;

}

var Fester = new AdamsFamily("Fester", 1940);
var Mortisha = new AdamsFamily("Mortisha", 1965);
var kuzin = new AdamsFamily("kuzin", 1800, 'Hogyishívják');


///////////////////////////
// Map

const kerdes = new Map();
kerdes.set('kerdes', 'Hogy hívják a de miééért reklámban szereplő kisfiút?');
kerdes.set(1, 'Ödön');
kerdes.set(2, 'Ábel');
kerdes.set(3, 'Miklós');
kerdes.set(4, 'Nándi');

kerdes.set('helyes', 2);

kerdes.set(true, 'Helyes válasz');
kerdes.set(false, 'Helytelen válasz');

console.log(kerdes.get('kerdes'));
console.log(kerdes.size);



for (let [kulcs, ertek] of kerdes.entries()) {
    if (typeof(kulcs) === 'number'){
        console.log(`Kulcs: ${kulcs}, ertek: ${ertek}`);0
    }
}

const valasz = parseInt(prompt('Add meg a helyes választ'));
console.log(kerdes.get(valasz === kerdes.get('helyes')));


////////////////////////////////////////////////
// Osztályok

var SzemelyES5 = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
}

SzemelyES5.prototype.korSzamitas = function() {
    var kor = new Date().getFullYear - this.szuletesiEv;
    console.log(kor);
}

var odon = new SzemelyES5('Ödön', 1810, 'kísértet');

//ES6

class SzemelyES6 {
    constructor(nev, szuletesiEv, foglalkozas) {
        this.nev = nev;
        this.szuletesiEv = szuletesiEv;
        this.foglalkozas = foglalkozas;
    }
    korSzamitas() {
        let kor = new Date().getFullYear - this.szuletesiEv;
        console.log(kor);
    }

    static udvozlet() {
        console.log('Hello');
    }
}

const nandi = new SzemelyES6('Nándi',1960, 'Pék');*/

///////////////////////////////////////////////////
// Alosztályok

//ES5

var SzemelyES5 = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this. szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
}


SzemelyES5.prototype.korszamitas = function() {
    var kor = new Date().getFullYear() - this.szuletesiEv;
    console.log(kor);
}

var KatonaES5 = function(nev, szuletesiEv, foglalkozas, rendfokozat, osztag) {
    SzemelyES5.call(this, nev, szuletesiEv, foglalkozas) 
    this.rendfokozat = rendfokozat;
    this.osztag = osztag
}

KatonaES5.prototype = Object.create(SzemelyES5.prototype);

KatonaES5.prototype.rangszerzes = function(rang) {
    this.rendfokozat = rang;
    console.log(this.rendfokozat);
}

var odonKatona = new KatonaES5('Ödön', 1970, 'Pék', 'közlegény', 'harcosok');

odonKatona.korszamitas();
odonKatona.rangszerzes('szazados');

//ES6

class SzemelyES6 {
    constructor(nev, szuletesiEv, foglalkozas) {
        this.nev = nev;
        this. szuletesiEv = szuletesiEv;
        this.foglalkozas = foglalkozas;
    }
    korszamitas(){
        let kor = new Date().getFullYear() - this.szuletesiEv;
    console.log(kor);
    }
}

class katonaES6 extends SzemelyES6 {
    constructor(nev, szuletesiEv, foglalkozas, rendfokozat, osztag)
    {
        super(nev, szuletesiEv, foglalkozas);
        this.rendfokozat = rendfokozat;
        this.osztag = osztag;
    }

    rangszerzes(rang) {
        this.rendfokozat = rang;
        console.log(this.rendfokozat);
    }
}

const nandiKatona = new katonaES6('Nándi', 1960, 'Tiszt', 'harcosok osztaga');

nandiKatona.rangszerzes('szazados');
nandiKatona.korszamitas();