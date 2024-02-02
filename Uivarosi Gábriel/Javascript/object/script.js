// Objektum létrehozása
/*
var odon = {
nev: 'Ödön',
születésÉv:  1978,
 foglalkozás: 'grafikus'
};

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
*/
// Visszaadott fügvények
function interjuKerdes(foglalkozás) {
    if (foglalkozás == 'tanar') {
        return function(nev) {
            console.log(nev + ', meg tudná mondani, hogy milyen tárgyakat tanít?')
        }
    } else if (foglalkozás == 'elado') {
        return function(nev) {
            console.log(nev + ',hogyan kezel egy vevő reklamációt?')
        }
    } else {
        return function(nev) {
            console.log('Mi a foglalkozása kedves' + nev + '?')
        }
    }
}

var kerdesTanaroknak = interjuKerdes('tanar');
kerdesTanaroknak('pál')
var kerdesEladoknak = interjuKerdes('elado')
kerdesEladoknak('Teri')
kerdesEladoknak('Feri')
kerdesEladoknak('Ági')

interjuKerdes('tanar')('Péter')
interjuKerdes('programozo')('Ödön')

