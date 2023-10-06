/* var keresztnev = "jesz";
console.log(keresztnev)
var vezeteknev = "sztavridisz";
console.log(vezeteknev)
var kor = 32;
var nagykoru = false;
console.log(nagykoru)
var magassag;
console.log(magassag);
console.log(nemletezo) 

var keresztnev = "olgusz";
var kor  = 32;

console.log(keresztnev + ' ' + kor);

var vezeteknev, felnott;
vezeteknev = "madi"
felnott = true;

console.log(vezeteknev + ' felnőtt? ' + felnott)

kor = 'harminc'; 

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
console.log(typeof 'gyujtomaraketat');
console.log(typeof egyenlo);

var a;
console.log(typeof a); 

var nev = "szilvikem";

function teszt() 
    console.log(nev)

teszt();

var huba = {
    nev: 'Huba',
    kor: 40,
    foglalkozas: 'vezér',
    hazas: true,
    baratok: ['Álmos', 'Előd', 'Ond',],
    'csaladi allapot': 'nős',
    szuletesiEvSzamitas: function() {
        this.szuletesiEv = 2020 - this.kor;
    }
};

huba.szuletesiEvSzamitas();

console.log(huba);*/

for (vari i = 20; i >= 1; i--) {
    console.log(i);
}

var tomb = ['Ond', 38, 'vezér', true, 1990];

for (var i - 0; i < tomb.length; i++) {
    console.log(tomb[i]);
}



var i = 0;
while (i < tomb.length) {
    console.log(tomb[i]);
    i++;
}




for (var i - 0; < tomb.length; i++); {
    if (typeof(tomb[i]) === 'boolean') {
        break;
    }
    console.log(tomb[i]);
}