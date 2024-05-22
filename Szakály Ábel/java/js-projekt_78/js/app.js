// Destruktálás

//es5
/*
var odon = ['Ödön', 50]
var nev = odon[0];
var kor = odon[1];

console.log(nev);
console.log(kor);

//es6
const [nev2, kor2] = ['Ödön', 50];

console.log(nev);
console.log(kor);

const obj = {
    keresztNev: 'Ödön',
    vezetekNev: 'Bödön'
};

const { keresztNev, vezetekNev } = obj;

console.log(keresztNev);
console.log(vezetekNev);

const { keresztNev: x, vezetekNev: y } = obj;

console.log(x);
console.log(y);

function korEsNyugdij(szuletesiev) {
    let nyugdijKorhatar = 65;
    const kor = new Date().getFullYear() - szuletesiev;

    return [kor, nyugdijKorhatar - kor];
}

const [kor3, nyugdij] = korEsNyugdij(1978);

console.log(kor3);
console.log(nyugdij);

// Tömbök


//es5

var dobozokTombES5 = Array.prototype.slice.call(dobozok)

    dobozokTombES5.forEach(function(aktualis) {
        aktualis.style.backgroundColor = 'Orange';
    });

// es6

const dobozokTombES6 = Array.from(dobozok);
dobozokTombES6.forEach(aktualis => aktualis.style.backgroundColor = 'blue');

//es5
/*
for (var i = 0; i < dobozokTombES5.length; i++) {
    if (dobozokTombES5[i].className === 'rectangle blue') {
        continue;
    }
    dobozokTombES5[i].textContent = 'Kék lettem';
}

//es6

for (const aktualis of dobozokES6) {
    if (aktualis.className === 'rectangle blue') {
        continue;
    }
    aktualis.textContent = 'Kék lettem'
}*/
/*
for (const aktualis of dobozokTombES6) {
    if (aktualis.className.includes('blue')) {
        continue;
    }
    aktualis.textContent = 'Kék lettem';
}*/

