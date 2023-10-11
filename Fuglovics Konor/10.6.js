var huba = {
    name: "Huba",
    age: 38,
    hobby: 'leader',
    married: true,
    friends: ['Álmos', 'Előd', 'Ond'],
    'family status': 'has wife'
};

console.log(huba.hobby);
console.log(huba['name']);

var h = 'married';
console.log(huba[h]);

console.log(huba['family status']);

huba['age'] = 40;
huba.hobby = 'ács';

console.log(huba);

var tas = new Object();

tas.name = 'Tas';
tas.age = '32';
tas['hobby'] = 'leader';
console.log(tas);

var huba = {
    name: "Huba",
    age: 40,
    hobby: 'leader',
    married: true,
    friends: ['Álmos', 'Előd', 'Ond'],
    'family status': 'has wife',
    DateOfBirth: function() {
        this.YearOfBirth = 2023 - this.age;
    }
}

huba.DateOfBirth();

console.log(huba);

for (var i = 20; i >= 1; i--) {
    console.log(i);
}

var tomb = ['Ond', 38, 'vezér', true, 1990];

for (var i = 0; i < tomb.length; i++) {
    console.log(tomb[i]);
}

var i = 0;
while (i < tomb.length) {
    console.log(tomb[i]);
}

for (var i = 0; i < tomb.length; i++) {
    if (typeof(tomb[i]) === 'boolean') {
        break;
    }
    console.log(tomb[i]);
}