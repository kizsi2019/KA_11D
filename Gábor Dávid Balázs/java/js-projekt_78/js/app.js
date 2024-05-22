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
*/

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