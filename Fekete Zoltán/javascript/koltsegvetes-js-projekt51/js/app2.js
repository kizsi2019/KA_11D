var koltsegvezetesVezerlo = (function(){

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

    return{
        tetelekHozzaad: function(tip, lei, ert) {
            var ujTetel, ID;
            ID = 0

            if(adat.tetelek[tip].length > 0) {
                ID = adat.tetelek[tip][adat.tetelek[tip].length - 1].id + 1;
            } else {
                ID = 0;
            }

            if (tip === 'bev') {
                ujTetel = new Bevetel(ID, lei, ert);
            } else if (tip === 'kia') {
                ujTetel = new Kiadas(ID, lei, ert);
            }

            adat.tetelek[tip].push(ujTetel);

            return ujTetel
        },

        teszt: function(){
            console.log(adat);
        }
    }

})();

var feluletVezerlo = (function(){

    var DOMelemek = {
        inputTipus: 'hozzaad_tipus',
        inputLeiras: 'hozzaad_leiras',
        inputErtek: 'hozzaad_ertek',
        inputGomb: 'hozzaad_gomb',
        bevetelTarolo:'bevetelek_lista',
        kiadasTarolor:'kiadas_lista'
    };

    return {
        getInput: function(){
            return{
            tipus: document.querySelector(DOMelemek.inputTipus).value,
            leiras: document.querySelector(DOMelemek.inputLeiras).value,
            ertek:  document.querySelector(DOMelemek.inputErtek).value
            }

        },
        getDOMelemek: function(){
            return DOMelemek;
        },

        tetelekMegjelenites: function(obj, tipus) {
                var html, ujHtml, elem;
                console.log(obj);

            if (tipus === 'bev') {
                elem = DOMelemek.bevetelTarolo;

                html = '<div class="tetel clearfix" id="bevetelek-0"><div class="tetel__leiras">Fizetés</div><div class="right clearfix"><div class="tetel__ertek">+ 2,100.00</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>';
            } else if (tipus === 'kia') {
                elem = DOMelemek.kiadasTarolorTarolo;

                html = '<div class="tetel clearfix" id="bevetelek-1"><div class="tetel__leiras">Autó eladás</div><div class="right clearfix"><div class="tetel__ertek">+ 1,500.00</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>';
            }

            ujHtml = html.replace('%id%', onj.id);
            ujHtml = ujHtml.replace('%leiras%', onj.id);
            ujHtml = ujHtml.replace('%ertek%', onj.id);

            document.querySelector(elem).insertAdjacentHTML('beforeend', ujHtml);

        },

        urlapTorles: function(){
            var mezok, mezoktomb;

            mezok = document.querySelector(DOMelemek.inputLeiras + ', ' + DOMelemek.inputErtek);
            mezoktomb = Array.prototype.slice.call(mezok);

            mezoktomb.forEach(function(currentValue, index, array) {
                currentValue.value = '';
            });
            mezoktomb[0].focus();

            
        }

    }

})();

var vezerlo = (function(koltsegvezetesVez, feluletVez){

    var esemenykezeloBeallit = function(){

        var DOM = feluletVezerlo.getDOMelemek();

        document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzadas);

        document.addEventListener('keydown', function(event){
        if (event.key !== undefined && event.key === 'enter'){

        } else if (event.keyCode !== undefined && event.keyCode === 13){
            vezTetelHozzadas();
        }
        });

    }


    var vezTetelHozzadas = function() {
        var input, ujTetel;

        input = feluletVezerlo.getInput();

        ujTetel = koltsegvezetesVezerlo-tetelekHozzaad(input.tipus, input.leiras, input.ertek);

        feluletVezerlo.tetelekMegjelenites(ujTetel, input.tipus); 

        feluletVezerlo.urlapTorles();


    }
    return {
        init: function() {
            console.log('Alkalmazás fut');
            esemenykezeloBeallit();
        }
    }


})(koltsegvezetesVezerlo, feluletVezerlo);

vezerlo.init();