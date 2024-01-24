

/*
var odon = {
    nev: 'Ödön',
    SzületesiEv: '1978'
    Foglalkozas: 'grafikus'
};
*/
var Szemely = function(nev, SzületesiEv, Foglalkozas) {
    this.nev = nev;
    this.SzületesiEv = SzületesiEv;
    this.Foglalkozas = Foglalkozas;
};

Szemely.prototype.korSzamitas = function() {
    console.log(2021 - this.SzületesiEv);
};

Szemely.prototype.teszt = 'teszt';

var odon = new Szemely('Ödön', 1978, 'grafikus');
odon.korSzamitas();

var erzsi = new Szemely('Erzsi', 1950, 'nyugdíjas');
erzsi.korSzamitas();

console.log=(Szemely);
console.log(odon);
console.log(odon.teszt)