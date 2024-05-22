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
/*
var dobozES5 = {
    szin: 'zöld',
    pozicio: 1,
    KattinsRám: function() {
        var objektum = this;
        console.log(this.szin);
       
        document.querySelector('.green').addEventListener('click', function() {
         
            var szoveg = 'Én vagyok a(z) ' + objektum.pozicio + '. doboz és a színem ' + objektum.szin + '.';
            alert(szoveg);
        })
    }
};


dobozES5.KattinsRám();
*/

//es6
/*
const dobozES6 = {
    szin: 'zöld',
    pozicio: 1,
    KattinsRám: function() {
   
        console.log(this.szin);
       
        document.querySelector('.green').addEventListener('click', () => {
         
            var szoveg = 'Én vagyok a(z) ' + this.pozicio + '. doboz és a színem ' + this.szin + '.';
            alert(szoveg);
        })
    }
};

dobozES6.KattinsRám();
*/
/*
function Szemely(nev) {
    this.nev = nev;

}

Szemely.prototype.barataimES5 = function(haverok) {
    //
    var obj = this;
    var tomb = haverok.map(function(elem) {
        return obj.nev + ' barátja ' + elem + '.';

    });
    console.log(tomb);
}

var haverok = ['Jóska', 'Pista', 'Ödön'];
new Szemely('Géza').barataimES5(haverok);


*/
/*
//es6
function Szemely(nev) {
    this.nev = nev;
}

Szemely.prototype.barataimES6 = function(haverok) {
    const tomb = haverok.map(elem => ` ${this.nev} barátja ${elem}`);
    console.log(tomb); 
}
var haverok = ['Jóska', 'Pista', 'Ödön'];
new Szemely('Géza').barataimES6(haverok);
*/
/*
var odon = ['Ödön', 50]
var név = odon[0]
var kor = odon[1]

console.log(név)
console.log(kor)
*/
//es6
/*
const [nev2, kor2] = ['Ödön', 50]

console.log(nev2)
console.log(kor2)
*/
/*
const obj = {
keresztNev: 'Ödön',
vezetekNev: 'Bödön'
};

const { keresztNev, vezetekNev } = obj;

console.log(keresztNev)
console.log(vezetekNev)

const { keresztNev: x, vezetekNev: y } = obj;

console.log(x)
console.log(y);

function korEsNyugdij(szuletesiEv) {
    let nyugdijKorhatar = 65;
    const kor = new Date().getFullYear() - szuletesiEv;

    return [kor, nyugdijKorhatar - kor]
}

const [kor3, nyugdij] = korEsNyugdij(2005);

console.log(kor3)
console.log(nyugdij)*/
/*
const dobozok = document.querySelectorAll('.rectangle');

var dobozokTombES5 = Array.prototype.slice.call(dobozok)
*/
/*
dobozokTombES5.forEach(function(aktualis) {
    aktualis.style.backgroundColor = 'orange';
});

const dobozokTombES6 = Array.from(dobozok);
dobozokTombES6.forEach(aktualis => aktualis.style.backgroundColor = 'blue')
    */
//es5
/*
for (var i = 0; i < dobozokTombES5.lenght;) {
    if (dobozokTombES5[i].className === 'rectangle blue') {
        continue;
    }
    dobozokTombES5[i].textContent = 'Kék lettem';
}
*/
//es6
// it works
/*
for (const aktualis of dobozokTombES6) {
    if (aktualis.className === 'rectangle blue' ) {
        continue;
    }
    aktualis.textContent = 'Kék lettem'
}

*//*
for (const aktualis of dobozokTombES6) {
    if (aktualis.className.includes('blue') ) {
        continue;
    }
    aktualis.textContent = 'Kék lettem'
}
*/

