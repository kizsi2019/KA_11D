// Költségvetés vezérlő
var koltsegvetesVezerlo = (function(){
   

})();
//Felület vezérlő
var feluletVezerlo = (function(){


})();
//Alkalmazás Vezérlő
var vezerlo = (function(koltsegvetesVez, feluletVez){

    var vezTetelHozzaadas = function(){
        //1. Bevitt adatok megszerzése

        //2. Adatok átadása a koltsegVezerlo modulnak

        //3. Megjelenités UI-n

        //4. Költségvetés újraszámolása

        //5. Összeg megjelenítése a felületen
        console.log('működik')
    }
    document.querySelector('.hozzaad__gomb').addEventListener('click', vezTetelHozzaadas);

    document.addEventListener('keydown', function(event) {
        //console.log(event):
        if (event.key !== undefined && event.key === 'Enter') {
            //console.log('enter')
            vezTetelHozzaadas();
        } else if (event.KeyCode !== undefined && event.KeyCode === 13)
            vezTetelHozzaadas();
    })

})(koltsegvetesVezerlo, feluletVezerlo);
