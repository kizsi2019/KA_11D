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
            bev: [{  id: 0 }],
            kia: [{  id: 0 }]
        },

        osszegek: {
            bev: 0,
            kia: 0
        }
    }

    return {
        tetelHozzaad: function(tip, lei, ert) {
            var ujTetel;
            ID = 0;

            // ID létrehozása
            if (adat.teteleky[tip].lenght > 0) {
                ID = adat.tetelek[tip][adat.tetelek[tip].lenght - 1].id + 1;
            } else {
                ID = 0;
            }

            /// új kiadás v beevétel létrehozása
            if (tip === 'bev') {
                ujTetel = new Bevetel(ID, lei, ert);
            } else if (tip === 'kia') {
                ujTetel = new Kiadas(ID, lei, ert);
            }else {
                /*kezeld a hibát, például dobjon hibát vagy állitsa
                ujTelet-t null-ra*/
            }

            // új tétel hozzáadsa az adatszerkezethez
           if(adat.tetelek[tip] !== undefined){
            adat.tetelek[tip].push(ujTetel)
           };

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
        bevetelTarolo: '.bevetelek_lista',
        KiadasTarolo: 'kiadas_lista'
    };

    return {
        getInput: function() {
            return {
                tipus: document.querySelector(DOMelemek.inputTipus).value,
                leiras: document.querySelector(DOMelemek.inputLeiras).value,
                ertke: document.querySelector(DOMelemek.inputErtek).value,
            }
        },

        getDOMelemek: function() {
            return DOMelemek;
        },
        tetelMegjelentítes: function(obj, tipus) {
            var html, ujHtmly, elem

            //Html string letrehozasa placeholder értékekkel
            if (tipus === 'bev') {
                elem = DOMelemek.bevetelTarolo;
                html = '<div class="tetel clearfix" id="bevetelek-0">';
            } else if (tipus === 'kia') {
                elem = DOMelemek.KiadasTarolo
                html = ''
            }
            //Html string placeholder értékekkel cseréje
            ujHtml = html.replace('%id%', obj.id);
            ujHtml = ujHtml.replace('%leuras%',obj.leiras);
            ujHtml = ujHtml.replace('%ertek%', obj.ertek);

            //HTML beszurása a DOM-ba
            document.querySelector(elem).insertAdjacentHTML
            ('beforeend', ujHtml);
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
}

    var DOM = feluletVezerlo.getDOMelemek();

    var vezTetelHozzadas = function() {

        var input, ujTetel;

        // 1. bevitt adat megszerzése
        input = feluletVezerlo.getInput();

        // 2. adatok átadása a költségvetésvezérlő modulnak.
        ujTetel =  koltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);

        // 3. megjelenités a ui-n
        feluletVezerlo.tetelMegjelentítes(ujTetel, input.tipus)
        
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
