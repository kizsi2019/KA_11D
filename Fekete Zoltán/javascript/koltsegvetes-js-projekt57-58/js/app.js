// KÖLTSÉGVETÉSVEZÉRLŐ
var koltsegvetesVezerlo = (function() {

    var Kiadas = function(id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek =parseInt( ertek);
    }

    var Bevetel = function(id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek =ertek;
    }



    var vegosszegSzamolas = function(tip)  {
        var osszeg = 0;
        if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0) {
            adat.tetelek[tip].forEach(function(currentValue) {
                if (!isNaN(currentValue.ertek)) {
                    osszeg += currentValue.ertek;
                }
            });
            adat.osszegek[tip] = osszeg;
        };
    };
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
        tetelHozzaad: function(tip, lei, ert) {
            var ujTetel, ID;
            ID = 0;

            // ID létrehozása
            if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0) {
                ID = adat.tetelek[tip][adat.tetelek[tip].length - 1].id + 1;
            } else {
                ID = 0;
            }

            /// új kiadás v beevétel létrehozása
            if (tip === 'bev') {
                ujTetel = new Bevetel(ID, lei, ert);
            } else if (tip === 'kia') {
                ujTetel = new Kiadas(ID, lei, ert);
            } else {
                // Hiba Kezelés.
                throw new Error('Invalid tip' + tip);
            }

            // új tétel hozzáadsa az adatszerkezethez
           
            if (adat.tetelek[tip] !== undefined) {
                adat.tetelek[tip].push(ujTetel);
            }

            // új tétel vissuadása
            return ujTetel;
        },

koltsegvetesSzamolas: function() {
 // 1. Bevétel s kiadások összegének kiszánitsa
    vegosszegSzamolas('bev');
    vegosszegSzamolas('kia');
 // 2. Költsévetés kiszámitások: betétel - kiadások


    adat.koltsegvetes = adat.osszegek.bev - adat.osszegek.kia;
// 3. Százalák számolása / betétel - kiadások
    if (adat.osszegek.bev > 0) {
        adat.szazalek = Math.round((adat.osszegek.kia / adat.osszegek.bev) * 100);
    } else {
        adat.szazalek = -1;
    }
},

getkoltsevgetes: function() {
    return {
        osszeg: adat.koltsegvetes,
        bev: adat.osszegek.bev,
        bev: adat.osszegek.kia,
        szazalek: adat.szazalek
    }
},



        teszt: function(){
            console.log(adat);
        }
    }

})();

var Bevetel = function(id, leiras, ertek) {
    this.id = id;
    this.leiras = leiras;
    this.ertek = ertek;
}

// FELÜLET VEZÉRLŐ
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
                ertek: parseInt( document.querySelector(DOMelemek.inputErtek).value)
            };
        },

        getDOMelemek: function() {
            return DOMelemek;
        },
        tetelMegjelenites: function(obj, tipus) {
            var html, ujHtml, elem;
            if (tipus === 'bev') {
                elem = DOMelemek.bevetelTarolo;
                html = '<div class="tetel clearfix" id="bevetelek-%id%">  <div class="tetel__leiras">%leírás%</div>        <div class="right clearfix">       <div class="tetel__ertek">%ertek%</div>       <div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button>           </div>        </div>  </div>     '     }
                 else if(tipus === 'kia')
                  {            elem = DOMelemek.kiadasTarolo;         
                     html = '<div class="tetel clearfix" id="expense-%id%"> <div class="tetel__leiras">%leírás%</div>     <div class="right clearfix">     <div class="tetel__ertek">%ertek%</div>       <div class="tetel__szazalek">21%</div> <div class="tetel__torol">        <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button>        </>div         </div>     </div>'
                    }
        ujHtml = html.replace('%id%', obj.id);
        ujHtml = ujHtml.replace('%leírás%', obj.leiras);                   
        ujHtml = ujHtml.replace('%ertek%', obj.ertek);
        document.querySelector(elem).insertAdjacentHTML ('beforeend', ujHtml) ;
           
        },

        tetelTorol: function(tetelID) {
            var elem = document.querySelector(selectorID); // why not tetelID?
            elem.parentNode.removeChild(elem);
        },
        
        urlapTorles: function() {
            var mezok, mezokTomb;
            mezok = document.querySelectorAll(DOMelemek.inputLeiras + ',' + DOMelemek.inputErtek);
            mezokTomb = Array.prototype.slice.call(mezok);
            mezokTomb.forEach(function(currentValue, index, arrey) {
                currentValue.value= '';
            })
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
    }

})();


// ALKALMAZÁS VEZÉRLŐ
var vezerlo = (function(koltsegvetesVez, feluletVez){

    var esemenykezelokBeallit = function() {

        var DOM = feluletVezerlo.getDOMelemek();

        document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzadas);

        document.addEventListener('keydown', function(event){

            if (event.key !== undefined && event.key === 'Enter') {
                vezTetelHozzadas();
            }
            else if (event.keyCode !== undefined && event.keyCode === 13) {
                vezTetelHozzadas();
            }
    });

    document.querySelector(DOM.kontener).addEventListener('click', vezTetelTorles);
}

    var DOM = feluletVezerlo.getDOMelemek();



var összegFrissitese = function() {
    // 1  Költségvetés újraszámolása
 koltsegvetesVezerlo.koltsegvetesSzamolas();
 //2 Összeg visszaadása
 var koltsegvetes = koltsegvetesVezerlo.getkoltsevgetes();
//3 Összeg megjelenítése a felületen
 feluletVezerlo.koltsegvetesMegjelenites(koltsegvetes);

}




    var vezTetelHozzadas = function() {

        var input, ujTetel;

        // 1. vecitt adat megszerzése
        input = feluletVezerlo.getInput();
if (input.leiras !== "" && !isNaN(input.ertek) && input.ertek > 0) {
        // 2. adatok átadása a költségvetésvezérlő modulnak.
        ujTetel =  koltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);

        // 3. megjelenités a ui-n
            feluletVezerlo.tetelMegjelenites(ujTetel, input.tipus)
        // 4. költségvetés újraszámolása
            feluletVezerlo.urlapTorles();
        // 5. összeg mejelenítése a felületen
        összegFrissitese();
}
    }

var vezTetelTorles = function(event) {
    var tetelID, splitId, tipus, ID
    tetelID = event.target.parentNode.parentNode.parentNode.parentNode.id;

    if (tetelID) {

        splitId = tetelID.split('-');
        tipus  = splitId[0];
        ID = splitId[1];
    }
    // 1. tétel törlése az adat obj-ből

    // 2. tétel törlése a felületről

    // 3. összegek újraszámolása és megjelenítése a felületen
}


    return {
        init: function() {
            console.log('Alkalmazás fut');
            esemenykezelokBeallit();
        }
    }


})(koltsegvetesVezerlo, feluletVezerlo);

vezerlo.init();
