//Költségvetés vezérlő
var budget_manager = (function(){

})();
//Surface manager
var surface_manager = (function(){
    var DOMelement = {
        inputType: '.hozzaad__tipus',
        inputDescription: '.hozzaad__leiras',
        inputValue: '.hozzaad__ertek',
        inputButton: '.hozzaad__gomb'
    }
    return {
        getInput: function(){
            return {
                type: document.querySelector(DOMelement.inputType).value,
                description: document.querySelector(DOMelement.inputDescription).value,
                value: document.querySelector(DOMelement.inputValue).value
            }
        },
        getDOMelement: function(){
            return DOMelement;
        }
    }
})();
//App manager
var manager = (function(BudgetMan, SurfMan){
    var DOM = surface_manager.getDOMelement();
    var ManTitleAdd = function(){
        // 1 - Capturing imported data
        var input = surface_manager.getInput();
        console.log(input);

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
        else if (event.keyCode !== undefined && event.keyCode === 13) //Deprecated
        {
            ManTitleAdd();
            console.log(event);
        }
    })
})(budget_manager, surface_manager);
