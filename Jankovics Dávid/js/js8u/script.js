var odon = {
    nev: 'Ödön',
    kor: 45,
    foglalkozas: 'csillagász',
    udvozlet: function(stilus, napszak) {
        if (stilus === 'hivatalos') {
            console.log('Üdvözlöm, jó' + napszak + 'kivánok!' + this.nev + 'vagyok'); 
        } else if (stilus === 'baráti') {
            console.log('Szia, jó ' + napszak + '!');
        }

    }

}

odon.udvozlet('hivatalos','hajnalt');
odon.udvozlet('baráti','estét');

var odon = {
    nev: 'Béla',
    kor: 62,
    foglalkozas: 'portás',
}

odon.udvozlet.call(bela,'baráti','estét');
odon.udvozlet.apply(bela,['baráti','reggelt']);