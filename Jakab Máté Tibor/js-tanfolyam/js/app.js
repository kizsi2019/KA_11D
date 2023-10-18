/*
Játék szabályok:

- A játék 2 szereplős és körökre osztott
- Minden egyes körben az adott játékos dob a kockával, ahányszor csak szeretne. A dobások eredménye hozzáadódik a játékos adott körben
  elért pontszámához, ami értelem szerűen minden körben nulláról indul.
- Ha az aktuális játékos 1-et dob, akkor az összes addigi pontja elveszik, és átadja a dobás jogát a következő játékosnak.
- A játékos választhatja a 'Megtartom' gombot is. Ebben az esetben az adott körben elért pontok száma, hozzáadódik a játékos összes
  pontszámához. Majd a dobás joga a másik játékosra száll.
- Az a játékos nyer, aki előbb eléri a 100 pontot.  

*/
/*var pontszam1 = 0;
var pontszam2 = 0;*/

var pontszamok, korPontszam, aktivJatekos, kocka;

pontszamok = [0,0];
korPontszam = 0;
aktivJatekos = 0;

kocka = Math.floor(Math.random() * 6) + 1;

document.querySelector('.dice').stlye.display = 'none';

document.querySelector('.brn-roll').addEventListener('click', function(){

  var kocka = Math.floor (Math.random() * 6) + 1;

  document.querySelector('.dice').stlye.display = 'block';

  var kockaDOM = document.querySelector('.dice');
  kockaDOM.stlye.display = 'block';
  kockaDOM.src = 'img/dice-' + kocka + '.png';

});