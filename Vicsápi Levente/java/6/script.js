/*var keresztnev = 'Levente';
var vezeteknev = 'Vicsápi';

var kor = 32;

var nagykoru = false;

console.log(nagykoru);
console.log(vezeteknev);
console.log(keresztnev);

var magassag;

console.log(magassag);
console.log(nemletezo);
*/

//fkngkfgjnfkjgfjgjfign//

/*var keresztnev = 'Sajt';
var kor = 32;
kor = 'harminckettő';

var vezeteknev = 'Kovács';
//var felnott = true;//

console.log(keresztnev + ' ' + kor)

console.log(vezeteknev + ' felnőtt? ' + felnott);*/

//matematikai oparátorok

var szam = 10;
var osszeg = szam + 33;

//logikai operátorok
/*var szam1 = 100;
var szam2 = 100;
var paros_e = szam1 % 2 == 0;

var egyenlo = szam1 <= szam2;


//typeof
console.log(typeof szam1);
console.log(typeof 'nguhgjnjgutg');
console.log(typeof egyenlo);

var a;
console.log(typeof a);
console.log(typeof paros_e);*/

/*function teszt(){
    var x = 10
    console.log('cigány');
}

teszt();

{
    let y = 21;
}

console.log(y);*/

/*var x = 10;
console.log(x);

{
    let x = 2;
    console.log(x);
}

console.log(x);*/

/*let i = 2;

for(let i = 0; i < 8; i++){
    console.log(i);
}
*/

/*var x = 1;

let y = 2;*/

/*let x = 0;


{
    let x = 1;
}*/

/*nev = 'pisti';

console.log(nev);

let nev;*/

/*const SZIN = 100
SZIN = '#ffffffff'*/

/*const SZIN;

SZIN = 'white';*/

/*const nev = {
    kereszt: 'Pistike',
    vezetek: 'nagy',
}

nev.kereszt = 'Jóska';
nev.kor = 32;*/

/*
var fiuk = 23;
var lanyok = 35;

if (fiuk > lanyok){
    console.log("A fiúk vannak többen")
}

else{
    console.log("A lányok vannak többen");
}
*/

/*
var keresztnev = 'Levente';
var kor = 32;

var vezeteknev, felnott;
vezeteknev = 'Vicsápi';

felnott = true;

console.log(vezeteknev + " felnőtt? " + felnott);
*/

/*
felnott = false;

if (felnott){
    console.log("Béla felnőtt");
}

else{
    console.log("Béla gyerek");
}

var Belakora = 26;

if (Belakora >= 18){
    console.log("Béla felnőtt");
}


Belakora >= 18 ? console.log("Béla felnőtt") : console.log("Béla gyerek");

var felnottvagygyerek = Belakora >= 18 ? 'felnőtt' : 'gyerek';
console.log(felnottvagygyerek);
*/

/*
var film = 'Utazók';
var mufaj;

switch (film){
    case 'Shrek' : mufaj = 'mese'
        break;
    case 'Terminátor' : mufaj = 'akció'
        break;
    case 'Utazók' : mufaj = 'sci-fi'
        break;
    default:
        mufaj = 'besorolatlan'
}

console.log(mufaj);
*/

/*
var kor = 31;
var nev = 'Béla';

switch (true){
    case kor < 13:
        console.log(nev + " kisfiú");
        break;
    case kor >= 13 && kor < 20:
        console.log(nev + " tinédzser");
        break;
    case kor >= 20 && kor < 30:
        console.log(nev + " fiatalember");
        break;
    default:
        console.log(nev + " igazi férfi");
}
*/

/*
var kigyok = 100;
var bekak = 78;
var madarak = 198;

var tobbhullo = kigyok + bekak > madarak;
console.log(tobbhullo);

var atlag = (kigyok + bekak + madarak) / 3
console.log(atlag);

var a, b;
console.log(a);

a = b = (10 + 1) * 2 - 2;

console.log(a, b);
*/

/*
var sutanap = true;
var joidovan = true;

if (sutanap || joidovan){
    console.log("Jó kedvem van");
}

else{
    console.log("Rossz kedvem van");
}
*/

szam = 0;

/*
if (szam){
    console.log("létezik");
}

else{
    console.log("nem létezik");
}
*/

/*
if (szam || szam === 0){
    console.log("létezik");
}

else{
    console.log("nem létezik");
}
*/

/*
if (szam === '10'){
    console.log("egyezik");
}

else{
    console.log("nem egyezik");
}
*/

/*
function hello(nev){
    return "Hello " + nev + "!"
}

console.log(hello("Géza"));
*/

/*
function TerületKerület(a, b, funkcio){
    var eredmeny;

    if (funkcio == 'kerület'){
        eredmeny = (a + b) * 2;
    }

    else if (funkcio == 'terület'){
        eredmeny = a * b;
    }

    else{
        return "Hibás funkció!"
    }

    return funkcio + ' = ' + eredmeny
}

console.log(TerületKerület(5, 4, 'kerület'))
console.log(TerületKerület(5, 4, 'terület'))
console.log(TerületKerület(5, 4, 'jfnjfdjf'))
*/

/*
var eletszakaszok = function (nev, kor){
    switch (true){
        case kor < 13:
            return nev + " gyerek";
            break;

        case kor >= 13 && kor <= 20:
            return nev + " fiú";
            break;

        case kor > 30 && kor <= 50:
            return 
    }
}
*/

/*
var nevek = ["Ond", "Kond", "Tas"];
var korok = new Array(35, 42, 38);

console.log(korok[1]);
console.log(nevek);
console.log(nevek.length);

nevek[1] = "Huba";
console.log(nevek);

nevek[nevek.length] = "Álmos";
console.log(nevek);

var huba = ["Huba", 38, "vezér", true]
console.log(huba);

huba.push(42);
console.log(huba);

huba.unshift("ifj");
console.log(huba);

huba.pop();
console.log(huba);

huba.shift();


var szakacs = huba.indexOf("szakács") === -1 ? "Huba nem szakács" : "Huba szakács"
console.log(szakacs);

var h = {
    nev: "Huba",
    kor: 38,
    foglalkozas: "vezér",
    hazas: true,
    baratok: ["Álmos", "Előd", "Ond"],
    'családi állapot': "nős"
}

console.log(huba.foglalkozas);
console.log(huba["nev"]);

var h = "hazas";
console.log(huba[h])

console.log(huba["családi_állapot"]);

huba["kor"] = 40;
huba.foglalkozas = "ács";

console.log(huba);

var tas = new Object();

tas.nev = "tas";
tas.kor = "32";
tas["foglalkozás"] = "vezér";
console.log(tas);
*/

var huba = {
    nev: "huba",
    kor: 38,
    foglalkozas: "vezér",
    hazas: true,
    baratok: ["Álmos", "Előd", "Ond"],
    'családi állpot': 'nős',
    sziletesiev: function(){
        this.sziletesiev = 2020 - this.kor
    }
}