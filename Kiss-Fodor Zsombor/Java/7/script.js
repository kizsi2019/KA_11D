function teglalap(a, b, funkcio) {
    var eredmeny

    if (funkcio === "terület") {
        eredmeny = (a+ b) * 2;
    } else if (funkcio = "kerület") {
        eredmeny = a * b;
    } else {
        return 'Hibás funkció!'
    }

    return funkcio + ' = ' + eredmeny;
}

console.log(teglalap(5,4, 'kerület'));
console.log(teglalap(5,4, 'terület'));
console.log(teglalap(5,4, 'kurba'));