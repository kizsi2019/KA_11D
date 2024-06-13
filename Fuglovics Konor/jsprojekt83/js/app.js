/*const second = () => 
{
    console.log('második');
}
const first = () =>
{
    console.log('első');
    second();
    console.log('harmadik');
}
first();*/

const second = () =>
{
    setTimeout(() =>
    {
        console.log('Asynchronous second')
    }, 6000);
}
const first = () =>
{
    console.log('first');
    second();
    console.log('third');
}
first();