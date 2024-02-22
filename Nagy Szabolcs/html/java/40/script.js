// apply, bind, call

var odon = {
    nev: 'Ödön',
    kor: 45,
    foglalkozas: 'csillagász',
    udvozlet: function(stilus, napszak) {
        if (stilus === 'hivatalos') {
            console.log('Üdövözlöm, jó ' + napszak + ' kívánok! ' + this.nev + ' vagyok ')
        } else if (stilus === 'baráti') {
            console.log('Szia, jó' + napszak + '!');
        }
    }
}

odon.udvozlet('hivatalos', 'hajnalt');
odon.udvozlet('baráti', 'estét')

var bela = {
    nev: 'Béla',
    kor: 62,
    foglalkozas: 'portás'
}

//call metódus
odon.udvozlet.call(bela, 'baráti', 'estét');

//apply metódus
odon.udvozlet.apply(bela, ['baráti', 'reggelt']);

//bind
var odonBarati = odon.udvozlet.bind(odon, 'baráti');
odonBarati('napot');
odonBarati('estét');


var belaHivatalos = odon.udvozlet.bind(bela, 'hivatalos');
var belahivatalosreggeli = odon.udvozlet.bind(bela, 'hivatalos', 'reggelt')

belaHivatalos('estét');
belahivatalosreggeli();