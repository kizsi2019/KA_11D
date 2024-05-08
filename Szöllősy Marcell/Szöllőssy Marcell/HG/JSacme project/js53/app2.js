/*var nev5 = 'Teszt Elek';
var kor5 = 40;

nev5 = 'Kiss Pista';

console.log(nev5);

function nyelvVizsga5(siker) {
    if (siker) {
        var keresztnev = 'Ödön';
        var szuletesiEv = 1980;
        console.log(keresztnev + '(születési év: ' + szuletesiEv + ') sikeres volt a viszga');
    }

}

nyelvVizsga5(true);

const nev6 = 'Teszt Elek';
let kor6 = 40;
 
// nev6 = 'Kiss Pista';

// console.log(nev6);

function nyelvVizsga6(siker) {
    if (siker) {
        var keresztnev = 'Ödön';
        const szuletesiEv = 1980;
        console.log(keresztnev + '(születési év: ' + szuletesiEv + ') sikeres volt a viszga');
    }
}

nyelvVizsga6(true);

let i = 9;
for (let i = 0; i < 5; i++) {
    console.log(i);
}

console.log(i);

var i = 9;
for (var i = 0; i < 5; i++) {
    console.log(1);
}

console.log(i);*/


////////////////////////////////////////////////////////////////////////////////////////////////////////
//Blokkok és IIFE
//ES6
/*
{
    const a = 1;
    let b = 2;
    var c = 3;

}

console.log(a + b);

(function() {
    let c = 3; 
    console.log(c);
})();
console.log(c);
*/

//////////////////////////////////////////////////////
// Sztringek ES6-ban

/*let vezeteknev = 'Teszt';
let keresztnev = 'Elek';

const szuletesiEv = 1970;

function korszamitas(ev) {
    return 2024 - ev;
}

console.log(vezeteknev + '' + keresztnev +', született ' + szuletesiEv + '-ben. Most ' + korszamitas(szuletesiEv) + ' éves');

console.log(`${vezeteknev} ${keresztnev}, született ${szuletesiEv}-ben. Most ${korszamitas(szuletesiEv)} éves.`);

const nev = `${vezeteknev} ${keresztnev}`;

console.log(nev.startsWith('T'));

console.log(nev.endsWith('ek'));

console.log(nev.includes('ele'));

console.log(vezeteknev.repeat(3));

console.log(`${vezeteknev}`.repeat(3));*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Nyíl függvények

const evek = [1970, 1975, 1954, 2010, 1981];

// es5

var korokES5 = evek.map(function(elem) {
    return 2024 - elem;
});

console.log(korokES5);

// es6
/*
let korokES6 = evek.map(elem => 2024 - elem);

console.log(korokES6);

korokES6 = evek.map((elem, index) => `Kor ${index}: ${2024 - elem}.`);

console.log(korokES6)

korokES6 = evek.map((elem, index) => {
    const aktEv = new Data().getFullYear();
    const kor = aktEv - elem;
    retunr `Kor ${index}: ${kor},`;
});

console.log(korokES6)
*/
/*
var dobozES5 = {
    szin: 'zöld',
    pozicio: 1,
    kattintsRam: function() {
        var objektum = this;

        document.querySelector('.green').addEventListener('click', function(){
            var szoveg = 'Én vagyok a(z) ' + objektum.pozicio + '. doboz és a szinem ' + objektum.szin + '.';
            alert(szoveg)
        })
    }
};

dobozES5.kattintsRam();
*/
/*
var dobozES6 = {
    szin: 'zöld',
    pozicio: 1,
    kattintsRam: function() {

        document.querySelector('.green').addEventListener('click', () => {
            var szoveg = 'Én vagyok a(z) ' + this.pozicio + '. doboz és a szinem ' + this.szin + '.';
            alert(szoveg)
        })
    }
};

dobozES6.kattintsRam();
*/
/*
function Szemely(nev) {
    this.nev = nev;
}

Szemely.prototype.barataimES5 = function(haverok) {
    var obj = this
    var tomb = haverok.map(function(elem) {
        return obj.nev + ' barátja' + elem + '.';
    });
    console.log(tomb)
}

var haverok = ['Jóska', 'Pista', 'Ödön'];
new Szemely('Géza').barataimES5(haverok);
*/
//ES6

Szemely.prototype.barataimES6 = function(haverok) {

    const tomb = haverok.map(elem => `${this.nve} baratja ${elem}.`);
    console.log(tomb);
}


var haverok = ['Jóska', 'Pista', 'Ödön'];
new Szemely('Géze').barataimES6(haverok);



