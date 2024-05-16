//Spread operator
const boxes = document.querySelectorAll('.rectangle');
function numbers(a, b, c, d)
{
    return a+b+c+d;
}
var total = numbers(1, 2, 3, 4);
console.log(total);

//ES5
var numbersBlock = [1, 2, 3, 4];
var total2 = numbers.apply(null, numbersBlock);
console.log(total2);

//ES6
const total3 = numbers(...numbersBlock);
console.log(total3);
const t2 = [5, 6, 7, 8, 9, 10];
const t3 = [...numbersBlock, ...t2];
console.log(t3);
const title = document.querySelector('h1');
const htmlElements = [title, ...boxes];
Array.from(htmlElements).forEach(actualElement => actualElement.style.color = 'purple'); 