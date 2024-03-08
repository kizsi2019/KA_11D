// Költségvetés vezérlés
var koltsegvetesVezerlo = (function() {
    
})();

// Felület vezérlés
var feluletVezerlo = (function() {
    var DOMelemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb',
    }

    return {
        getInput: function() {
            return {
                tipus: document.querySelector(DOMelemek.inputTipus).value,
                leiras: document.querySelector(DOMelemek.inputLeiras).value,
                ertek: document.querySelector(DOMelemek.inputErtek).value
            }
        },
        getDOMelemek: function() {
            return DOMelemek;
        }
    }

})();

// Alkalmazás vezérlés
var vezerlo = (function(koltsegvetesVez, feluletVez) {

    var DOM = feluletVezerlo.getDOMelemek();

    var vezTetelHozzaadas = function() {
        // 1. bevitt adatok megszerzeése
        var input = feluletVezerlo.getInput();
        console.log(input);

        // 2. adatok átadása a koltsegvetesVezerlo modulnak

        // 3. megjelenítés az UI-n

        // 4. költségvetés újraszámolása

        // 5. összeg megjelenítése a felületen

        console.log('Mukodik')

    }
    document.querySelector('.hozzaad__gomb').addEventListener('click', vezTetelHozzaadas);

    document.addEventListener('keydown', function(event) {
        if (event.key !== undefined && event.key === 'Enter') {
            vezTetelHozzaadas();
        }
        else if (event.keyCode !== undefined && event.keyCode === 13) {
            vezTetelHozzaadas();
        }
    });
})(koltsegvetesVezerlo, feluletVezerlo);
