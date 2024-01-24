// objektum letrehozás

/*var odon = {
nev: "Ödön",
szuletesiEv: 1978,
foglalkozas: 'grafikus'
};
*/

var Szemely = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;

};
Szemely.prototype.KorSzamitas = function() {
    console.log(2021- this.szuletesiEv)
}

Szemely.prototype.teszt = 'teszt';


var odon = new Szemely('ödön', 1978, 'grafikus');
odon.KorSzamitas();

var erszi = new Szemely('Erzsi', 1950, 'nyugdíjas');
erszi.KorSzamitas();

console.log(Szemely);
console.log(odon)
console.log(odon.teszt)
