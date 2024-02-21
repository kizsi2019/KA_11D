var odon = {
    nev: 'Ödön',
    kor: 45,
    foglalkozas: 'csillagász',
    udvozlet: function(stilus, napszak) {
        if (stilus === 'hivatalos') {
            console.log('üdvözlöm, jó ' + napszak + ' kívánok! ' + this.nev + ' vagyok');
        } else if(stilus === 'baráti') {
            console.log('Szia, jó ' + napszak + "!");
        }
    }
}

odon.udvozlet('hivatalos', 'hajnalt');
odon.udvozlet('baráti', 'estét');

var bela = {
    nev: 'Béla',
    kor: 62,
    foglalkozas: 'portás'
}

odon.udvozlet.call(bela, 'hivatalos', 'estét');

odon.udvozlet.apply(bela, ['hivatalos', 'reggelt']);

var odonBarati = odon.udvozlet.bind(odon, 'baráti');
odonBarati('napot');

var belaHivatalos = odon.udvozlet.bind(bela, 'hivatalos');
var belaHivatalosRegeli = odon.udvozlet.bind(bela, 'hivatalos', 'regelt');

belaHivatalos('estét');
belaHivatalosRegeli();