// objektum létrehozása

/*
var odon = {
    nev: 'Ödön',
    szuletesiEv: 1978,
    foglalkozas: 'grafikus'
};

var Szemely = function(nev, szuletesiEv, foglalkozas) {
    this .nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas
};

Szemely.prototype.korszamitas = function() {
    console.log(2021 - this.szuletesiEv);
};

Szemely.prototype.teszt = 'teszt';

var odon = new Szemely('ödön', 1978, 'grafikus');
odon.korszamitas();

var erzsi = new Szemely('Erzsi', 1950, 'nyugdíjas');
erzsi.korszamitas();

console.log(Szemely);
console.log(odon);
console.log(odon.teszt);



// Object.create

var SzemelyProto = {
    korszamitas: function() {
        console.log; 2024 - this.szuletesiEv();
    }
};

var odon = Object.create(SzemelyProto);

odon.nev = 'Ödön';
odon.szuletesiEv = 1960;
odon.foglalkozas = 'pék';

var kati = Object.create(SzemelyProto, {
    nev: {value: 'Kati'},
    szuletesiEv: {value:1990},
    foglalkozas: {value: 'kozmetikus'}
}); */



//Egyszerű adattípusok és objektumok

var x = 10;
var y = x;
x = 100;
console.log(x)
console.log(y)

var o1 = {
    sz: 100,
    m: 200
};

var o2 = o1;
o1.sz = 158;
console.log(o1.sz);
console.log(o2.sz);

var a = 10;
var o = {
    nev: 'Ödön',
    kor: 35
};

function mondosit(a, b) {
    a = 40;
    b.nev = 'Lajos'
};

mondosit(a, o);

console.log(a);
console.log(o.nev);

