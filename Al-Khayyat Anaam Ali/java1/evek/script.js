var evek = [ 1954, 1999, 1963, 2000, 2010];

function tombMuvelet(tomb, fv) {
    var eredmeny = [];

    for (var i = 0; i < tomb.length; i ++) {
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;
}
function korszamitas(elem) {
    return 2024 - elem;
}
function felnott(elem) {
    return elem >= 18;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(korok);

var felnottek = tombMuvelet(korok, felnott);
console.log(felnottek);