// KÖLTSÉGVETÉSVEZÉRLŐ
var koltsegvetesVezerlo = (function() {

})();


// FELÜLET VEZÉRLŐ
var feluletVezerlo = (function() {

})();


// ALKALMAZÁS VEZÉRLŐ
var vezerlo = (function(koltsegvetesVez, feluletVez){


    var vezTetelHozzadas = function() {
                // 1. vecitt adat megszerzése

        // 2. adatok átadása a költségvetésvezérlő modulnak

        // 3. megjelenités a ui-n

        // 4. költségvetés újraszámolása

        // 5. összeg mejelenítése a felületen
        console.log('műxik')
    }

    document.querySelector('.hozzaad__gomb').addEventListener('click', vezTetelHozzadas);

    document.addEventListener('keydown', function(event){

        if (event.key !== undefined && event.key === 'Enter') {
            vezTetelHozzadas();
        }
        else if (event.keyCode !== undefined && event.keyCode === 13) {
            vezTetelHozzadas();
        
        }
    });

})(koltsegvetesVezerlo, feluletVezerlo);

