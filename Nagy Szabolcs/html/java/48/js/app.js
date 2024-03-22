// Költségvetés vezérlő
var koltsegvetesVezerlo = (function(){
    var Kiadas = function(id, leiras, ertek) {
        this.leiras = leiras;
        this.id = id;
        this.ertek = ertek;
    }
    var Bevitel = function(id, leiras, ertek) {
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
   

})();
//Felület vezérlő
var feluletVezerlo = (function() {
    var DOMelemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozaad__gomb',
    }

    return {
        getInput: function() {
            return{
                tipus: document.querySelector(DOMelemek.inputTipus).value,
                leiras: document.querySelector(DOMelemek.inputLeiras).value,
                ertek: document.querySelector(DOMelemek.inputErtek).value,
            }
        },
        getDOMelemek: function() {
            return DOMelemek;
        }
    }

})();
//Alkalmazás Vezérlő
var vezerlo = (function(koltsegvetesVez, feluletVez) {

    var esemenykezeloBeallit = function() {
    var DOM = feluletVezerlo.getDOMelemek();
    document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzaadas);

         document.addEventListener('keydown', function(event) {
            //console.log(event):
             if (event.key !== undefined && event.key === 'Enter') {
                 //console.log('enter')
                vezTetelHozzaadas();
        } else if (event.KeyCode !== undefined && event.KeyCode === 13)
            vezTetelHozzaadas();
    });
    } 



    var vezTetelHozzaadas = function() {
        //1. Bevitt adatok megszerzése
        var input = feluletVezerlo.getInput();
        //2. Adatok átadása a koltsegVezerlo modulnak

        //3. Megjelenités UI-n

        //4. Költségvetés újraszámolása

        //5. Összeg megjelenítése a felületen
    }    
    return {
        init: function() {
            console.log('Az alkalmazás fut');
            esemenykezeloBeallit();
            
        }
    }


    

})(koltsegvetesVezerlo, feluletVezerlo);


vezerlo.init();