//objektumok létrehozása

/*var odon = {
    nev: 'Ödön',
    szuletesiEv: 1978,
    foglalkozas: 'grafikus'
};*/
/*var erzsi = {
    nev: 'Erzsi',
    szuletesiEv: 1950,
    foglalkozas: 'nyugdíjas'
};*/

var Szemely = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
    this.korszamitas = function(){
        console.log(2024 - this.szuletesiEv);
    }
}




var odon = new Szemely( "ödön", 1978, 'grafikus');
odon.korszamitas();
console.log(Szemely)
var erzsi = new Szemely( "Erzsi", 1950, 'nyugdijas');
odon.korszamitas();
console.log(Szemely)