//es5
/*
var korok = [2, 10, 20, 17, 14]

console.log(korok);

var felnottek = korok.map(function(aktualis){
    return aktualis >= 18;
});

console.log(felnottek);
console.log(felnottek.indexOf(true));

//es6
console.log(korok.findIndex(aktualis => aktualis >= 18));
console.log(korok.find(aktualis => aktualis >= 18));
*/
// Spread Operátór
/*const dobozok = document.querySelectorAll('.rectangle');

function szamok(a, b, c, d) {
    return a + b + c + d;
}

var osszeg = szamok(1, 2, 3, 4);
console.log(osszeg);

//es5
var szamokTomb = [1, 2, 3, 4];
var osszeg2 = szamok.apply(null, szamokTomb);

console.log(osszeg2);

//es6

const osszeg3 = szamok(...szamokTomb);
console.log(osszeg3);

const t2 = [5, 6, 7, 8, 9, 10];

const t3 = [...szamokTomb, ...t2];
console.log(t3);

const cimsor = document.querySelector('h1');

const htmlElemek = [cimsor, ...dobozok];

Array.from(htmlElemek).forEach(aktualisElem => aktualisElem.style.color = 'purple');

// Rest paraméterek

// es5

function parosVagyParatlanES5() {
    //console.log(arguments);
    var argumentumokTomb = Array.prototype.slice.call(arguments);
    //console.log(argumentumokTomb);
    argumentumokTomb.forEach(function(aktualisElem) {
        if (aktualisElem % 2 === 0) {
            console.log('Paros');
        } else {
            console.log('Paratlan');
        }
    });
}

parosVagyParatlanES5(1, 2, 3);

// es6

function parosVagyParatlanES6(...szamok) {
    //console.log(szamok);
    szamok.forEach(aktualisElem => {
        if (aktualisElem % 2 === 0) {
            console.log('Paros');
        } else {
            console.log('Paratlan');
        }
    });
}

parosVagyParatlanES6(1, 2 ,3);


function parosVagyParatlanES5(teszt) {
    var argumentumokTomb = Array.prototype.slice.call(arguments, 1);
    //console.log(argumentumokTomb);
    argumentumokTomb.forEach(function(aktualisElem) {
        if (aktualisElem % 2 === 0) {
            console.log('Paros')
        } else {
            console.log('Paratlan');
        }
    });
}

parosVagyParatlanES5('teszt', 1, 2, 3, 100, 5, 20);



function parosVagyParatlanES6(teszt, ...szamok) {
    //console.log(szamok);
    szamok.forEach(aktualisElem => {
        if (aktualisElem % 2 === 0) {
            console.log('Paros')
        } else {
            console.log('Paratlan');
        }
    });
}

parosVagyParatlanES5('teszt', 1, 2, 3, 10, 20, 25);

function AdamsFamily(keresztNev, szuletesiev, csaladiNev) {
    csaladiNev === undefined ? csaladiNev = 'Adams' : csaladiNev = csaladiNev;
    this.keresztNev = keresztNev;
    this.szuletesiev = szuletesiev;
    this.csaladiNev = csaladiNev;
}

var fester = new AdamsFamily('Fester', 1940);
var mortisha = new AdamsFamily('Mortisha', 1965);
var kuzin = new AdamsFamily('Kuzin', 1800, 'Hogyishívják');

// es6

function AdamsFamily(keresztNev, szuletesiev, csaladiNev = 'Adams') {
    this.keresztNev = keresztNev;
    this.szuletesiev = szuletesiev;
    this.csaladiNev = csaladiNev;
}

var fester = new AdamsFamily('Fester', 1940);
var mortisha = new AdamsFamily('Mortisha', 1965);
var kuzin = new AdamsFamily('Kuzin', 1800, 'Hogyishívják?');

// Map 

const kerdes = new Map();
kerdes.set('kerdes', 'Hogy hívják a de miééért reklámba szereplő kisfiút?');
kerdes.set(1,'Ödön');
kerdes.set(2,'Ábel');
kerdes.set(3,'Miklóska');
kerdes.set(4,'Nándi');

kerdes.set('helyes', 2);

kerdes.set(true, 'Helyes válasz');
kerdes.set(false, 'Nem talált');

console.log(kerdes.get('kerdes'));
console.log(kerdes.size);

kerdes.delete(4);

if(kerdes.has(3)){
    kerdes.delete(3);
}

kerdes.clear();

kerdes.forEach(
    (kulcs, ertek) => console.log(`Kulcs: ${kulcs}, ertek: ${ertek}`));

for( let [kulcs, ertek] of kerdes.entries()){
    if (typeof(kulcs) === 'number') {
        console.log(`Kulcs: ${kulcs}, ertek: ${ertek}`);
    }
}


const valasz = parseInt(prompt('Add meg a helyes választ'));
console.log(kerdes.get(valasz === kerdes.get('helyes')));



//ES5
var SzemlyES5 = function(nev, szuletesiev, foglalkozas){
    this.nev = nev;
    this.szuletesiev = szuletesiev;
    this.foglalkozas = foglalkozas;
}

SzemlyES5.prototype.korszamitas = function(){
    var kor = new Date().getFullYear - this.szuletesiev;
    console.log(kor);
}

var odon = new  SzemlyES5('Ödön', 1810, 'kísértet');

//ES6

class SzemelyES6{
    constructor(nev, szuletesiev, foglalkozas){
        this.nev = nev;
        this.szuletesiev = szuletesiev;
        this.foglalkozas = foglalkozas;
    }
    korSzamitas() {
        let kor = new Date().getFullYear - this.szuletesiev;
        console.log(kor);
    }


    static udvozlet(){
        console.log('Hello');
    }
}

const nandi = new SzemelyES6('Nándi', 1960, 'Pék');
SzemelyES6.udvozlet();


var SzemelyES5 = function(nev, szuletesiev, foglalkozas){
    this.nev = nev;
    this.szuletesiev = szuletesiev;
    this.foglalkozas = foglalkozas;
}

SzemelyES5.prototype.korszamitas = function(){
    var kor = new Date().getFullYear() - this.szuletesiev;
    console.log(kor);
}

var KatonaES5 = function(nev, szuletesiev, foglalkozas, rendfokozat, osztag){
    SzemelyES5.call(this, nev, szuletesiev, foglalkozas)
    this.rendfokozat = rendfokozat;
    this.osztag = osztag;
}

KatonaES5.prototype = Object.create(SzemelyES5.prototype);

KatonaES5.prototype.rangszerzes = function(rang){
    this.rendfokozat = rang;
    console.log(this.rendfokozat);
}

var odonKatona = new KatonaES5('Ödön', 1970, 'Pék', 'közlegény', 'harcosok');

odonKatona.korszamitas();
odonKatona.rangszerzes('szazados');

//ES6

class SzemelyES6 {
    constructor(nev, szuletesiev, foglalkozas){
        this.nev = nev;
        this.szuletesiev = szuletesiev;
        this.foglalkozas = foglalkozas;
    }
    korszamitas(){
        let kor = new Date().getFullYear() - this.szuletesiev;
        console.log(kor);
    }
}


class KatonaES6 extends SzemelyES6{
    constructor(nev, szuletesiev, foglalkozas, rendfokozat, osztag){
        super(nev, szuletesiev, foglalkozas);
        this.rendfokozat = rendfokozat;
        this.osztag = osztag;
    }

    rangszerzes(rang){
        this.rendfokozat = rang;
        console.log(this.rendfokozat);
    }
}

const nandiKatona = new KatonaES6('Nándi', 1960, 'Tiszt', 'harcosok osztaga');

nandiKatona.rangszerzes('szazados');
nandiKatona.korszamitas();


const masodik = () => {
    console.log('masodik')
};

const elso = () => {
    console.log('elso')
    masodik();
    console.log('harmadik')
};

elso();
*/

const masodik = () =>{
    setTimeout(() => {
        console.log('Asszinkron masodik')
    }, 6000);
};

const elso = () => {
    console.log('elso')
    masodik();
    console.log('harmadik')
};

elso();