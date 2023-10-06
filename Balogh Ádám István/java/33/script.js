/* var keresztnev = "sztavridisz";
console.log(keresztnev)
var vezeteknev = "olgusz";
console.log(vezeteknev)
var kor = 32;
var nagykoru = false;
console.log(nagykoru)
var magassag;
console.log(magassag);
console.log(nemletezo) 

var keresztnev = "csillusz";
var kor  = 32;

console.log(keresztnev + ' ' + kor);

var vezeteknev, felnott;
vezeteknev = "madi"
felnott = true;

console.log(vezeteknev + ' felnőtt? ' + felnott)

kor = 'harmincc'; 

var szam = 10;
var osszeg = szam + 30;
console.log(osszeg);
var kulonbseg = 100 - szam;
console.log(kulonbseg);

console.log(szam * 2);
console.log(szam / 3);

var szam1 = 100;
var szam2 = 100;
var egyenlo = szam1 <= szam2;
console.log(egyenlo);

console.log(typeof szam1);
console.log(typeof 'raketaganjaman');
console.log(typeof egyenlo);

var a;
console.log(typeof a); 

var nev = "szilard";

function teszt() (
    console.log(nev)
)
teszt();  

var fiuk = 23;
var lanyok = 15;

if (fiuk > lanyok)  {
    console.log('A fiúk többen vannak.');
} else {
    console.log('A lányok többen vannak.');
}

var belaKora = 54;
var felnott = true;

if (felnott) {
    console.log('Béla már felnőtt.')

} else {
    console.log('Béla még gyerek.')
}  


var felnott = false;

if (felnott) {
    console.log('Béla felnőtt.');

} else {
    console.log('Béla gyerek.');
}   

var belaKora = 26;

if (belaKora >=18 ) {
    console.log('Béla felnőtt.');

} else {
    console.log('Béla gyerek.');
} 

belaKora >=18 ? console.log('Béla felnőtt') : console.log('Béla gyerek');

var felnottVagygyerek = belaKora >=18 ? 'felnott' : 'gyerek';
console.log(felnottVagygyerek);    */


/* var film = 'Shrek';
var mufaj;

switch (film) {
    case 'Shrek' : mufaj = 'mese';
        break;
    case 'Terminator' : mufaj = 'akcio';
        break;
    case 'Utazók' : mufaj = 'sci-fi';
        break;
    default :
        mufaj  = 'besorolatlan';
}
console.log(mufaj);
 
var kor = 24;
var nev = 'Béla';

switch (true) {
    case kor < 13 :
        console.log(nev + ' kisfiú');
        break;
    case kor >= 13 && kor <= 20 :
        console.log(nev + ' tinédzser');
        break;
    case kor >= 20 && kor < 30:
        console.log(nev + ' fiatalember');
        break;
    default:
        console.log(nev + ' igazi férfi')
}

var kigyok = 100;
var bekak = 78;
var madarak = 198;

var tobbAHullo = kigyok + bekak > madarak;
console.log(tobbAHullo);

var atlag = (kigyok + bekak + madarok) / 3;
console.log(atlag);

var a, b;
console.log(a);
a = b = (10 + 1) * 2 - 2; 
console.log (a,b);

var sutANap = true;
var joIdovan = false;

if (sutANap ) */

/*
var szam;

szam = '';
if (szam){
    console.log("Létezik");
} else {
    console.log("Nem létezik");
}

;

function teglalapKeruletTerulet(a, b, funckio) {
    var eredmeny;
    
    if (funkcio == 'kerület') {
        eredmeny = (a + b) * 2;
    } else if (funkcio == 'terület') {
        eredmeny = a * b ;
    } else {
        return 'Hibás funckió!';
    }
    return funckio + ' = ' + eredmeny;

    }

console.log(teglalapKeruletTerulet(5, 4, 'kerület'));
console.log(teglalapKeruletTerulet(5, 4, 'kerület'));

*/


var nev1 = 'Ond';
var nev2 = 'Kond';
var nev3 = 'Tas';

var nevek = ['Ond', 'Kond', 'Tas'];
var korok = new Array(35, 42, 38);

console.log(korok[1]);
console.log(nevek);
console.log(nev.length);

nevek[1] = 'Huba';
console.log(nevek);

nevek[nevek.length] = 'Álmos';
console.log(nevek);

var huba = ['Huba', 38, 'vezér', true];
console.log(nevek);

huba.push(42);
console.log(huba);

huba.unshift('ifj');
console.log(huba);

huba.pop();
console.log(huba);

huba.shift();
console.log(huba);

console.log(huba.indexOf(48));

var szakacs = huba.indexOf('szakács') == -1 ? 'Huba nem szakács' : 'Huba szakács';
console.log(szakacs);


var huba = {
    nev: 'Huba',
    kor: 38,
    foglalkozas: 'vezér',
    hazas: true,
    baratok: ['Álmos', 'Előd', 'Ond'],
    'csaladi allapot': 'nős'

};

console.log(huba.foglalkozas);
console.log(huba['nev']);

var h = 'hazas';
console.log(huba[h]);

console.log(huba['csaladi allapot']);

huba['kor'] = 40;
huba.foglalkozas = 'ács';

console.log(huba)