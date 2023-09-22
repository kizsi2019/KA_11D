/*var felnott = false

if (felnott) {
console.log('Bela felnott');
}
else
{console.log('Bela gyerek');
}

var belakora = 26;
if (belakora >= 18) {
console.log('Béla felnőtt');
}
else {
console. log('Béla gyerek');
}

belakora >-18 ? console.log('Bela felnőtt') : console.log('Béla gyerek');
var felnottVagyGyerek = belakora >= 18 ? "felnott" : 'gyerek'
console. log(felnottVəgygyerek);*/

var film = 'Gladiátor';
var mufaj;
switch (film) {
    case 'Shrek' : mufaj = 'mese';
        break;
    case 'Terminator': mufaj = "akció";
        break;
    case 'Utazők' : mufaj = 'sci-fi';
        break;
    default :
        mufaj = 'besorolatlan' ;
}
console. log(mufaj);

var kor = 20;
var nev = 'Béla';

switch (true) {
    case kor < 13 :
        console.log(nev +'kisfiű');
        break;
    case kor >= 13 && kor < 20:
        console. log(nev + 'tinédzser');
        break;
    case kor >= 20 && kor < 30:
        console. log(nev + 'fiatalamber');
        break;
    default :
        console.log(nev + 'igazi férfi');
}