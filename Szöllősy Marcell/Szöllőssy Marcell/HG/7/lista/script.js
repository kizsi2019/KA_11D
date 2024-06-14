/*
var nev1 = 'Ond';
var nev2 = 'Kond';
var nev3 = "Tas";

var nevek = ['Ond', 'Kond', 'Tas'];

var korok = new Array(35, 42, 18);

console.log(korok[1]);
console.log(nevek);
console.log(nevek.length);

nevek[1] = 'Huba';
console.log(nevek);

nevek[nevek.length] = 'Álmos';
console.log(nevek);

var huba = ['Huba', 38, 'vezér', true];
console.log(huba);

huba.push(42);
console.log(huba);

huba.unshift('ifj');
console.log(huba)

huba.pop();
console.log(huba);

huba.shift();
console.log(huba);

console.log(huba.indexOf(48));

var szakacs = huba.indexOf('szakács') === -1 ? "Huba nem szaki" : "Huba szaki";
console.log(szakacs); 

var huba = {
    nev: 'Huba',
    kor: 38,
    foglalkozas: 'vezér',
    hazas: true,
    baratok: ['Álmos', 'Előd', 'Ond'],
    'csaladi allapot': 'nős'
}

console.log(huba.foglalkozas);
console.log(huba['nev']);

var h = "hazas";
console.log(huba[h]);

console.log(huba['csaladi allapot']);

huba['kor'] = 40;
huba.foglalkozas = "ács";

console.log(huba);

var tas = new Object();

tas.nev = "Tas"
tas.kor = 32;
tas.foglalkozas = "vezér"
console.log(tas)

*/

var tomb = ['Ond', 38, 'vezér', true, 1990];

for (var i = 0; i < tomb.length; i++) {
    console.log(tomb[i]);
}



var i = 0;
while (i < tomb.length) {
    console.log(tomb[i]);
    i++;
}




for (var i = 0; < tomb.length; i++); {
    if (typeof(tomb[i]) === 'boolean') {
        break;
    }
    console.log(tomb[i]);
}