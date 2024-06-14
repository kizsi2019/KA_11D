var eletszakaszok = function(nev, kor) {
    switch(true) {
        case kor < 13:
            return nev + " gyerek";
            break;
        case kor >= 13 && kor <= 20:
            return nev + " tini";
            break;
        case kor > 20 && kor <= 30:
            return nev + " ifjú";
            break;
        case kor > 30 && kor <= 50:
            return nev + " középkorú";
            break;
        case kor > 50:
            return nev + " idős";
            break;
    }
}

console.log(eletszakaszok("Kati",12));
console.log(eletszakaszok("Peti",20));
console.log(eletszakaszok("Márk",67));