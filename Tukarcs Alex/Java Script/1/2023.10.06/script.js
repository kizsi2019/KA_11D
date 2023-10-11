// var huba = {
//    nev: 'Huba',
//    kor: 30,
//    foglalkozas: 'Király',
//    hazas: true,
//    baratok: ['Alex','Alex','Alex','Csak Alex']
// };

// console.log(huba.foglalkozas);
// console.log(huba['név']);

//var h = 'hazas';
// console.log(huba[h]);

// console.log(huba['családi állapot']);

// huba['kor'] = 69;
// huba.foglalkozas = 'krács';

// console.log(huba);

// var tas = new Object();

// tas.nev = 'Tas';
// tas.kor = 13;
// tas["foglalkozás"] = 'csassszar';
// console.log(tas);




//var huba = {
//    nev: 'Huba',
//    kor: 30,
//    foglalkozas: 'Király',
//    hazas: true,
//    baratok: ['Alex','Alex','Alex','Csak Alex'],
//    szuletesievszamitas: function() {
//        this.szuletesiev = 2023 - this.kor;
//    }
// };

//huba.szuletesievszamitas();
//console.log(huba);

/*
for (var i = 20 ; i >= 1; i--) {
    console.log(i);
}

var tomb = ['Ond', 38, 'Vezér', true, 1990];

for (var i = 0 ; i < tomb.length; i++) {
    console.log(tomb[i]);
}

var i = 0;
while (i < tomb.length) {
    console.log(tomb[i]);
    i++
}

for (var i = 0; i < tomb.length; i++) {
    if (typeof(tomb[i]) == 'boolean') {
        break;
    }
    console.log(tomb[i]);
}
*/

var szemely = 'Misi';

function egy() {
    var udv1 = 'Szia ';
    ketto();
    var eredmeny1 = udv1 + szemely;
    console.log(eredmeny1);
}

function ketto() {
    var udv2 = 'Szervusz ';
    harom();
    var eredmeny2 = udv2 + szemely;
    console.log(eredmeny2);
}

function harom() {
    var udv3 = 'Helló ';
    var eredmeny3 = udv3 + szemely;
    console.log(eredmeny3);
}

egy();