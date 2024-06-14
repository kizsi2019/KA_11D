function Szemely(nev) {
    this.nev = nev;
}

var haverok = ['Jóska', 'Pista', 'Ödön'];

/*
Szemely.prototype.barataimES5 = function(haverok) {
    var obj = this;
    var tomb = haverok.map(function(elem) 
    {
        return obj.nev + ' barátja ' + elem + '.'
    });
    console.log(tomb);
}


new Szemely('Géza').barataimES5(haverok);
*/

Szemely.prototype.barataimES6 = function(haverok) {
    const tomb = haverok.map(elem => `${this.nev} barátja ${elem}`);
    console.log(tomb);
}

new Szemely('Géza').barataimES6(haverok);