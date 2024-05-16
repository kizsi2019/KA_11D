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