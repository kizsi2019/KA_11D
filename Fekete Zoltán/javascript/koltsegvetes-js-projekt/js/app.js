//költségvetés vezérlő
var koltsegvetesvezerlo = (function(){

})();

//felület vezérlő
var feluletvezerlo = (function(){


})();

//alkalmazás vezérlő
var vezerlo = (function(koltsegvetesvez, feluletvez){

    var veztetelhozzaadas = function(){
        console.log("müködik")
    }
    document.querySelector('.hozzaad__gomb').addEventListener('click', veztetelhozzaadas);
    document.addEventListener('keydown', function(event){
        if(event.keyCode === 13){
            veztetelhozzaadas
        };
    });
})(koltsegvetesvezerlo, feluletvezerlo);
