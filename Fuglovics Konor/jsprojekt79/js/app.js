//Map

const question = new Map();
question.set('question',"What's the name of the 'But Whyyyy?' kid from an ad?");
question.set(1, "Ábel");
question.set(2, "Áron");
question.set(3, "Kábel");
question.set(4, "Ödön");
question.set('correct', 1);
question.set(true, 'Correct!');
question.set(false, 'Incorrect!');
console.log(question.get('question'));
//question.delete(3);
/*if (question.has(3))
{
    question.delete(3);
}*/
//question.clear();
/*question.forEach((key, value) => console.log(`Key: ${key}, Value: ${value}`));
for(let [key, value] of question.entries())
{
    if (typeof(key) === 'number')
    {
        console.log(`Key: ${key}, Value: ${value}`);
    }
}*/
console.log(question.get(1));
console.log(question.get(2));
console.log(question.get(3));
console.log(question.get(4));
const answer = parseInt(prompt("Insert the correct answer"));
console.log(question.get(answer === question.get('correct')));