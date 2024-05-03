//Strings in ES6

let firstname = "Teszt";
let lastname = "Elek";
const yearobirth = 1970;

function AgeCalculate(age)
{
    return 2024 - age;
}

//ES5

console.log(firstname + " " + lastname + ", született " + yearobirth + "-ben. Most " + AgeCalculate(yearobirth) + " éves.");

//ES6

console.log(`${firstname} ${lastname}, született ${yearobirth}-ben. Most ${AgeCalculate(yearobirth)} éves. `);

const name = `${firstname} ${lastname}`;
console.log(name.startsWith("T"));
console.log(name.endsWith("ek"));
console.log(name.includes("eke"));
console.log(firstname.repeat(3));
console.log(`${firstname}`.repeat(3));