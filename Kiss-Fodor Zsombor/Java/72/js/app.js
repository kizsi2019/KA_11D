/*
const evek = [1970, 1975, 1954, 2010, 1981]

var korokES5 = evek.map(function(elem) {
    2024-elem;
});

console.log(korokES5);

let korokES6 = evek.map(elem=> 2024-elem);

console.log(korokES6);

korokES6TemplateLiteral = evek.map((elem, index) => `Kor ${index}: ${2024-elem}.`)

console.log(korokES6TemplateLiteral)

//korokES6Date = evek.map((elem,index))
*/

var dobozES5 = {
    szin: 'zöld',
    pozicio: 1,
    KattintsRam: function() {
        var objektum = this;
        document.querySelector('.green').addEventListener('click', function() { 
            var szoveg = 'Én vagyok a(z) ' + objektum.pozicio + '. doboz és a színem ' + objektum.szin + '.';
            alert(szoveg);
        })
    }
};

dobozES5.KattintsRam();

const dobozES6 = {
    szin: 'zöld',
    pozicio: 1,
    KattintsRam: function() {
        greenElement.addEventListener('click', () => { 
            console.log("Click event is triggered");
            var szoveg = 'Én vagyok a(z) ' + this.pozicio + '. doboz és a színem ' + this.szin + '.';
            alert(szoveg);
        })
    }
};

dobozES6.KattintsRam();