//var korok = [2, 10, 20, 17, 14]
/*
console.log(korok);
var felnottek = korok.map(function(aktualis) {
    return aktualis >= 18;
})

//console.log(felnottek);
*/
/*
console.log(felnottek.indexOf(true));

console.log(koroko.findIndex(aktualis => aktualis >= 18));
console.log(korok.find(aktualis => aktualis >= 18));
*/
/*
function szamok(a, b, c, d) {
    return a + b + c + d;
}

var osszeg = szamok(1, 2, 3, 4)
console.log (osszeg);

var szamokTomb = [1, 2, 3, 4,];
var osszeg2 = szamok.apply(null, szamokTomb);

console.log(osszeg2)
// es6
const osszeg3 = szamok(...szamokTomb)
console.log(osszeg3)

const t2 = [5, 6, 7, 8, 9, 10];

const t3 = [...szamokTomb, ...t2];
console.log(t3)

const cimsor = document.querySelector('h1')

const htmlElemek = [cimsor, ...dobozok];

Array.from(htmlElemek).forEach(aktualisElem => aktualisElem.style.color = 'purple')
*/
////////////////////////////////////////
/*
function parosVagyParatlanES5() {
    console.log(arguments)
    var argumentomokTomb = Array.prototype.slice.call(arguments);

    argumentomokTomb.forEach(function(aktualisElem) {
        if (aktualisElem % 2 === 0) {
            console.log('Paros')

        } else {
            console.log('Paratlan')
        }
    });
}

parosVagyParatlanES5(1, 2, 4, 3, 7, 10)
*//*
function parosVagyParatlanES6(...szamok) {

    szamok.forEach(aktualisElem => {
            if (aktualisElem % 2 === 0) {
                console.log('Paros');

            } else {
                console.log('Paratlan');
            }
    })
}

parosVagyParatlanES6(1, 2, 4, 3, 7, 10)
*/
/*9
function parosVagyParatlanES5(Teszt) {
    var argumentomokTomb = Array.prototype.slice.call(arguments, 1);


    argumentomokTomb.forEach(function(aktualisElem) {
        if (aktualisElem % 2 === 0) {
            console.log('Paros') 

        } else {
            console.log('Paratlan');
         }
    })
}
parosVagyParatlanES5('tesztttttttt', 1, 2, 3, 4, 5, 69)
*/ 
/*
function parosVagyParatlanES6(teszt, ...szamok) {

    szamok.forEach(aktualisElem => {
            if (aktualisElem % 2 === 0) {
                console.log('Paros');

            } else {
                console.log('Paratlan');
            }
    })
}

parosVagyParatlanES6('Sex',1, 2, 4, 3, 7, 10);
*/
/*
function AdamsFamily(keresztNev, szuletesiEv, csaladiNev) {
    csaladiNev === undefined ? csaladiNev = 'Adams' : csaladiNev = csaladiNev;
    this.keresztNev = keresztNev;
    this.szuletesiEv = szuletesiEv;
    this.csaladiNev = csaladiNev;
}
var fester = new AdamsFamily('Fester', 1940)
var mortisha = new AdamsFamily('Mortisha', 1965)
var kuzin = new AdamsFamily('Kuzin', 1800, 'Hogyishívják')
// es6
function AdamsFamily(keresztNev, szuletesiEv, csaladiNev = 'Adams') {

    this.keresztNev = keresztNev;
    this.szuletesiEv = szuletesiEv;
    this.csaladiNev = csaladiNev;
}
var fester = new AdamsFamily('Fester', 1940)
var mortisha = new AdamsFamily('Mortisha', 1965)
var kuzin = new AdamsFamily('Kuzin', 1800, 'Hogyishívják')
*/

/////////////////////////////////////////////////////////////////////////////////////////////////////
// Mao
/*
const kerdes = new Map();
kerdes.set('kerdes', 'Hogy hívják a de miééért reklában szereplő kisfiút?')
kerdes.set(1, 'ödön')
kerdes.set(2, 'Ábel')
kerdes.set(3, 'Nem Hívják hanem üldözik')
kerdes.set(4, 'Vár nándor')

kerdes.set('helyes', 2)
kerdes.set(true, 'Helyes válasz')
kerdes.set(false, 'Nem Talált')

console.log(kerdes.get('kerdes'));
console.log(kerdes.size)

//kerdes.delete(4);

if( kerdes.has(3)) {
    kerdes.delete(3);
}
//kerdes.clear();

kerdes.forEach(
    (kulcs, ertek) => console.log(`Kulcs: ${kulcs}, ertek: ${ertek}`));

    for (let [kulcs, ertek] of kerdes.entries()) {
        if (typeof(kulcs) === 'number') {
            console.log(`Kulcs: ${kulcs}, ertek: ${ertek}`)
        }
    }

const valasz = parseInt(prompt('Add meg a helyes választ'))
valasz = kerdes.get('helyes')
*/

