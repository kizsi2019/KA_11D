/*
var odon = {
    nev: 'Ödön',
    szuleteiEv: 1978,
    foglalkozas: 'grafikus'
};
*/
var Szemely = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
};

Szemely.prototype.korSzamitas = function() {
    console.log(2021 - this.szuletesiEv);
};

Szemely.prototype.teszt = 'teszt';

var odon = new Szemely('ödön', 1978, 'grafikus');
odon.korSzamitas();

var erzsi = new Szemely('Erzsi', 1950, 'nyugdíjas');
erzsi.korSzamitas();

console.log(Szemely);
console.log(odon);
console.log(odon.teszt);