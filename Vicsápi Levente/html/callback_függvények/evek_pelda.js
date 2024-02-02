/*
var evek = [1954, 1990, 1963, 2000, 2010];

function tombMuvelet(tomb, fv){
    var eredmeny = []

    for (var i = 0; i < tomb.length; i++){
        eredmeny.push(fv(tomb[i]))
    }
    return eredmeny
}

function korszamitas(elem){
    return 2024 - elem;
}

function felnott(elem){
    return elem >= 18;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(korok);

var felnottek = tombMuvelet(korok, felnott);
console.log(felnottek);
*/

//Visszaadott függvények

function interjuKerdes(foglalkozas){
    if (foglalkozas == 'tanar'){
        return function(nev){
            console.log(nev + ', meg tudná mondani, hogy milyen tárgyakat tanít?');
        }
    }

    else if (foglalkozas == 'elado'){
        return function(nev){
            console.log(nev + ', hogyan kezel egy vevő reklamációt?');
        }
    }
    else{
        return function(nev){
            console.log('Mi a foglalkozása kedves ' + nev + '?')
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