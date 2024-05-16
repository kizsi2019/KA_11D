// let és const

var nev5 = 'Teszt Elek';
var kor5 = 40;

nev5 = 'Kiss Pista';

// console.log(nev5);

// es5
function nyelvVizsga5(siker){
    if (siker){
        var keresztNev = 'Ödön';
        var szuletesiEv = 1980;
        console.log(keresztNev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga')
    }
}

// nyelvVizsga5(true);

// es6

const nev6 = 'Teszt Elek';
let kor6 = 40;

// nev6 = 'Kiss Pista';

// console.log(nev6);

function nyelvVizsga6(siker){
    if (siker){
        let keresztNev = 'Ödön';
        const szuletesiEv = 1980;
        console.log(keresztNev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga')
    }
}

// nyelvVizsga6(true);

/*
let i = 9;
for (let i = 0; i < 5; i++){
    console.log(i);
}
*/
// console.log(i);

/*
var i = 9;
for (var i = 0; i < 5; i++){
    console.log(i);
}
*/

// console.log(i);

///////////////////////////////////////////////////////////////////////////////////////
// Blokkok
// es6

{
    const a = 1;
    let b = 2;
    var c = 5;
}

// console.log(a + b);

// es5

/*
(function(){
    let c = 3;
    console.log(c);
})();

console.log(c);
*/

/////////////////////////////////////////////
// Sztringek ES6-ban

/*
let vezetekNev = 'Teszt';
let keresztNev = 'Elek';

const szuletesiEV = 1970;

function korSzamitas(ev){
    return 2024 - ev;
}

//es5

console.log(vezetekNev + ' ' + keresztNev + ', született ' + szuletesiEV + '-ben. Most ' + korSzamitas(szuletesiEV) + ' éves.');

//es6

console.log(`${vezetekNev} ${keresztNev}, született ${szuletesiEV}-ben. Most ${korSzamitas(szuletesiEV)} éves.`)

const nev = `${vezetekNev} ${keresztNev}`;

console.log(nev.startsWith('T'));
console.log(nev.endsWith('k'));

console.log(vezetekNev.repeat(3));
console.log(`${vezetekNev} `.repeat(3));
*/

