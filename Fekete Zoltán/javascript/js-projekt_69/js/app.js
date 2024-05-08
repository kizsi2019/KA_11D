// Költségvetés vezérlés
var koltsegvetesVezerlo = (function() {
    var Kiadas = function(id, leiras, ertek) {
        this.leiras = leiras;
        this.id = id;
        this.ertek = parseInt(ertek);
    }
    var Bevetel = function(id, leiras, ertek) {
        this.leiras = leiras;
        this.id = id;
        this.ertek = parseInt(ertek);
    }

    var vegosszegSzamolas = function(tip) {
        var osszeg = 0;
        if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0) {
            adat.tetelek[tip].forEach(function(currentValue) {
                if (!isNaN(currentValue.ertek)) {
                    osszeg += currentValue.ertek;
                }
            });
            adat.osszegek[tip] = osszeg;
        }
    }

    var adat = {
        tetelek: {
            kia: [{ id: 0 }],
            bev: [{ id: 0 }]
        },
        osszegek: {
            kia: 0,
            bev: 0
        },
        koltsegvetes: 0,
        szazalek: -1
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

        tetelTorol: function(tip, id) {
            var idTomb, index;

            // Ellenőrzés, hogy a tetelek objektum és a tip kulcs létezik
            if (adat.tetelek && adat.tetelek[tip]) {
                idTomb = adat.tetelek[tip].map(function(aktualis) {
                    return aktualis.id;
                });
                index = idTomb.indexOf(id);

                if (index !== -1) {
                    adat.tetelek[tip].splice(index, 1);
                }
            } else {
                console.error('A tetelek objektum vagy a tip kulcs nem létezik.');
            }
        },

        koltsegvetesSzamolas: function() {
            // 1. Bevétel és kiadások összegének kiszámítása

            vegosszegSzamolas('bev');
            vegosszegSzamolas('kia');

            // 2. Költségvetés kiszámítása: bevétel - kiadások
            adat.koltsegvetes = adat.osszegek.bev - adat.osszegek.kia;

            // 3. Százalék számolása: kiadások / bevétel * 100
            if (adat.osszegek.bev > 0) {
                adat.szazalek = Math.round((adat.osszegek.kia / adat.osszegek.bev) * 100);
            } else {
                adat.szazalek = -1;
            }

        },

        getkoltsegvetes: function() {
            return {
                osszeg: adat.koltsegvetes,
                bev: adat.osszegek.bev,
                kia: adat.osszegek.kia,
                szazalek: adat.szazalek
            }
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
        kiadasTarolo: '.kiadasok__lista',
        koltsegvetesCimke: '.koltsegvetes__ertek',
        osszbevetelCimke: '.koltsegvetes__bevetelek--ertek',
        osszkiadasCimke: '.koltsegvetes__kiadasok--ertek',
        szazalekCimke: '.koltsegvetes__kiadasok--szazalek',
        kontener: '.kontener'
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
        },

        tetelTorles: function(tetelID) {

            var elem = document.getElementById(tetelID);
            elem.parentNode.removeChild(elem);
        },

        urlapTorles: function() {
            var mezok, mezokTomb;
            mezok = document.querySelectorAll(DOMelemek.inputLeiras + ', ' + DOMelemek.inputErtek);
            mezokTomb = Array.prototype.slice.call(mezok);

            mezokTomb.forEach(function(currentValue, index, array) {
                currentValue.value = '';
            });
            mezokTomb[0].focus();
        },

        koltsegvetesMegjelenites: function(obj) {
            document.querySelector(DOMelemek.koltsegvetesCimke).textContent = obj.osszeg;
            document.querySelector(DOMelemek.osszbevetelCimke).textContent = obj.bev;
            document.querySelector(DOMelemek.osszkiadasCimke).textContent = obj.kia;

            if (obj.szazalek > 0) {
                document.querySelector(DOMelemek.szazalekCimke).textContent = obj.szazalek + '%';
            } else {
                document.querySelector(DOMelemek.szazalekCimke).textContent = '---';
            }
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

        document.querySelector(DOM.kontener).addEventListener('click', vezTetelTorles);
    };

    var osszegFrissitese = function() {
        // 1. költségvetés újraszámolása
        koltsegvetesVezerlo.koltsegvetesSzamolas();

        // 2. Összeg visszaadása
        var koltsegvetes = koltsegvetesVezerlo.getkoltsegvetes();

        // 3. Összeg megjelenítése a felületen
        feluletVezerlo.koltsegvetesMegjelenites(koltsegvetes);
    }

    var vezTetelHozzaadas = function() {
        var input, ujTetel;

        // 1. Bevitt adatok megszerzeése
        input = feluletVezerlo.getInput();

        if (input.leiras !== '' && !isNaN(input.ertek) && input.ertek > 0) {

        // 2. Adatok átadása a koltsegvetés vezérlő modulnak
        ujTetel = koltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);

        // 3. Megjelenítés a felületen
        feluletVezerlo.tetelMegjelenites(ujTetel, input.tipus);
        // 4. Mezők törlése
        feluletVezerlo.urlapTorles();
        // 5. Költségvetés újraszámolása
        osszegFrissitese();
        }

        
    };

    var vezTetelTorles = function(event) {
        //console.log(event.taget.parentNode.parentNode.parentNode.parentNode);
        var tetelID, splitID, tip, ID

        tetelID = event.target.parentNode.parentNode.parentNode.parentNode.id;

        if (tetelID) {
            splitID = tetelID.split('-');
            tip = splitID[0];
            ID = parseInt(splitID[1]);

        // 1. tétel törlése az adat obj-ból
        koltsegvetesVezerlo.tetelTorol(tip, ID);

        // 2. tétel törlése a felületről
        feluletVezerlo.tetelTorles(tetelID);
        
        // 3. összegek újraszámolása és megjelenítése a felületen
        osszegFrissitese();
    };
}

    return {
        init: function() {
            console.log('Az alkalmazas fut');
            feluletVezerlo.koltsegvetesMegjelenites({
                osszeg: 0,
                bev: 0,
                kia: 0,
                szazalek: -1
                
            });
            esemenykezeloBeallit();
        }
    };
})(koltsegvetesVezerlo, feluletVezerlo);

vezerlo.init();