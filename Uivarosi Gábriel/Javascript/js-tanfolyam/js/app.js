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

var Pontszamok, Korponszam, aktívjátékos, Kocka;
/*
 /[]\
/|[]|\
 \[]/
*/
Pontszamok  = [0,0];
Korponszam = 0;
aktívjátékos = 0;


document.querySelector('#current-' + aktívjátékos).textContent = Kocka

document.querySelector('.dice').style.display = 'none';
document.getElementById('score-0').textContent = '0';
document.getElementById('score-1').textContent = '0';
document.getElementById('current-0').textContent = '0';
document.getElementById('current-1').textContent = '0';


document.querySelector('.btn-roll').addEventListener('click', function(){
  Kocka = Math.floor(Math.random() * 6) + 1;
  var kockaDOM = document.querySelector('.dice');
  kockaDOM.style.display = 'block';
  kockaDOM.src = 'img/dice-' + Kocka + ".png";
 if (Kocka != 1) {
 Korponszam += Kocka
 document.querySelector('#current-' +aktívjátékos).textContent = Korponszam

 } else {
   aktívjátékos === 0 ? aktívjátékos = 1 : aktívjátékos = 0;
   
 }
})
