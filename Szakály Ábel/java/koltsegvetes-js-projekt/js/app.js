var koltsegvetesVezerlo = (function(){

})();

var feluletVezerlo = (function(){

})();

var vezerlo = (function(koltsegVez, feluletVez){

    var vezTetelHozzaadas = function(){
        //1. Bevitt adatok megszerzése

        //2. Adatok átadása a koltségVezérlő modulnak

        // 3. Megjelenítés UI-n

        // 4. Költségvetés újraszámolása

        // 5. Összeg megjelenítése a felületen
        console.log('Működik')
    }
    
    document.querySelector('.hozzaad__gomb').addEventListener('click', vezTetelHozzaadas);
    
    document.addEventListener('keydown', function(event){
        if (event.keyCode === 13){
            vezTetelHozzaadas();
        }
});

})(koltsegvetesVezerlo, feluletVezerlo);

