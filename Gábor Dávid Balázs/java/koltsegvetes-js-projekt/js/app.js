// Költségvetés vezérlés
var koltsegvetesVezerlo = (function() {
    
})();

// Felület vezérlés
var feluletVezerlo = (function() {

})();

// Alkalmazás vezérlés
var vezerlo = (function(koltsegvetesVez, feluletVez) {

    var vezTetelHozzaadas = function() {
        // 1. bevitt adatok megszerzeése

        // 2. adatok átadása a koltsegvetesVezerlo modulnak

        // 3. megjelenítés az UI-n

        // 4. költségvetés újraszámolása

        // 5. összeg megjelenítése a felületen

        console.log('Mukodik')

    }
    document.querySelector('.hozzaad__gomb').addEventListener('click', vezTetelHozzaadas);

    document.addEventListener('keydown', function(event) {
        if (event.keyCode === 13 || event.which === 13) {
            vezTetelHozzaadas();
        }
    });
})(koltsegvetesVezerlo, feluletVezerlo);
