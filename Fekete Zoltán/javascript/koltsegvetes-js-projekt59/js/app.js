// let és const
// es5

/*var nev5 = 'Teszt Elek';
var kor5 = 40;

nev5 = 'Kiss Pista';

console.log(nev5);

function nyelvVizsga5(siker) {
    if (siker) {
        var keresztnev = 'Ödön';
        var szuletesiEv = 1980;
        console.log(keresztnev + '(születési ev: ' + szuletesiEv + ') sikeres volt a vizsga');
    }
}

nyelvVizsga5(true);*/

// es6
/*const nev6 = 'Teszt Elek';
let kor6 = 40;

//nev6 = 'Kiss Pista'; // hibát dob

function nyelvVizsga6(siker) {
    if (siker) {
        let keresztNev = 'Ödön';
        const szuletesiEv = 1980;
        console.log(keresztNev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga');
    }
}

nyelvVizsga6(true);*/

/*let i = 9;
for (let i = 0; i < 5; i++) {
    console.log(i);
}*/

var i = 9;
for (var i = 0; i < 5; i++) {
    console.log(i);
}

console.log(i);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Blokkok és IIFE
// es6
/*{
    const a = 1;
    let b = 2;
    var c = 5;
}


// es5
(function(){
    let c = 3;
    console.log(c);
})();

console.log(c);*/

//////////////////////////////////////////////////////////////////////////////////////
// Sztringek ES6-ban

let vezetekNev = 'Teszt';
let keresztNev = 'Elek';

const szuletesiEv = 1970;

function korSzamitas(ev) {
    return 2024 - ev;
}

//es5
console.log(vezetekNev + ' ' + keresztNev + ', született ' + szuletesiEv + '-ben. Most ' + korSzamitas(szuletesiEv) + ' éves');

//es6
console.log(`${vezetekNev} ${keresztNev}, született ${szuletesiEv}-ben. Most ${korSzamitas(szuletesiEv)} éves.`)

const nev = `${vezetekNev} ${keresztNev}`;

console.log(nev.startsWith('T'));

console.log(nev.endsWith('ek'));

console.log(nev.includes('ele'));

console.log(vezetekNev.repeat(3));

console.log(`${vezetekNev}`.repeat(3));