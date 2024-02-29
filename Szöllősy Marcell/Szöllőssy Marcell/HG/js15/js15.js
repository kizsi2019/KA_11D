/*function jatek() {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
}

jatek();
(function() {
    var pont = math.random() * 10;
    console.log(pont >=5);
})();

(function(teszt) {
    var pont = math.random() * 10;
    console.log(pont >= 5);
    console.log(teszt);
})('Hello');*/


/*function nyugdij(ev) {
    var szoveg = "A nyugdíjazásig hátralévő évek száma: "
    return function(szuletesiEv) {
        var datumObjektum = new Data();
        var aktualisEv = datumObjektum.getFullYear();
        var kor = aktualisEv - szuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdíjazasUSA = nyugdij(66);
nyugdíjazasUSA(1959);
nyugdij(66)(1959);*/

/* Closure összefoglaló
Egy belső függvény mindig képes hozzáférni az őt tartalmazó külsö függvény paramétereihez és változóihoz, még azután is, hogy a külső függvény befejzte futását
*/
/*var nyugdíjazasHUN = nyugdíj(65);
var nyugdíjazasIZL = nyugdíj(67);
nyugdíjazasHUN(1959);
nyugdíjazasIZL(1959);*/


/*var szamlalo = 0;

function leptet() {
    szamlalo++;
    console.log(szamlalo);
}
leptet();
leptet();
leptet();*/

/*var szamlalo = 0;

function leptet() {
    var szamlalo = 0;
    szamlalo++;
    console.log(szamlalo);
}
leptet();
leptet();
leptet();*/

/*var szamlalo = 0;

function leptet() {
    var szamlalo = 0;

    return function(){ 
    szamlalo++;
    console.log(szamlalo);
    }
}
var hozzaad = leptet();
hozzaad();
hozzaad();
hozzaad();*/

/*var leptet = (
    function() {
        var szamlalo = 0;

        return function() {
            szamlalo++;
            console.log(szamlalo);
        }
    }
)();

leptet();
leptet();
leptet();
*/

// apply, bind, call

var odon = {
    nev: 'Ödön',
    kor: 45,
    foglalkozas: 'csillagász',
    udvozlet: function(stilus, napszak) {
        if ( stilus === 'hivatalos') {
            console.log('Üdvözlöm, jó' + napszak + ' kivánok! ' + this.nev + ' vagyok ')
        } else if (stilus === 'baráti') {
            console.log('Szia, jó ' + napszak + '!');
        }
    }
}

odon.udvozlet('hivatalos', 'hajnali');
odon.udvozlet('baráti', 'estét');

var bela = {
    nev: 'Béla',
    kor: 62,
    foglalkozas: 'portás' 
}

odon.udvozlet.call(bela, 'baráti', 'estét');

odon.udvozlet.apply(bela, ['baráti', 'reggelt']);

var odonBarati = odon.udvozlet.bind(odon, 'baráti');
odonBarati('napot');
odonBarati('estét');

var belaHivatalos = odon.udvozlet.bind(bela, 'hivatalos');
var belaHivatalosReggeli = odon.udvozlet.bind(bela, 'hivatalos', 'reggelt');

belaHivatalos('estét');
belaHivatalosReggeli();

