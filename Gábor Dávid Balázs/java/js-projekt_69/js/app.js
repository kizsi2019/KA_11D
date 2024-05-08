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

var i = 9;
for (var i = 0; i < 5; i++) {
    console.log(i);
}

console.log(i);