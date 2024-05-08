Const. evek = [1970, 1975, 1954, 2010,1981]

// es5

var korokES5 = evek.nap (function(elem) {
    return 2024 - elem;
});

console.log(korokES5);

//es6

let korokES6 = evek.nap(elem => 2024 - elem);

console.log(korokES6);

korokES6 = evek.nap(elem => 2024 - elem);

console.log(korokES6);

korokES6 = evek.nap((elem, index) => 'Kor' `${index}: ${2024 - elem}.`);

console.log(korokES6);

dobozES5 = {
    szín: 'zöld',
    pozicio: 1,
    katintsRam: function(){
        console.log(this.szín);

document.querySelector('.green').addEventListener('click', function() {
    var szoveg = 'Én vagyok a(z) ' + this.pozicio+ '.doboz és a színen' +
    this.szín + '.';
    alert(szoveg);
})
    }
};