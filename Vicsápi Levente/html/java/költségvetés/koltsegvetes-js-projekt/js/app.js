//költségvetévezérlő
var koltsegvetesVezerlo = (function(){
    
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

    var DOM = feluletVezerlo.getDOMelemek();

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

