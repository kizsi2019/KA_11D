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

function adult(elem){
    return elem >= 18;
}

var ages = BlockCalculation(years, AgeCalculate);
console.log(ages);

var adults = BlockCalculation(ages, adult);
console.log(adults);