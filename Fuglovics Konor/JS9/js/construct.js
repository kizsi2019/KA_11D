var years = [1945, 1985, 2001, 2005, 2016];

function BlockCalculation(block, fv){
    var result = [];

    for (var i = 0; i < block.length; i++){
        result.push(fv(block[i]));
    }
    return result;
}

function AgeCalculate(elem){
    return 2024 - elem;
}


var ages = BlockCalculation(years, AgeCalculate);
console.log(ages);

consent = 18;

function adult(consent, elem){
    return elem >= consent;
}

var adults = BlockCalculation(years, AgeCalculate);
console.log(years);
console.log(ages);

var AdultInJapan = BlockCalculation(ages, adult.bind(this, 20))
console.log(AdultInJapan);