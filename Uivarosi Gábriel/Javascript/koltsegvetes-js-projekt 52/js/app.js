// KÖLTSÉGVETÉSVEZÉRLŐ
var koltsegvetesVezerlo = (function() {

    var Kiadas = function(id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = ertek;
    }

    var Bevetel = function(id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = ertek;
    }

    var adat = {

        tetelek: {
            bev: [{ id: 0 }],
            kia: [{ id: 0 }]
        },

        osszegek: {
            bev: 0,
            kia: 0
        }
    }

    return {
        tetelHozzaad: function(tip, lei, ert) {
            var ujTetel, ID;
            ID = 0;

            // ID létrehozása
            if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].lenght > 0) {
                ID = adat.tetelek[tip][adat.tetelek[tip].lenght - 1].id + 1;
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
           
            if (adat.tetelek[tip !== undefined]) {
                adat.tetelek[tip].push(ujTetel);
            }

            // új tétel vissuadása
            return ujTetel;
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
        kiadasTarolo: '.kiadasok__lista'
    };

    return {
        getInput: function() {
            return {
                tipus: document.querySelector(DOMelemek.inputTipus).value,
                leiras: document.querySelector(DOMelemek.inputLeiras).value,
                ertke: document.querySelector(DOMelemek.inputErtek).value,
            };
        },

        getDOMelemek: function() {
            return DOMelemek;
        },
        tetelMegjelenites: function(obj, tipus) {
            var html, ujHtml, elem;
            if (tipus === 'bev') {
                elem = DOMelemek.bevetelTarolo;
                html = '                  <div class="tetel clearfix" id="bevetelek-%id%">  <div class="tetel__leiras">Fizetés</div>        <div class="right clearfix">       <div class="tetel__ertek">+ 2,100.00</div>       <div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button>           </div>        </div>  </div>     <div class="tetel clearfix" id="bevetelek-1">    <div class="tetel__leiras">Autó eladás</div>       <div class="right clearfix">     <div class="tetel__ertek">+ 1,500.00</div>     <div class="tetel__torol">  <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button>       </div>  </div>      </div>'     }
                 else if(tipus === 'kia')
                  {            elem = DOMelemek.kiadasTarolo;         
                     html = '     <div class="tetel clearfix" id="expense-%id%"> <div class="tetel__leiras">Lakás bérleti díj</div>     <div class="right clearfix">     <div class="tetel__ertek">- 900.00</div>       <div class="tetel__szazalek">21%</div> <div class="tetel__torol">        <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button>        </>div         </div>     </div>     <div class="tetel clearfix" id="expense-1">        <div class="tetel__leiras">Bevásárlás</div>      <div class="right clearfix">       <div class="tetel__ertek">- 435.28</div>      <div class="tetel__szazalek">10%</div>          <div class="tetel__torol">        <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button>     </div>          </div>      </div>'
                    }
        ujHtml = html.replace('%id%', obj.id);
        ujHtml = ujHtml.replace('%leírás%', obj.leiras);
        ujHtml = ujHtml.replace('%ertek%', obj.ertek);
        document.querySelector(elem).insertAdjacentHTML ('beforeend', ujHtml) ;
           
        },

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
}

    var DOM = feluletVezerlo.getDOMelemek();







    var vezTetelHozzadas = function() {

        var input, ujTetel;

        // 1. vecitt adat megszerzése
        input = feluletVezerlo.getInput();

        // 2. adatok átadása a költségvetésvezérlő modulnak.
        ujTetel =  koltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);

        // 3. megjelenités a ui-n
            feluletVezerlo.tetelMegjelenites(ujTetel, input.tipus)
        // 4. költségvetés újraszámolása

        // 5. összeg mejelenítése a felületen

    }

    return {
        init: function() {
            console.log('Alkalmazás fut');
            esemenykezelokBeallit();
        }
    }


})(koltsegvetesVezerlo, feluletVezerlo);

vezerlo.init();
