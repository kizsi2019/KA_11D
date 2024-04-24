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

    var vegosszegSzamlalo = function(tip) {
        var osszeg = 0;
        if (adat.tetelek[tip] !== undefined  && adat.tetelek [tip].lenght > 0){
            adat.tetelek[tip].Foreach(function(currentValue){
                if(!isNaN(currentValue.ertek)) {
                    osszeg += currentValue.ertek;
                }
            });
            adat.osszegek[tip] = osszeg
    }
}

    var adat = {

        tetelek: {
            bev: [{  id: 0 }],
            kia: [{  id: 0 }]
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
            var ujTetel;
            ID = 0;

            // ID létrehozása
            if (adat.tetelek[tip]!==undefined&&adat.tetelek[tip].lenght > 0) {
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
                throw new console.error('hiabas tip: '+ tip);
            }

            // új tétel hozzáadsa az adatszerkezethez
           if(adat.tetelek[tip] !== undefined){
            adat.tetelek[tip].push(ujTetel)
           };

            // új tétel vissuadása
            return ujTetel;
        },
koltsegvetesSzamolas: function(){
        // 1. Bevétel és kiadások összegének kiszámítása

        vegosszegSzamolas('bev');
        vegosszegSzamolas('kia');

        //2. Költségvetés kiszámítása: bevétel - kiadások
        adat.koltsegvetes = adat.osszegek.bev - adat.osszegek.kia
        
        //
}

        teszt: function(){
            console.log(adat);
        }
    }

})();



// FELÜLET VEZÉRLŐ
var feluletVezerlo = (function() 
{

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
            }
        },

        getDOMelemek: function() {
            return DOMelemek;
        },
        tetelMegjelentítes: function(obj, tipus) {
            var html, ujHtml, elem

            //Html string letrehozasa placeholder értékekkel
            if (tipus === 'bev') {
                elem = DOMelemek.bevetelTarolo;
                html = '<div class="tetel clearfix" id="bevetelek-%id%"><div class="tetel__leiras">%leiras%</div><div class="right clearfix"><div class="tetel__ertek">%ertek%</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>';
            } else if (tipus === 'kia') {
                elem = DOMelemek.kiadasTarolo
                html = '<div class="tetel clearfix" id="expense-%id%"><div class="tetel__leiras">%leiras%</div><div class="right clearfix"><div class="tetel__ertek">%ertek%</div><div class="tetel__szazalek">21%</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>';
            }

             //Html string placeholder értékekkel cseréje
             ujHtml = html.replace('%id%', obj.id);
             ujHtml = ujHtml.replace('%leiras%',obj.leiras);
             ujHtml = ujHtml.replace('%ertek%', obj.ertek);
 
             //HTML beszurása a DOM-ba
             document.querySelector(elem).insertAdjacentHTML('beforeend', ujHtml);
           
            },
            urlapTorles: function () {
                var mezok, mezokTomb;
                mezok = document.querySelectorAll(DOMelemek.inputLeiras +', '+ DOMelemek.inputErtek);
                mezokTomb = Array.prototype.slice.call(mezok);
    
                mezokTomb.Foreach(function(currentValue, index, array) {
                    currentValue.value = '';
                });
                mezokTomb[0].focus();
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

        if (input.leiras !== '' && !isNaN(input.ertek) && input.ertek > 0) {

    

        // 2. adatok átadása a költségvetésvezérlő modulnak.
        ujTetel =  koltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);

        // 3. megjelenités a ui-n
        feluletVezerlo.tetelMegjelentítes(ujTetel, input.tipus)
        
        // 4. költségvetés újraszámolása


        // 5. összeg mejelenítése a felületen

    }}

    return {
        init: function() {
            console.log('Alkalmazás fut');
            esemenykezelokBeallit();
        }
    }


})(koltsegvetesVezerlo, feluletVezerlo);

vezerlo.init();
