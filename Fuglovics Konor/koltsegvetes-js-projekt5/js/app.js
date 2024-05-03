//Budget manager
var budget_manager = (function(){
    var Outcome = function(id, desc, value){
        this.desc = desc;
        this.id = id;
        this.value = parseInt(value);
    }
    var Income = function(id, desc, value){
        this.desc = desc;
        this.id = id;
        this.value = ParseInt(value);
    }
    var CalculateTotal = function(typ)
    {
        var total = 0;
        if (data.items[typ] !== undefined && data.items[typ].length > 0)
        {
            data.items[typ].forEach(function(currentValue)
            {
                if (!isNaN(currentValue.value))
                {
                    total += currentValue.value;
                }
            });
            data.totals[typ] = total;
        }
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
        budget: 0,
        percent: -1
    }
    return {
        ItemAdd: function(typ, desc, value) {
            var NewItem, ID;
            

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
                throw new Error("Invalid: ${typ}");
            }
            //Add the new item to the data structure
            if (data.items[typ] !== undefined)
            {
                data.items[typ].push(NewItem);
            }
            //Return the new item
            return NewItem;
        },
        TitleDelete: function(typ, id)
        {
            var IdBlock, index;

            if (data.items && data.items[typ])
            {
                IdBlock = data.items[typ].map(function(actual)
                {
                    return actual.id;
                });
                index = IdBlock.indexOf(id);

                if (index !== -1)
                {
                    data.items[typ].splice(index, 1);
                }
            }
            else
            {
                console.error("The title's object or type key doesn't exist.");
            }
        },
        BudgetCalculate: function()
        {
            // 1 - Calculate the total of income and outcome
            CalculateTotal('bev');
            CalculateTotal('kia');

            // 2 - Calculating the budget: income - outcomes
            data.budget = data.totals.in - data.totals.out;

            // 3 - Calculating the percent: outcomes / income * 100
            if (data.totals.in > 0)
            {
                data.percent = Math.round((data.totals.out / data.totals.in) * 100);
            }else
            {
                data.percent = -1;
            }
        },
        GetBudget: function()
        {
            return {
                total: data.budget,
                in: data.totals.in,
                out: data.totals.out,
                percent: data.percent
            }
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
        outcomeStorage: '.kiadasok__lista',
        budgetTag: '.koltsegvetes__ertek',
        totalincomeTag: '.koltsegvetes__bevetelek--ertek',
        totaloutcomeTag: '.koltsegvetes__kiadasok--ertek',
        percentTag: '.koltsegvetes__kiadasok--szazalek',
        container: '.kontener'
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
        },
        TitleDeleting: function(titleID)
        {
            var element = document.getElementById(titleID);
            element.parentNode.removeChild(element);
        },
        DeleteForm: function()
        {
            var areas, areasBlock;
            areas = document.querySelectorAll(DOMelement.inputDescription + "," + DOMelement.inputValue);
            areasBlock = Array.prototype.slice.call(areas);
            areasBlock.forEach(function(currentValue, index, array)
            {
                currentValue.value = '';
            });
            areasBlock[0].focus();
        },
        DisplayBudget: function(obj)
        {
            document.querySelector(DOMelement.budgetTag).textContent = obj.total;
            document.querySelector(DOMelement.totalincomeTag).textContent = obj.in;
            document.querySelector(DOMelement.totaloutcomeTag).textContent = obj.out;
            if (obj.percent > 0)
            {
                document.querySelector(DOMelement.percentTag).textContent = obj.percent + "%";
            }else
            {
                document.querySelector(DOMelement.percentTag).textContent = "-";
            }
        }
    }
})();
//App manager
var manager = (function(BudgetMan, SurfMan){
    var EventManagerSet = function(){
        var DOM = surface_manager.getDOMelement();
        document.querySelector(DOM.inputButton).addEventListener('click', ManItemAdd);
    }

    var TotalRefresh = function()
    {
        // 1 - Re-calculating the budget
        budget_manager.BudgetCalculate();

        // 2 - Giving back the total
        var budget = budget_manager.GetBudget();

        console.log("Költség: ", budget);

        // 3 - Total amount on the interface
        surface_manager.DisplayBudget(budget);
        console.log(budget);
    }

    document.addEventListener('keydown', function(event){
        if (event.key !== undefined && event.key === "Enter")
        {
            ManItemAdd();
        }
        else if (event.keyCode !== undefined && event.keyCode === 13) //Deprecated
        {
            ManItemAdd();
        }
    })
    var ManItemAdd = function(){
        // 1 - Capturing imported data
        console.log("ManItemAdd function called");
        var input, NewItem;

        input = surface_manager.getInput();
        if (input.description !== '' && !isNaN(input.value) && input.value > 0)
        {
            // 2 - Giving the data to the budget manager module
            NewItem = budget_manager.ItemAdd(input.type, input.description, input.value);

            // 3 - Appearance in UI
            surface_manager.itemDisplay(NewItem, input.type);

            // 4 - Deleting the areas
            SurfMan.DeleteForm();

            // 5 - Re-calculating and refreshing the budget on the interface
            TotalRefresh();
        }
    };
    var ManItemDelete = function(event)
    {
        var titleID, splitId, typ, ID

        titleID = event.target.parentNode.parentNode.parentNode.parentNode.id;

        if (titleID)
        {
            splitId = titleID.split('-');
            typ = splitID[0];
            ID = parseInt(splitID[1]);

            budget_manager.TitleDelete(typ.ID);

            surface_manager.TitleDelete
        }
    }
    return {
        init: function(){
            console.log("Working!");
            surface_manager.DisplayBudget(
            {
                total: 0,
                in: 0,
                out: 0,
                percent: -1
            }
            );
            EventManagerSet();
        }
    }

})(budget_manager, surface_manager);
manager.init();
