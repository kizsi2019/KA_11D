//
var KoltsegvetesVezerlo = (function() {

})();

//
var feluletVezerlo = (function() {

    var DOMelemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb'
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
        }
    }
})();

//alkamazás vezérlő
var vezerlo = (function(KoltsegvetesVez, feluletVez) {

    var DOM = feluletVezerlo.getDOMelemek();

    var vezTetelHozzadas = function() {
        //bevitt adatok megszerzése
        var input = feluletVezerlo.getInput();
        console.log(input)

        //adatok átadása a koltsegVezerlo modulnak

        //megjelenítés UI-n

        //költségvetés újraszámolása

        //összeg megjelenítése a felületen
        console.log("a")
    }

    document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzadas);
    document.addEventListener('keydown', function(event) {
        if(event.keyCode === 13 || event.which === 13) {
            vezTetelHozzadas();
        }
    })

})(KoltsegvetesVezerlo, feluletVezerlo);