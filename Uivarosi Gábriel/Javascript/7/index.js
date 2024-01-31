// False; Und, null. 0, ", NAN"
/* var szam;

szam = ""


if (szam) {
    console.log("Létezik")
} else (
    console.log("NOPE")
)

var szam;

if (szam || szam === 0) {
    console.log("Létezik")

} else {
    console.log("Nemm létezik")
}

var szam;
szam = "10"

if (szam == 10) {
    console.log("Egyezik")

} else {
    console.log("FFF")
}


function hellicopter(nev) {
    console.log("Hello " + nev +"!")

}
hellicopter("KÁLMÁN")



function hellicopter(nev) {
    return("Hello " + nev +"!")

}
console.log(hellicopter("BOTI"))


function keruletTerulet(a, b , Func) {
    var eredmeny 
    if (Func === "Kerület") {
        eredmeny = (a + b) * 2

    } else if (Func ==="Terület") {
        eredmeny = a * b;
    } else {
        return("Te Hülye")
    }
    return(Func +"=" + eredmeny)
}
console.log(keruletTerulet(5, 12, "Kerület"))
console.log(keruletTerulet(5, 12, "Terület"))
console.log(keruletTerulet(5, 12, "Terül321312et"))


var eletszakaszok = function(nev, kor) {
    switch (true) {
        case kor < 13:
            return nev + "Gyerek"
            break
        case kor >= 13 && kor <= 20:
            return nev + "Tinédzser"
            break 
        case kor > 20 && kor <= 30:
            return nev + "ifjú"
            break
        case kor > 30 && kor <= 50:
            return nev + "Középkorú"
            break
        default:
            return nev + "Idős"

    }
}

console.log(eletszakaszok("szűke cigány", 23))
console.log(eletszakaszok("Botka Dániel", 100))
console.log(eletszakaszok("Bego", 40))


var nevek = ["Béla", "szűke", "Cigány"]

var korok =  new Array(35, 42, 38);

console.log(korok[1]);
console.log(nevek);
console.log(nevek.length);

nevek[1] = "Huba";
console.log(nevek);

nevek[nevek.length] = "Álmos";
console.log(nevek)

var huba = ['Huba', 38, 'Vezér', true];
console.log(huba);
huba.push(42);
console.log(huba)
huba.unshift('ifj');
console.log(huba);

huba.pop();
console.log(huba);

huba.shift();
console.log(huba);

var szakacs =huba.indexOf('szakács') ===  -1? 'Huba nem szakács:(' : 'Huba szakács ';
console.log(szakacs);
*/

var huba = {
    nev: 'Huba',
    kor: 39,
    foglalkozás: 'Vezér',
    házas: true,
    baratok: [
        'Állmos', 'Elöd', 'Ond',
    ],
    'családi állapot': "Nős"

};

console.log(huba.foglalkozás);
console.log(huba['nev']);

var h = 'hazas';
console.log(huba[h]);

console.log(huba['családi állapot'])
