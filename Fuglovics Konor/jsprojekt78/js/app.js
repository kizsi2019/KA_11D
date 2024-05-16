//Rest parameter
//ES5
function evenOrOddES5()
{
    console.log(arguments);
    var argumentsBlock = Array.prototype.slice.call(arguments);
    console.log(argumentsBlock);
    argumentsBlock.forEach(function(actualElement)
    {
        if(actualElement % 2 === 0)
        {
            console.log('Páros');
        }else
        {
            console.log('Páratlan');
        }
    });
}
evenOrOddES5(1, 2, 3, 4);

//ES6
function evenOrOddES6(...numbers)
{
    console.log(numbers);
    numbers.forEach(actualElement =>
    {
        if(actualElement % 2 === 0)
        {
            console.log('Páros');
        }else
        {
            console.log('Páratlan');
        }
    })
}
evenOrOddES6(1, 2, 3, 4);

function evenOrOddES5(test)
{
    console.log(arguments);
    var argumentsBlock = Array.prototype.slice.call(arguments, 1);
    //console.log(argumentsBlock);
    argumentsBlock.forEach(function(actualElement)
    {
        if(actualElement % 2 === 0)
        {
            console.log('Páros');
        }else
        {
            console.log('Páratlan');
        }
    });
}
evenOrOddES5('teszt', 1, 2, 3, 732, 2689, 0, -3);

function evenOrOddES6(test, ...numbers)
{
    numbers.forEach(actualElement =>
    {
        if(actualElement % 2 === 0)
        {
            console.log('Páros');
        }else
        {
            console.log('Páratlan');
        }
    })
}
evenOrOddES6('test', 1, 2, 3, 4658, 83291, 3.14, 0, -24);

//ES5
function ÁdámCsalád(lastName, yearobirth, familyName)
{
    if(familyName === undefined)
    {
        familyName = 'Adams';
    }else
    {
        familyName = familyName;
    };
    this.lastName = lastName;
    this.yearobirth = yearobirth;
    this.familyName = familyName;
}

var Fester = new ÁdámCsalád('Fester', 1940);
var Mortisha = new ÁdámCsalád('Mortisha', 1965);
var Kuzin = new ÁdámCsalád('Kuzin', 1800, "HogyHivjak");

//ES6
function ÁdámCsalád(lastName, yearobirth, familyName = 'Adams')
{
   this.lastName = lastName;
   this.yearobirth = yearobirth;
   this.familyName = familyName;
}
var Fester = new ÁdámCsalád('Fester', 1940);
var Mortisha = new ÁdámCsalád('Mortisha', 1965);
var Kuzin = new ÁdámCsalád('Kuzin', 1800, "HogyHivjak");