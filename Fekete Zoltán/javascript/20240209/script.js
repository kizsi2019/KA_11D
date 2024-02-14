var odon = {
    nev: "Ödön",
    szuletesiEv: 1978,
    foglalkozas: 'grafikus'
};

var Szemely = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
};

Szemely.prototype.korSzamitas = function() {
    console.log(2024 - this.szuletesiEv);
}

Szemely.prototype.test = 'test';

var odon = new Szemely('Ödön', 1978, 'grafikus');
odon.korSzamitas();

var erzsi = new Szemely('Erzsi', 1950, 'nyugdíjas');
erzsi.korSzamitas();

console.log(Szemely);
console.log(odon);
console.log(odon.test);