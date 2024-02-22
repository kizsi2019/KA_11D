var odon = {
    nev: 'Ödön',
    kor: 45,
    foglalkozás: 'csillagász',
    udvozlet: function (stilus, napszak) { 
        if (stilus === 'hivatalos') {
            console.log('Üdvozlöm, jó ' + napszak + ' kívánok! ' + this.nev + 'vagyok.');
        } else if (stilus === 'baráti') {
            console.log = ('Szia, jó ' + napszak + '!');
        }
    }
}

odont.udvozlet('hivatalos', 'hajnalt');
odon.udvozlet('baráti', 'estét');

var bela = {
    nev = 'Béla',
    kor: 62,
    foglalkozás: 'portás',
};

odon.udvozlet.call(bela, 'barati', 'estet');