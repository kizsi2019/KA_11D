//Blocks and IIFE
//Script Version: ES6

{
    const a = 1;
    let b = 2;
    var c = 3;
}
console.log(a + b);

//ES5
(function()
{
    let c = 3;
    console.log(c);
})();