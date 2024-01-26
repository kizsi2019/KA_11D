var szemelyProto = {
korszamitas: function() {
    console.log(2024 - this.szuletesiEv);
}
}

var odon = Object.create(szemelyProto);

odon.nev = 'Ödön';
odon.szuletesiEv = 1960;
odon.foglalkozas = 'pék';

var kati = Object.create(szemelyProto, {
    nev: { value: 'Kati' },
    szuletesiEv: { value: 1990 },
    foglalkozas: { value: 'kozmetikus' }
});