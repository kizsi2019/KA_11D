// Destruktálás

//es5

var odon = ['Ödön', 50]
var nev = odon[0];
var kor = odon[1];

console.log(nev);
console.log(kor);

//es6
const [nev2, kor2] = ['Ödön', 50];

console.log(nev);
console.log(kor);

const obj = {
    keresztNev: 'Ödön',
    vezetekNev: 'Bödön'
};

const { keresztNev, vezetekNev } = obj;

console.log(keresztNev);
console.log(vezetekNev);

const { keresztNev: x, vezetekNev: y } = obj;

console.log(x);
console.log(y);

function korEsNyugdij(szuletesiev) {
    let nyugdijKorhatar = 65;
    const kor = new Date().getFullYear() - szuletesiev;

    return [kor, nyugdijKorhatar - kor];
}

const [kor3, nyugdij] = korEsNyugdij(1978);

console.log(kor3);
console.log(nyugdij);