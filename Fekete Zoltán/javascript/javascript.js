/* var fiuk = 23;
var lanyok = 35;

if (fiuk > lanyok) {
    console.log('A fiúk vannak többen.')
} else {
    console.log('A lányok vannak többen.')
}

var belakora = 54
var felnott = true;

if (felnott) {
    console.log('Béla már felnőtt.')
} else {
    console.log('Béci még gyerek.')
} */

/* var belakora = 26;

if (belakora >= 18) {
    console.log('Béla felnőtt.')
} else {
    console.log('Béla gyerek.')
}

belakora >= 18 ? console.log('Béla felnőtt.') : console.log('Béla gyerek.');

var felnottvagygyerek = belakora >= 18 ? 'felnőtt' : 'gyerek';
console.log(felnottvagygyerek);*/
    
/* var film = 'Terminator';
var mufaj;

switch (film) {
    case 'Shrek' : mufaj = 'mese';
        break;
    case 'Terminator' : mufaj = 'akció';
        break;
    case 'Utazók' : mufaj = 'sci-fi';
        break;
    default :
        mufaj = 'besorolatlan';
}

console.log(mufaj);

var kor = 21;
var nev = 'Béla';

switch (true) {
    case kor < 13 :
        console.log(nev + ' kisfiú.');
        break;
    case kor >= 13 && kor < 20:
        console.log(nev + ' tinédzser.'); 
        break;
    case kor >= 20 && kor < 30:
        console.log(nev + ' fiatalember.');
        break;
    default :
        console.log(nev + ' igazi férfi.');
} */

/*var kigyok = 100;
var bekak = 78;
var madarak = 198;

var tobbahullo = kigyok + bekak > madarak;
console.log(tobbahullo);

var atlag = (kigyok + bekak + madarak) / 3;

console.log(atlag)

var a, b;
console.log(a);
a = b = (10 + 1) * 2 - 2; // 11 * 2 - 2, 22-2
// a = b = 20;

console.log(a, b);*/

var sutanap = false;
var joidovan = false;

if (sutanap || joidovan) {
    console.log('Jó kedvem van.')
} else {
    console.log('Rossz kedvem van.')
}