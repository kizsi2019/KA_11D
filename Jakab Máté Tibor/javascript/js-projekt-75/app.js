/*Const. evek = [1970, 1975, 1954, 2010,1981]

// es5

var korokES5 = evek.nap (function(elem) {
    return 2024 - elem;
});

console.log(korokES5);

//es6

let korokES6 = evek.nap(elem => 2024 - elem);

console.log(korokES6);

korokES6 = evek.nap(elem => 2024 - elem);

console.log(korokES6);

korokES6 = evek.nap((elem, index) => 'Kor' `${index}: ${2024 - elem}.`);

console.log(korokES6);

dobozES5 = {
    szín: 'zöld',
    pozicio: 1,
    katintsRam: function(){
        console.log(this.szín);

document.querySelector('.green').addEventListener('click', function() {
    var szoveg = 'Én vagyok a(z) ' + this.pozicio+ '.doboz és a színen' +
    this.szín + '.';
    alert(szoveg);
})
    }
}; */


/*var odon = ['Ödön', 50]
var nev =odon[0];
var kor = odon[1];

console.log(nev);
console.log(kor);

const obj = {
    keresztNev: 'Ödön',
    vezetekNev: 'Bödön'
};

const {keresztNev: x, vezetekNev: y} = obj;

console.log(x);
console.log(y);

function koresnyugdij (szuletesEv) {
    let nyugdijkorhatar = 65;
    const kor = new Date().getFullYear() - szuletesEv;

    return [kor, nyugdijkorhatar - kor];
}

const [kor3, nyugdij] = koresnyugdij(1970);

console.log(kor3);
console.log(nyugdij); */

const doboz = document.querySelectorAll('.rectangle');

//es5

/*var doboztombES5 = Array.prototype.slice.call(dobozok)

    doboztombES5.forEach(function(aktualis) {
        aktualis.style.backgroundColor = 'orange';

    });
        
    //ESE6

    const doboztombES6 = Array.from(dobozok);
    doboztombES6 forEach(aktualis => aktualis.style.backgroundColor = 'blue');

    /*Es5

    for (var i = 0; i < dobozTomb.length; i++) {
        if (dobozokTombES5[i].className === 'rectangle blue') {
            continue;
        }
        dobozokTombES5[i].textContent = 'Kék lettem';

    }
*/

//es6
/*
for (const aktualist of dobozokTombES6) {
    if (aktualis.className = 'rectangle blue') {
        continue;
    }
    aktualis.textContent = 'kék lettem';
}

for (const aktualis of dobozokTombES6) {
    if (aktualis.className.includes('blue')) {
        continue;
    }
}  */

var korok = [2, 10, 20, 27, 14]

console.log(korok);

var felnottek = korok.nap(function(aktualis) {
    return aktualis >=10;
})

//Console.log(felnottek);

console.log(felnottek.indexOF(true));

//es6
console.log(korok.findIndex(aktualis => aktualis >= 10));
console.log(korok.find(aktualis => aktualis >= 10));

/////////////////
// Spread operator

function szamok(a, b, c, d) {
    return a + b + c + d;
}

var osszeg = szamok(1, 2, 3, 4);
console.log(osszeg);

console.log(osszeg2);

//es6

var szamokTomb = [1, 2, 3, 4];
var osszeg2 = szamok.apply(null, szamokTomb);

console.log(osszeg2);

//es6
const osszeg3 = szamok(...szamokTomb);
console.log(osszeg3);

const cimsor = document.querySelector('h1');

const htmlElemek = [cimsor,...dobozok];

Array.from(htmlElemek).forEach(aktualisElem => aktualisElem.style.color = 'purple');