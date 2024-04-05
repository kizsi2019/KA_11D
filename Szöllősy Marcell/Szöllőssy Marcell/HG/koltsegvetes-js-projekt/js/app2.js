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
            } else {
                // kezeld a hibát, például dobjon hibát vagy állitsa 'ujtetel'-t 'null'-ra
                throw new Error('Invalid tip: ' + tip);
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
        inputGomb: '.hozzaad__gomb',
        bevetelTarolo: '.bevetelek__lista',
        kiadasTarolo: '.kiadasok__lista'
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

        tetelMegjelenites: function(obj, tipus) {
            var html, ujHtml, elem;

            // HTML string létrehozása placeholder értékekkel
            if (tipus === 'bev') {
                elem = DOMelemek.bevetelTarolo;
                html = '<div class="tetel clearfix" id="bevetelek-%id%"><div class="tetel__leiras">%leiras%</div><div class="right clearfix"><div class="tetel__ertek">%ertek%</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>';
            } else if (tipus === 'kia') {
                elem = DOMelemek.kiadasTarolo;
                html = '<div class="tetel clearfix" id="expense-%id%"><div class="tetel__leiras">%leiras%</div><div class="right clearfix"><div class="tetel__ertek">%ertek%</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>';
            }

            // HTML string placeholder értékekkel cseréje
            ujHtml = html.replace('%id%', obj.id);
            ujHtml = ujHtml.replace('%leiras%', obj.leiras);
            ujHtml = ujHtml.replace('%ertek%', obj.ertek);

            // HTML beszúrása a DOM-ba
            document.querySelector(elem).insertAdjacentHTML('beforeend', ujHtml);
        }
    };
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

        // 2. adatok átadása a koltsegvetés vezérlő modulnak
        ujTetel = koltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);

        // 3. megjelenítés a felületen
        feluletVezerlo.tetelMegjelenites(ujTetel, input.tipus);

        // 4. Kültségvetés újraszámolása

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