var evek = [1954, 1990, 1963, 2000, 2010];

function tombMuvelet(tomb, fv){
    var eredmeny = []

    for (var i = 0; i < tomb.length; i++){
        eredmeny.push(fv(tomb[i]))
    }
    return eredmeny
}

function korszamitas(elem){
    return 2024 - elem;
}

function felnott(korhatar, elem){
    return elem >= korhatar;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(evek);
console.log(korok);

var felnottkorJapanban = tombMuvelet(korok, felnott.bind(this,20));
console.log(felnottkorJapanban);