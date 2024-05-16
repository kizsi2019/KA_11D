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
};

var odon = ['Ödön', 50]
var nev = odon[0];
var kor = odon[1];

console.log(nev);
console.log(kor);

const obj = {
    keresztnev: 'Ödön',
    vezeteknev: 'Bödön'
};
 
const { keresztnev: x, vezeteknev: y} = obj;

console.log(x);
console.log(y);

function koresnyugdij(szuleteEv) {
    let nyugdijkorhatar = 65;
    const kor = new Date().getFullYear() - szuleteEv;

    return [kor, nyugdijkorhatar - kor];
}

const [kor3, nyugdij] = koresnyugdij(1970);

console.log(kor3);
console.log(nyugdij);
*/
/*
const doboz = document.querySelectorAll('.rectangle');
*/
//eS5
/*
var doboztombES5 = Array.prototype.slice.call(dobozok)

    doboztombES5.forEach(function(aktualis) {
        aktualis.style.backgroundColor = 'orange' ;
    });
        
    */
//ES6
/*
const doboztombES6 = Array.from(dobozok);
doboztombES6 forEach(aktualis => aktualis.style.backgroundColor = 'blue');
/*
//es5
/*
for (var i= 0; i < doboztombES5.lenght; i++) {
    if (doboztombES5[i].className === 'rectangle blue') {
        continue;
    }
    doboű[i].textcontent = 'kék lettem';
}
*/

//es6
/*
for (const aktualis of doboztombES6) {
    if (aktualis.className === 'rectangle blue') {
        continue;
    }
    aktualis.textcontent ='kék lettem';
}
 */
/*
for (const aktualis of doboztombES6) {
    if (aktualis.className.includes('blue')) {
        continue
    }
}
    */
//es5
/*
var korok = [2, 10, 20, 17, 14]

console.log(korok);
 var felnottek = korok.map(function(aktualis) {
    return aktualis >= 18;
 });

 //console.log(felnottek);

 console.log(felnottek.indexOf(true));
 

 //es6
console.log(korok.findIndex(aktualis => aktualis >= 18));
console.log(korok(aktualis => aktualis >=18));
*/

////////////////////////////////////
//spread operátor

function szamok(a, b, c, d) {
    return a + b + c + d;
}

var osszeg = szamok1 (1, 2, 3, 4)
console.log(osszeg);

//es5
var szamokTomb = [1, 2, 3, 4];
var osszeg2 = szamok.apply(null, szamokTomb);

console.log(osszeg2);

//es6

const osszeg3 = szamok(...szamokTomb);
console.log(osszeg3);

const t2 = [5, 6, 7, 8, 9, 10];

const t3 =[...szamokTomb,...t2];
console.log(t3);

const cimsor = document.querySelector('h1');

const htmlElemek = [cimsor, ...dobozok];

Array.from(htmlElemek).forEach(aktualiselem => aktualiselem.style.color = 'purple');

