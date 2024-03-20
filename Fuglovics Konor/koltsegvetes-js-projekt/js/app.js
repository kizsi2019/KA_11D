//Költségvetés vezérlő
var budget_manager = (function(){

})();
//Surface manager
var surface_manager = (function(){

})();
//App manager
var manager = (function(BudgetMan, SurfMan){
    var ManTitleAdd = function(){
        // 1 - Capturing imported data

        // 2 - Giving the data to the budget manager module

        // 3 - Appearance in UI

        // 4 - Re-calculating the budget

        // 5 - Total amount on the interface
        console.log("It works!")
    }
    document.querySelector('.hozzaad__gomb').addEventListener('click', ManTitleAdd);
    document.addEventListener('keydown', function(event){
        if (event.key !== undefined && event.key === "Enter")
        {
            ManTitleAdd();
            console.log(event);
        }
        /*if (event.keyCode === 13 && event.which === 13) //Deprecated
        {
            ManTitleAdd();
            console.log(event);
        }*/
    })
})(budget_manager, surface_manager);
