// költséges vezérlő
var koltsegvetesVezerlo = (function(koltsegvetesVez,feluletVez) {
    var Kiadas = function(id, leiras, ertek) {
        this.leiras = leiras;
        this.id = id;
        this.ertek = ertek;
    }
    var Bevetel = function(id, leiras, ertek) {
        this.leiras = leiras;
        this.id = id;
        this.ertek = ertek;

    var adat = {
        tetelek: {
            kia: [],
            bev: []
        },
        osszegek: {
            kia: 0,
            bev: 0,
        }
},

}();

// Felület vezérlő
var feluletVezerlo = (function() {
    var DOMelemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb',
    }

    return {
        getinput:function() {
            return {
                tipus: document.querySelector(DOMelemek.inputTipus).value,
                leiras: document.querySelector(DOMelemek.inputLeiras).value,
                ertek: document.querySelector(DOMelemek.inputErtek).value,
            }
        },
        getDOMelemek: function() {
            return DOMelemek;
        }
    }
})

// Alkalmazás vezélrő
var vezerlo = (function(koltsegvetesVez, feluletVez){

    var vezTetelHozzaadas = function(){
        // 1. Bevitt adatok megszerzése

        // 2. Adatok átadása a koltsegVezerlo modulnak

        // 3. Megjelenítés UI-n

        // 4. Költségvetés Újraszámolása

        // 5. Összeg megjelnítése a felületen
        console.log('működik')
    }
    document.querySelector('.hozzaad__gomb').addEventListener('click', vezTetelHozzaadas);

    document.addEventListener('keydown', function(event) {
        if (event.key !== undefined && event.key === 'Enter') {
            vezTetelHozzaadas();
            console.log(event);
        }
        else if (event.keyCode !== undefined && event.keyCode === 13) {
            vezTetelHozzaadas();
        }
    });

    
})(koltsegvetesVezerlo, feluletVezerlo);