//Es5
/*
var SzemelyES5 = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev
    this.szuletesiEv = szuletesiEv
    this.foglalkozas = foglalkozas

}

SzemelyES5.prototype.korszamitas = function() {
    var kor = new Date().getFullYear - this.szuletesiEv
    console.log(kor)
}
var odon = new SzemelyES5('Ödön', 1810, 'Kísértet')
*/
//Es6
/*
class SzemelyES6 {
constructor(nev, szuletesiEv, foglalkozas) {
    this.nev = nev
    this.szuletesiEv = szuletesiEv
    this.foglalkozas = foglalkozas

}
korszamitas() {
    let kor = new Date().getFullYear - this.szuletesiEv
    console.log(kor)
}
static udvozlet() {
    console.log('Nem Vagy üdvözölve')
}
}

const nandi = new SzemelyES6('Nándi, 1960')

SzemelyES6.udvozlet();
*/
/*
var SzemelyES5 = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev
    this.szuletesiEv = szuletesiEv
    this.foglalkozas = foglalkozas
}
SzemelyES5.prototype.korszamitas = function() {
    var kor = new Date().getFullYear - this.szuletesiEv
    console.log(kor)
}

var KatonaES5 = function(nev, szuletesiEv, foglalkozas, rendfokozat, osztag ) {
    SzemelyES5.call(this, nev, szuletesiEv, foglalkozas)
    this.rendfokozat = rendfokozat;
    this.osztag = osztag;
}

KatonaES5.prototype.rangszerzes = function(rang) {
    this.rendfokozat = rang;
    console.log(this.rendfokozat);
}

var odonKatona = new KatonaES5('Ödön', 1970, 'Pék', 'közlegény', 'Öngyilkos alakulat');
odonKatona.rangszerzes('szazados');
//odonKatona.korszamitas();
*//*
class SzemelyES6 {
    constructor(nev, szuletesiEv, foglalkozas) {
        this.nev = nev
        this.szuletesiEv = szuletesiEv
        this.foglalkozas = foglalkozas
    
    }
    korszamitas() {
        let kor = new Date().getFullYear - this.szuletesiEv
        console.log(kor)
    }
}

class KatonaES6 extends SzemelyES6 {
    constructor(nev, szuletesiEv, foglalkozas, rendfokozat, osztag) {
        super(nev, szuletesiEv, foglalkozas)
        this.rendfokozat = rendfokozat;
        this.osztag = osztag;

    }
    rangszerzes(rang) {
        this.rendfokozat = rang
        console.log(this.rendfokozat);
    }
}

const NándiKatona = new KatonaES6('Nándi', 1960, 'Katona', 'Tiszt', 'Öngyilkos alakulat')
NándiKatona.rangszerzes('szazados')
NándiKatona.korszamitas();
*/
/*
const masodik = () => {
    console.log('masodik')
    elso();
}
const elso = () => {
    console.log('elso')
    masodik();
    console.log('harmadik')
}
elso();
*/
/*
const masodik = () => {
    setTimeout(() => {
        console.log('Asszikorn második')
    }, 6000)
};

const elso = () => {
    console.log('elso')
    masodik();
    console.log('harmadik')
};

elso();
*/

function receptLekerdez() {
    setTimeout (() => {
        const receptID = [676, 102, 34, 1489, 321]
        console.log(receptID)

        setTimeout((id) => {
            const recept = {
                cím: 'Gulyás leves',
                kategoria: 'Levesek'
            }
            console.log(`${id}: ${recept.cím}`);

            setTimeout(kategoria => {
                const levesek = [
                    { cim: 'Nyirségi gombócleves', kategoria: 'Levesek'},
                    { cim: 'Borsóleves', kategoria: 'Levesek'}
                ];
                console.log(levesek);

            }, 2000, recept.kategoria);
        }, 2000, receptID[1])
    }, 3000)
}

receptLekerdez();