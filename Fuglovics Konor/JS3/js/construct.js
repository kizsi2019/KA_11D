//Simple data types and objects
var x = 10;
var y = x;
x = 100;
console.log(x);
console.log(y);

var o1 = {
    w: 100,
    h: 200
};
var o2 = o1;
o1.w = 150;
console.log(o1);
console.log(o2);

var a = 10;
var o = {
    name: 'Ödön',
    age: 35
};
function modify(a, b){
    a = 40;
    b.name = 'Lajos'
};
modify(a, o);
console.log(a);
console.log(o.name);
