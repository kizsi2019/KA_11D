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

//////////
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