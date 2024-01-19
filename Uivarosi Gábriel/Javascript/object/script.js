// Objektum létrehozása
/*
var odon = {
nev: 'Ödön',
születésÉv:  1978,
 foglalkozás: 'grafikus'
};
*/
var Szemely = function(nev, születésÉv, foglalkozás) {
this.nev = nev
this.születésÉv = születésÉv
this.foglalkozás = foglalkozás

};
Szemely.prototype.Korszamitas = function() {
    console.log(2024 - this.születésÉv)
}
Szemely.prototype.teszt = 'teszt';

var odon = new Szemely('ödön', 1978, 'grafikus');
odon.Korszamitas();

var  erzsi = new Szemely('Erzsi', 1950, 'nyugdíjas')
erzsi.Korszamitas();

console.log(Szemely);
console.log(odon);
console.log(odon.teszt)
s