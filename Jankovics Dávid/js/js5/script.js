//visszaadott függvények
function interjuKerdes(foglalkozas) {
    if (foglalkozas == 'tanár') {
        return function (nev) {
            console.log(nev + ', meg tudná mondani, hogy milyen tárgyakat tanít?')
        }
    } else if (foglalkozas == 'elado') {
        return function (nev) {
            console.log(nev + ', hogyan kezel egy vevő reklamációt?')
        }
    } else {
        return function (nev) {
            console.log('mi a foglalkozása kedves ' + nev + '?')
        }
    }


}
var kerdesTanaroknak = interjuKerdes('tanar');
kerdesTanaroknak('Pál');

var kerdesEladoknak = interjuKerdes('elado');
kerdesEladoknak('Tomi');
kerdesEladoknak('Teri');
kerdesEladoknak('Feri');
kerdesEladoknak('Ági');

interjuKerdes('tanar')('Péter');
interjuKerdes('programozó')('Ödön');
