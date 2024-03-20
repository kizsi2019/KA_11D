//költségvetévezérlő
var koltsegvetesVezerlo = (function(){
    var Kiadas = function(id, leiras, ertek){
        this.leiras = leiras;
        this.id = id;
        this.ertek = ertek; 
    }

    var Bevetel = function(id, leiras, ertek){
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
        }
    }

})();

//felületvezérlő
var feluletVezerlo = (function(){
    var DOMelemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb'
    }

    return {
        getInput: function(){
            return{
                tipus: document.querySelector(DOMelemek.inputTipus).value,
                leiras: document.querySelector(DOMelemek.inputLeiras).value,
                ertek: document.querySelector(DOMelemek.inputErtek).value
            }
        },

        getDOMelemek: function(){
            return DOMelemek;
        }
    }
})();

//alkalmazásvezérlő
var vezerlo = (function(koltsegbvetesVez, feluletVez){

    var esemenykezeloBeallit = function(){
        var DOM = feluletVezerlo.getDOMelemek();
        document.querySelector(DOM.inputGomb).addEventListener('click', veztetelHozzaadas);
    }

    var veztetelHozzaadas = function(){
        //1. Bevitt adatok megszerzése
        var input = feluletVezerlo.getInput();
        console.log('input')

        //2. Adatok átadása a koltsegVezerlp modulnak

        //3. Megjelenítés user UI-n

        //4. Költségvetés újraszámolása

        // Összeg megjelenítése a felületen
        console.log("Működik");
    }
    return{
        init: function(){
            console.log("Az alkalmazás fut");
            esemenykezeloBeallit();
        }
    }
    document.querySelector('.hozzaad__gomb').addEventListener('click', veztetelHozzaadas);
    
    document.addEventListener('keydown', function(event){
        if(event.key != undefined && event.key === 'Enter'){
            veztetelHozzaadas();
        }

        else if (event.keyCode !== undefined && event.keyCode === 13){
            veztetelHozzaadas();
        }
    });

})(koltsegvetesVezerlo, feluletVezerlo);

vezerlo.init();