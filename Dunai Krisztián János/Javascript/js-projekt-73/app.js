const evek = [1970, 1975, 1954, 2010, 1981]

var korokES5 = evek.map(function(elem) {
    return 2024 - elem;

});

console.log(korokES5);

let korokES6 = evek.map(elem => 2024 - elem);

console.log(korokES6);

korokES6 = evek.map((elem, index) => 'kor '
)