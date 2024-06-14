/*
var Szemely = function(nev, szuletesiev, foglalkozas) {
    this.new = nev;
    this.szuletesiev = szuletesiev;
    this.foglalkozas = foglalkozas;
}

Szemely.prototype.korszamitas = function() {
    console.log(2024 - this.szuletesiev);
}

Szemely.prototype.teszt = 'teszt';

var odon = new Szemely('ödön', 1978, 'grafikus');
odon.korszamitas();

var erzsi = new Szemely('Erzsi', 1950, 'nyugdíjás');
erzsi.korszamitas();

console.log(Szemely);
console.log(odon);
console.log(odon.teszt);
*/

var szemelyProto = 
{ 
    Korszamitas: function() 
    {
        console.log(2024- this.szuletesiEv);
    }
};

var odon = Object.create(szemelyProto);
odon.nev = "Ödön";
odon.szuletesiEv = '1960';
odon.foglalkozas = "pék";

var kati = Object.create(szemelyProto, {
    nev: { value: "Kati"},
    szuletesiEv: { value: 1990},
    foglalkozas: {value: 'kozmetikus'}
});