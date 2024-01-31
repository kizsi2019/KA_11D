//objektum létrehozása

/*
var odon = {
    nev: 'Ödön',
    szuletesnev: 1978,
    foglalkozas: 'grafikus'
};
*/

/*var Szemely = function(nev, szuletesiev, foglalkozas){
    this.nev = nev;
    this.szuletesiev = szuletesiev;
    this.foglalkozas = foglalkozas;
}

Szemely.prototype.korszamitas = function(){
    console.log(2024 - this.szuletesiev);
}

Szemely.prototype.teszt = 'teszt';

var odon = new Szemely('Ödön', 1978, 'grafikus');
odon.korszamitas()

var erzsi = new Szemely('Erzsi', 1950, 'nyugdíjas');
erzsi.korszamitas()

console.log(Szemely);
console.log(odon);
console.log(odon.teszt);*/

// object.create

 var szemelyProto = {
    korszamitas: function() {
        console.log(2024 - this.szuletesiEv)
    }
 };
 var odon = Object.create(szemelyProto);
    odon.nev = 'Ödön';
    odon.szuletesiEv = 1960;
    odon.foglalkozas = 'Pék';

    var Kati = Object.create(szemelyProto,{
    nev: { value: 'Kati'},
    szuletesiEv: { value: 1990 },
    foglalkozas:  { value: 'Pornó Szinész'}
    });