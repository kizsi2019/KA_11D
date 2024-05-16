//Blocks
const boxes = document.querySelectorAll('.rectangle');
//ES5
/*var boxesBlockES5 = Array.prototype.slice.call(boxes)
boxesBlockES5.forEach(function(actual)
{
    actual.style.backgroundColor = 'orange';
});*/

//ES6
const boxesBlockES6 = Array.from(boxes);
boxesBlockES6.forEach(actual => actual.style.backgroundColor = 'orange');

//ES5
/*for (var i = 0; i < boxesBlockES5.length; i++)
{
    if (boxesBlockES5[i].ClassName === 'rectangle blue')
    {
        continue;
    }
    boxesBlockES5[i].textContent = 'Kék lettem!';
}*/

//ES6
for(const actual of boxesBlockES6)
{
    if(actual.className === 'rectangle blue')
    {
        continue;
    }
    actual.textContent = 'Kék lettem!';
}


//ES5
var ages = [1, 12, 23, 67, 35]

console.log(ages);

var adults = ages.map(function(actual)
{
    return actual >= 18;
});

console.log(adults);

console.log(adults.indexOf(true));

//ES6
console.log(ages.findIndex(actual => actual >= 18));
console.log(ages.find(actual => actual >= 18));