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
            }else
            {
                throw new Error("Invalid: ${tip}");
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
        inputButton: '.hozzaad__gomb',
        incomeStorage: '.bevetelek__lista',
        outcomeStorage: '.kiadasok__lista'
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
        },
        itemDisplay: function(obj, type){
            var html, newHtml, element;

            //Creating HTML strings with placeholder values
            if (type === 'bev')
            {
                element = DOMelement.incomeStorage;
                html = '<div class="tetel clearfix" id="bevetelek-%id%"><div class="tetel__leiras">%desc%</div><div class="right clearfix"><div class="tetel__ertek">%value%</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>';
            }else if (type === 'kia')
            {
                element = DOMelement.outcomeStorage;
                html = '<div class="tetel clearfix" id="expense-%id%"><div class="tetel__leiras">%desc%</div><div class="right clearfix"><div class="tetel__ertek">%value%</div><div class="tetel__szazalek">21%</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>'
            }

            //Replacing the HTML placeholder strings
            newHtml = html.replace('%id%', obj.id);
            newHtml = newHtml.replace('%desc%', obj.desc);
            newHtml = newHtml.replace('%value%', obj.value);

            //Inserting the HTML into DOM
            document.querySelector(element).insertAdjacentHTML('beforeend', newHtml);
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
        surface_manager.itemDisplay(NewItem, input.type);

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
