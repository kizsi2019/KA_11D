//Budget manager
var budget_manager = (function(){
    var Outcome = function(id, desc, value){
        this.desc = desc;
        this.id = id;
        this.value = value;
    }
    var Income = function(id, desc, value){
        this.desc = desc;
        this.id = id;
        this.value = value;
    }
    var data = {
        items: {
            out: [{id: 0}],
            in: [{id: 0}]
        },
        totals: {
            out: 0,
            in: 0
        },

    }
    return {
        ItemAdd: function(typ, desc, value) {
            var NewItem, ID;
            ID = 0;

            if (data.items[typ] !== undefined && data.items[typ].length > 0) {
                ID = data.items[typ][data.items[typ].length - 1].id + 1;
            }else{
                ID = 0;
            }

            if (typ === "bev")
            {
                NewItem = new Income(ID, desc, value);
            }else if (typ === "kia")
            {
                NewItem = new Outcome(ID, desc, value);
            }
            //Add the new item to the data structure
            if (data.items[typ] !== undefined)
            {
                data.items[typ].push(NewItem);
            }
            //Return the new item
            return NewItem;
        },
        test: function()
        {
            console.log(data);
        }
    }
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
    var EventManagerSet = function(){
        var DOM = surface_manager.getDOMelement();
        document.querySelector(DOM.inputButton).addEventListener('click', ManItemAdd);
    }

    document.addEventListener('keydown', function(event){
        if (event.key !== undefined && event.key === "Enter")
        {
            ManItemAdd();
            console.log(event);
        }
        else if (event.keyCode !== undefined && event.keyCode === 13) //Deprecated
        {
            ManItemAdd();
            console.log(event);
        }
    })
    var ManItemAdd = function(){
        // 1 - Capturing imported data
        var input = surface_manager.getInput();
    
        // 2 - Giving the data to the budget manager module
        NewItem = budget_manager.ItemAdd(input.type, input.description, input.value);

        // 3 - Appearance in UI

        // 4 - Re-calculating the budget

        // 5 - Total amount on the interface
    }
    return {
        init: function(){
            console.log("Working!");
            EventManagerSet();
        }
    }

})(budget_manager, surface_manager);
manager.init();
