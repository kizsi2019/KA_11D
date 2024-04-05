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
            kia: [{ id: 0 }],
            bev: [{ id: 0 }]
        },
        osszegek: {
            kia: 0,
            bev: 0
        }
    }

    return {
        tetelHozzaad: function(tip, lei, ert) {
            var ujTetel, ID;
            ID = 0;

            // ID létrehozása
            if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0) {
                ID = adat.tetelek[tip][adat.tetelek[tip].length - 1].id + 1;
            } else {
                ID = 0;
            }

            // Új kiadás vagy bevétel létrehozás
            if (tip === 'bev') {
                ujTetel = new Bevetel(ID, lei, ert);
            } else if (tip === 'kia') {
                ujTetel = new Kiadas(ID, lei, ert);
            }

            // Új tétel hozzáadása az adatszerkezethez
            if (adat.tetelek[tip] !== undefined) {
                adat.tetelek[tip].push(ujTetel);
            }

            // Új tétel visszadása
            return ujTetel;
        },

        teszt: function() {
            console.log(adat);
        }
    }
})();

// Felület vezérlés
var feluletVezerlo = (function() {
    var DOMelemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb'
    };

    return {
        getInput: function() {
            return {
                tipus: document.querySelector(DOMelemek.inputTipus).value,
                leiras: document.querySelector(DOMelemek.inputLeiras).value,
                ertek: document.querySelector(DOMelemek.inputErtek).value
            };
        },

        getDOMelemek: function() {
            return DOMelemek;
        },


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
            } else if (event.keyCode !== undefined && event.keyCode === 13) {
                vezTetelHozzaadas();
            }
        });
    };

    var vezTetelHozzaadas = function() {
        var input, ujTetel;

        // 1. bevitt adatok megszerzeése
        input = feluletVezerlo.getInput();

        // 2. adatok átadása a koltsegvetesVezerlo modulnak
        ujTetel = koltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);

        // 3. ?

        // 4. mezök törlése

        // 5. megjelenítés a felületen

        // 6. összeg megjelenítése a felületen
    };

    return {
        init: function() {
            console.log('Az alkalmazas fut');
            esemenykezeloBeallit();
        }
    };
})(koltsegvetesVezerlo, feluletVezerlo);

vezerlo.init();