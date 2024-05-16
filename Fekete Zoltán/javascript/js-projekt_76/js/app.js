// let és const
// es5

/*
var nev5 = 'Teszt Elek';
var kor5 = 40;

nev5 = 'Kiss Pista';

console.log(nev5);

//es5
 function nyelvVizsga5(siker) {
    if (siker) {
        var keresztnev = 'Ödön';
        var szuletesiEv = 1980;
        console.log(keresztnev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga');
    }

}

nyelvVizsga5(true);

//es6

//const nev6 = 'Teszt Elek';
//let kor6 = 40;

//nev6 = 'Kiss Pista'; // hibát dob

//console.log(nev6);

function nyelvVizsga6(siker) {
    if (siker) {
        let keresztNev = 'Ödön';
        const szuletesiEv = 1980;
        console.log(keresztNev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga');
    }

}

nyelvVizsga6(true);
*/

/*
let i = 9;
for (let i = 0; i < 5; i++) {
    console.log(i);
}

console.log(i);
*/

/*
var i = 9;
for (var i = 0; i < 5; i++) {
    console.log(i);
}

console.log(i);
*/

// Blokkok és IIFE
// es6
/*
{
    const a = 1;
    let b = 2;
    //var c = 3;
}

console.log(a + b);

// es5

(function() {
    let c = 3;
    console.log(c);
})();

console.log(c);
*/
/*
let vezeteknev = 'Teszt';
let keresztnev = 'Elek';

const szuletesiEv = 1970;

function korSzamitas(ev) {
    return 2024 - ev;
}

//es5

console.log(vezeteknev + ' ' + keresztnev + ', született ' + szuletesiEv + '-ben. Most ' + korSzamitas(szuletesiEv) + ' éves');

//es6

console.log(`${vezeteknev} ${keresztnev}, született ${szuletesiEv}-ben. Most ${korSzamitas(szuletesiEv)} éves.`);

const nev = `${vezeteknev} ${keresztnev}`;

console.log(nev.startsWith('T')); 

console.log(nev.endsWith('ek'));

console.log(nev.includes('ele'));

console.log(vezeteknev.repeat(3));

console.log(`${vezeteknev} `.repeat(3));
*/
/*
const evek = [1970, 1975, 1954, 2010, 1981];

var korokES5 = evek.map(function(elem){
    return 2024 - elem
} );

console.log(korokES5)

// es6

let korokES6 = evek.map(elem => 2024 - elem);

console.log(korokES6)

korokES6 = evek.map((elem, index) => `Kor ${index}: ${2024 - elem}.`);

console.log(korokES6);

korokES6 = evek.map((elem, index) => {
    const aktEv = new Date().getFullYear();
    const kor = aktEv - elem;
    return `Kor ${index}: ${kor},`;
})

console.log(korokES6);
*/
/*var dobozES5 = {
    szin: 'zöld',
    pozicio: 1,
    KattintsRam: function() {
        var objektum = this;
        document.querySelector('.green').addEventListener('click', function() {
            var szoveg = 'Én vagyok a(z) ' + objektum.pozicio + '. doboz és a színem ' + objektum.szin + '.';
            alert(szoveg);
        })
    }
};

dobozES5.KattintsRam();*/

//ES6

/*const dobozES6 = {
    szin: 'zöld',
    pozicio: 1,
    KattintsRam: function() {
        document.querySelector('.green').addEventListener('click', () => {
            var szoveg = 'Én vagyok a(z) ' + this.pozicio + '. doboz és a színem ' + this.szin + '.';
            alert(szoveg);
        })
    }
};

dobozES6.KattintsRam();*/

/*function Szemely(nev) {
    this.nev = nev;
}*/

/*Szemely.prototype.barataimES5 = function(haverok) {
    //console.log(this.nev);
    var obj = this;
    var tomb = haverok.map(function(elem) {
        return obj.nev + ' barátja ' + elem + '.';
    });
    console.log(tomb);
}

new Szemely('Géza').barataimES5(haverok);*/
/*var haverok = ['Jóska', 'Pista', 'Ödön'];

//es6

Szemely.prototype.barataimES6 = function(haverok) {
    const tomb = haverok.map(elem =>
        `${this.nev} barátja ${elem}.`
    );
    console.log(tomb);
}

new Szemely('Géza').barataimES6(haverok);*/

/*
//es5
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
}

const {keresztNev, vezetekNev} = obj;

console.log(keresztNev);
console.log(vezetekNev);

const {keresztNev: x, vezetekNev: y} = obj;

console.log(x);
console.log(y);

function korEsNyugdij(szuletesiEv) {
    let nyugdijKorhatar = 65;
    const kor = new Date().getFullYear() - szuletesiEv;

    return [kor, nyugdijKorhatar - kor];
}*/

////////////////////////////////////////////////////////////////////////////////////////
//Tömbök

const dobozok = document.querySelectorAll('.rectangle');

//es5

var dobozokTombES5 = Array.prototype.slice.call(dobozok)

    dobozokTombES5.forEach(function(aktualis) {
        aktualis.style.backgroundColor = 'orange';
    });

//es6

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
*/

//es6

/*for (const aktualis of dobozokTombES6) {
    if (aktualis.className === 'rectangle blue') {
        continue;
    }
    aktualis.textContent = 'Kék lettem';
}*/

/*for (const aktualis of dobozokTombES6) {
    if (aktualis.className.includes('blue')) {
        continue;
    }
    aktualis.textContent = 'Kék lettem';
}*/

//es5
/*var korok = [2, 10, 20, 17, 14]

console.log(korok);

var felnottek = korok.map(function(aktualis){
    return aktualis >= 18;
});

//console.log(felnottek);

console.log(felnottek.indexOf(true));

//es6
console.log(korok.findIndex(aktualis => aktualis >= 18));
console.log(korok.find(aktualis => aktualis >= 18));*/

//////////////////////////////////////////////////////////////////////////////////
// Spread operátor
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