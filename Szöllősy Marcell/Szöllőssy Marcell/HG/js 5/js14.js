/*

var felnott = false;
if (felnott) {
    console.log('Béla felnőtt');
} else {
    console.log('Béla gyerek');
}

var  belakora = 26;

if (belkora >= 18) {
    console.log('Béla felnőtt');
} else {
    console.log('Béla gyerek');
}

belakora >=18 ? console.log('Béla felnött') : console.log('Béla gyerek');

var felnottVagyGyerek = belaKora >= 18 ? 'felnőtt' : 'gyerek' ;
console.log(felnottVagyGyerek);*/

var film = 'Gladiátor';
var mufaj;

switch(film) {
    case 'Shrek' : mufaj = 'mese';
        break;
    case 'Terminátor' : mufaj = 'akció';
        break;
    case 'Utazók' : mufaj = 'ski-fi';
        break;
    default :
        mufaj = 'besorolatlan';
}

console.log(mufaj);

var kor = 20;
var nev = 'Béla';

switch(true) {
    case kor < 13 :
        console.log(nev + 'kisfiú');
        break
    case kor < 13 && kor <= 20:
       console.log(nev + 'tinédzser');
        break
    case kor < 20 && kor <= 30:
        console.log(nev + 'fiatalember');
        break
    default:
        console.log(nev + 'igazi férfi');
}