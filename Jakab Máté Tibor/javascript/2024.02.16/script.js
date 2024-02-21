var evek = [1954, 1990, 1963, 200, 2010];

function tombMuvelet(tomb, fv) {
    var eredmeny = [];

    for (var i = 0; i < tomb.length; i++) {
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny
}

function felnott(korhatar, elem) {
    return elem >= korhatar;
}

function korszamitas(elem) {
    return 2024 - elem;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(evek);
console.log(korok);

var felnott = tombMuvelet(korok, felnott);
console.log(felnott);