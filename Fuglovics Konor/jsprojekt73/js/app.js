//Arrow functions

/*const years = [1973, 1980, 1985, 1999, 2016];

var agesES5 = years.map(function(element)
{
    return 2024 - element;
});

console.log(agesES5);

//ES6

let agesES6 = years.map(element => 2024 - element);

console.log(agesES6);

agesES6 = years.map((element, index) => `Kor ${index}: ${2024 - element}.`)

console.log(agesES6);

agesES6 = years.map((element, index) =>
{
    const actualyear = new Date().getFullYear();
    const age = actualyear - element;
    return `Kor ${index}: ${age},`;
});

console.log(agesES6);*/ 

var boxES5 = 
{
    color: 'zöld',
    position: 1,
    clickMe: function()
    {
       // console.log(this.color);
        document.querySelector('.green').addEventListener("click", function()
        {
            var text = `Én vagyok a(z) ${this.position}. doboz és a színem ${this.color}.`;
            alert(text);
        })
    }
};