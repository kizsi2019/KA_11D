var koltsegvezetesVezerlo = (function(){

    var a = 10;
    var osszead = function(b) {
        return a+b;
    }

    return {
        teszt: function(x) {
            console.log(osszead(x));
        }
    }
})();


var feluletVezerlo = (function(){

})();

var vezerlo = (function(koltsegvezetesVez, feluletVezerlo){
    
    var szam = koltsegvezetesVez.teszt(22);

    return {
        vezerloTeszt : function() {
            console.log(szam);
        }
    }
})(koltsegvezetesVezerlo, feluletVezerlo);

vezerlo.vezerloTeszt