//Költségvetés vezérlő
var KoltsegvetesVezerlo = (function () {

    //
    var Kiadas = function (id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = ertek;
    }
    var Bevetel = function (id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = ertek;
    }

    var vegosszegSzamolas = function() {
        var osszeg = 0;
        if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].lenght > 0 ) {
            adat.tetelek[tip].forEach(function(currentValue) {
                if (!isNaN(currentValue.ertek)) {
                    osszeg += currentValue.ertek;
                }
            });
            adat.osszegek[tip] = osszeg;
        }
    }

    //
    var adat = {
        tetelek: {
            bev: [{ id: 0 }],
            kia: [{ id: 0 }]
        },
        osszegek: {
            bev: 0,
            kia: 0
        },
        koltsegvetes: 0,
        szazalek: -1
    }

    return {
        //
        tetelHozzaad: function (tip, lei, ert) {
            var ujTtetel, ID;
            ID = 0;

            //ID létrehozás
            if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].lenght > 0) {
                ID = adat.tetelek[tip][adat.tetelek[tip].lenght - 1].id + 1;
            }
            else {
                ID = 0;
            }

            //új kiadaás vagy bevétel létrehozása
            if (tip === 'bev') {
                ujTtetel = new Bevetel(ID, lei, ert);
            } else if (tip === 'kia') {
                ujTtetel = new Bevetel(ID, lei, ert);
            } else {
                throw new Error('Invalid tip: ' + tip);
            }

            //új tétel
            if (adat.tetelek[tip] !== undefined) {
                adat.tetelek[tip].push(ujTtetel);
            }

            return ujTtetel;
        },


        koltsegvetesSzamolas: function() {
            //bevétel és kiadások kiszámolása

            vegosszegSzamolas('bev');
            vegosszegSzamolas('kia');

            //költségvetés kiszámítása
            adat.koltsegvetes = adat.osszegek.bev - adat.osszegek.kia;

            //százalék kíszámítása
            if (adat.osszegek.bev > 0) {
                adat.szazalek = Math.round((adat.osszegek.kia / adat.osszegek.bev) * 100);
            } else {
                adat.szazalek = -1;
            }

        },

        getKoltsegvetes: function() {
            return {
                osszeg: adat.koltsegvetes,
                bev: adat.osszegek.bev,
                kia: adat.osszegek.kia,
                szazalek: adat.osszegek.szazalek
            }
        },

        //Új tétel visszaadása
        teszt: function () {
            console.log(adat);
        }
    }
})();

//felület vezérlő
var feluletVezerlo = (function () {

    //DOM elementek a HTML-en
    var DOMelemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb',
        bevetelTarolo: '.bevetelek__lista',
        kiadasTarolo: '.kiadasok__lista'
    };

    //
    return {

        //
        getInput: function () {
            return {
                tipus: document.querySelector(DOMelemek.inputTipus).value,
                leiras: document.querySelector(DOMelemek.inputLeiras).value,
                ertek: document.querySelector(DOMelemek.inputErtek).value
            }
        },

        //
        getDOMelemek: function () {
            return DOMelemek;
        },

        //
        tetelMegjeleneites: function (obj, tipus) {
            var html, ujHtml, elem;

            //HTML string létrehozása
            if (tipus === 'bev') {
                elem = DOMelemek.bevetelTarolo;
                html = '<div class="tetel clearfix" id="bevetelek-%id%"> <div class="tetel__leiras"> %leiras% </div> <div class="right clearfix"> <div class="tetel__ertek">%ertek%</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button> </div> </div> </div>';
            } else if (tipus === 'kia') {
                elem = DOMelemek.kiadasTarolo;
                html = '<div class="tetel clearfix" id="expense-%id%"><div class="tetel__leiras"> %leiras% </div><div class="right clearfix"><div class="tetel__ertek">%ertek%</div><div class="tetel__szazalek">10%</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>';
            }

            //HTML string placeholder cseréje
            ujHtml = html.replace('%id%', obj.id);
            ujHtml = ujHtml.replace('%leiras%', obj.leiras);
            ujHtml = ujHtml.replace('%ertek%', obj.ertek);

            //HTML DOMba szúrása
            document.querySelector(elem).insertAdjacentHTML('beforeend', ujHtml);
        },
        urlapTorles: function() {
            var mezok, mezokTomb;
            mezok = document.querySelectorAll(DOMelemek.inputLeiras + ', ' + DOMelemek.inputErtek);
            mezokTomb = Array.prototype.slice.call(mezok);

            mezokTomb.forEach(function(currentValue, index, array) 
            {
                currentValue.value = '';
            });
            mezokTomb[0].focus();
        }
    }
})();

//alkamazás vezérlő
var vezerlo = (function (KoltsegvetesVez, feluletVez) {

    var esemenykezeloBeallit = function () {

        var DOM = feluletVezerlo.getDOMelemek();

        //tétel hozzáadása kattintással
        document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzadas);

        //tétel hozzáadása enter gombal
        document.addEventListener('keydown', function (event) {
            //új megoldás
            if (event.key !== undefined && event.key === 'Enter') {
                vezTetelHozzadas();
            }
            //régi elavult megoldás
            else if (event.keyCode !== undefined && event.keyCode === 13) {
                vezTetelHozzadas();
            }
        });
    };

    var osszegFrissetese = function() {
        //költségvetés újraszámolása
        KoltsegvetesVezerlo.koltsegvetesSzamolas();

        //összeg visszaadása
        var koltsegvetes = KoltsegvetesVezerlo.getKoltsegvetes();

        //összeg megjelenítése a felületen
        console.log(koltsegvetes);
    }


    var vezTetelHozzadas = function () {

        var input, ujTtetel;

        //bevitt adatok megszerzése
        var input = feluletVezerlo.getInput();

        if (input.leiras !== '' && !isNaN(input.ertek) && input.ertek > 0) {
            //adatok átadása a koltsegVezerlo modulnak
        ujTtetel = KoltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);

        //megjelenítés UI-n
        feluletVezerlo.tetelMegjeleneites(ujTtetel, input.tipus);

        //Mezők törlése
        feluletVezerlo.urlapTorles();

        //költségvetés újraszámolása és frissítése a felületen
        osszegFrissetese();
        } 
    }

    //Program Elindítása és csekkolása hogy működik
    return {
        init: function () {
            console.log('Alkalmazás fut');
            esemenykezeloBeallit();
        }
    }

})(KoltsegvetesVezerlo, feluletVezerlo);

//indításkor lefutó funkció
vezerlo.init()