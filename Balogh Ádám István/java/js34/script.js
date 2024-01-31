var x = 10;
var y = x;
x = 100;
console.log(x)
console.log(y)


var o1 = {
    sz: 100,
    m: 200
};

var o2 = o1;
o1.sz = 150;
console.log(o1.sz);
console.log(o2.sz);

var a = 10;
var o = {
    nev: 'Ödön',
    kor: 35
};

function modosit(a, b) {
    a = 40;
    b.nev = 'Lajos';
};

modosit(a, o);

console.log(a);
console.log(o.nev);