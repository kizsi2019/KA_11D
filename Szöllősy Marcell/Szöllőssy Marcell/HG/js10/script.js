/*var odon = {
    nev: 'Ödön',
    szuletésiEv: 1978,
    foglalkozás: 'grafikus'
};
*/

var Szemely = function(nev, szuletésiEv, foglalkozás) {
    this.nev = nev;
    this.szuletésiEv = szuletésiEv;
    this.foglalkozás = foglalkozás;
};
 Szemely.prototype.korSzamitas = function() {
    console.log(2021 - this.szuletésiEv);
 };

 Szemely.prototype.teszt = 'teszt';

 var odon = new Szemely('Ödön', 1978, 'grafikus');
odon.korSzamitas();

var Erzsi = new Szemely('Erzsi', 1950, 'nyugdíjas');
Erzsi.korSzamitas();

console.log(Szemely);
console.log(odon);
console.log(odon.teszt);
