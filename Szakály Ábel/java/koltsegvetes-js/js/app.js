// Költségvetés vezérlés
var koltsegvetesVezerlo = (function() {
    var Kiadas = function(id, leiras, ertek) {
        this.leiras = leiras;
        this.id = id;
        this.ertek = ertek;
    }
    var Bevetel = function(id, leiras, ertek) {
        this.leiras = leiras;
        this.id = id;
        this.ertek = ertek;
    }

    var adat = {
        tetelek: {
            kia: [],
            bev: []
        },
        osszegek: {
            kia: 0,
            bev: 0
        },
    }

    return{
        tetelHozzaad: function(tip, lei, ert) {
            var ujTetel, ID;
            ID = 0;

            if (adat.tetelek[tip] !== undfined && adat.tetelek[tip].length > 0){
                ID = adat.tetelek[tip] [adat.tetelek[tip].length - 1]. id + 1;
            } else{
                ID = 0;
            }

            if
        }
    }
    
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

    var esemenykezeloBeallit = function() {
        var DOM = feluletVezerlo.getDOMelemek();
        document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzaadas);



        document.addEventListener('keydown', function(event) {
            if (event.key !== undefined && event.key === 'Enter') {
                vezTetelHozzaadas();
            }
            else if (event.keyCode !== undefined && event.keyCode === 13) {
                vezTetelHozzaadas();
            }
        });
    }

    var vezTetelHozzaadas = function() {
        // 1. bevitt adatok megszerzeése
        var input = feluletVezerlo.getInput();

        // 2. adatok átadása a koltsegvetesVezerlo modulnak

        // 3. megjelenítés az UI-n

        // 4. költségvetés újraszámolása

        // 5. összeg megjelenítése a felületen

    }
    return {
        init: function() {
            console.log('Az alkalmazas fut');
            esemenykezeloBeallit();
        }
    }
})(koltsegvetesVezerlo, feluletVezerlo);

vezerlo.init();
