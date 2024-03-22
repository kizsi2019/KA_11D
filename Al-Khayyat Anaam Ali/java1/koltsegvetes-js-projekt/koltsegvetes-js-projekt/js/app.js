// költséges vezérlő
var koltsegvetesVezerlo = (function() {

})();
// Felület vezérlő
var feluletVezerlo = (function(){

})();

// Alkalmazás vezélrő
var vezerlo = (function(koltsegvetesVez, feluletVez){

    var vezTetelHozzaadas = function(){
        // 1. Bevitt adatok megszerzése

        // 2. Adatok átadása a koltsegVezerlo modulnak

        // 3. Megjelenítés UI-n

        // 4. Költségvetés Újraszámolása

        // 5. Összeg megjelnítése a felületen
        console.log('működik')
    }
    document.querySelector('.hozzaad__gomb').addEventListener('click', vezTetelHozzaadas);

    document.addEventListener('keydown', function(event) {
        if (event.keyCode === 13 || event.which === 13) {
            vezTetelHozzaadas();
        }
    });
})(koltsegvetesVezerlo, feluletVezerlo);

