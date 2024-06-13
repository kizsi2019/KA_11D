/*function parosVagyParatlanES6(...szamok) {
    console.log(szamok);
    szamok.forEach(aktualisElem => {
        if (aktualisElem % 2 === 0) {
            console.log('Paros');
        }else {
            console.log('Paratlan');
        }
    });
}

parosVagyParatlanES6(1, 2, 3);

function parosVagyParatlanES5(teszt) {

    var argumentumokTomb = Array.prototype.slice.call(arguments, 1);
    //console.log(argumentumokTomb);
    argumentumokTomb.forEach(function(aktualisElem) {
        if (aktualisElem % 2 ===0) {
            console.log('Paros');
        } else{
            console.log("Paratlan");
        }
    });
}
parosVagyParatlanES5(('teszt'),1, 2, 3, 100, 5,20);

function parosVagyParatlanES6(teszt, ...szamok) {
    //console.log(szamok);
    szamok.forEach(aktualisElem => {
        if (aktualisElem % 2 ===0 )
            console.log('Paros'); {
        }
    
    })
} */

/*
function AdamsFamily(keresztnev, szueletsiEv, csaladiNev) {
    csaladiNev === undefined ? csaladiNev = 'Adams' : csaladiNev = csaladiNev;
    this.keresztnev = keresztnev;
    this.szueletsiEv = szueletsiEv;
    this.csaladiNev = csaladiNev;

}

var Fester = new AdamsFamily("Fester", 1940);
var Mortisha = new AdamsFamily("Mortisha", 1965);
var kuzin = new AdamsFamily("kuzin", 1800, 'Hogyishívják');

//es6
function AdamsFamily(keresztnev, szueletsiEv, csaladiNev = 'Adams') {

    this.keresztnev = keresztnev;
    this.szueletsiEv = szueletsiEv;
    this.csaladiNev = csaladiNev;

}

var Fester = new AdamsFamily("Fester", 1940);
var Mortisha = new AdamsFamily("Mortisha", 1965);
var kuzin = new AdamsFamily("kuzin", 1800, 'Hogyishívják');
*/

/////////////////////////////////////////////////////////////////////
//Map

const kerdes = new Map();
kerdes.set('kerdes', 'Hogy hívják a de miéééért reklámban szereplő kisfiút?');
kerdes.set(1, 'Ödön');
kerdes.set(2, 'Ábel');
kerdes.set(3, 'Miklóska');
kerdes.set(4, 'Nándi');

kerdes.set('helyes', 2);

kerdes.set(true, 'Helyes válasz');
kerdes.set(false, 'Nem talált');

console.log(kerdes.get('kerdes'));
console.log(kerdes.size);

kerdes.delete(4);

if (kerdes.has(3)) {
    kerdes.delete(3);
}

kerdes.clear();

kerdes.forEach(
    (kulcs, ertek) => console.log(`Kulcs:${kulcs}, ertel: ${ertek}`)

    for (let [kulcs, ertek] of kerdes.entries()) {
        if (typeof(kulcs) === 'number') {
            console.log(`Kulcs: ${kulcs}, ertek: ${ertek}`);
        }
    }


    const valasz = parseInt(prompt("Add meg a helyes választ"));

    console.log(kerdes.get(valasz === kerdes.get('helyes')));
