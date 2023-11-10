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

// változók létrehozása és adatainak megadása
var pontszamok, korpontszam, aktivjatekos, kocka;

init();



//document.querySelector('#current-' + aktivjatekos).textContent = kocka;

//var nev = document.querySelector('#name-1').textContent;


document.querySelector('.btn-roll').addEventListener('click', function()
{
  //
  var kocka = Math.floor(Math.random() * 6) + 1;


  //
  var kockadom = document.querySelector('.dice');

  //
  kockadom.style.display = 'block';
  kockadom.src = 'img/dice-' + kocka + '.png';
  
  //ha a dobásunk nem 1
  if (kocka !==1){
    //dobásunkat hozza ádjuk az aktív játékos pontjaihoz
    korpontszam += kocka;
    document.querySelector('#current-' + aktivjatekos).textContent = korpontszam;
  } 
  //ha viszont 1 akkor ezt csinálja
  else {
    //
    Kovetekzojatekos();
  }
});

//megtartjuk a dobást
document.querySelector('.btn-hold').addEventListener('click', function() {

  //
  pontszamok[aktivjatekos] += korpontszam;

  //
  document.querySelector('#score-' + aktivjatekos).textContent = pontszamok[aktivjatekos];

  //
  if (pontszamok[aktivjatekos] >= 30) {
    document.querySelector('#name-' + aktivjatekos).textContent = "Győztes!";
    document.querySelector('.player-' + aktivjatekos + '-panel').classList.add('winner')
    document.querySelector('.player-' + aktivjatekos + '-panel').classList.remove('active')
  }
  else {
    //
  Kovetekzojatekos();
  }

  
  
});

//
function Kovetekzojatekos() {
  aktivjatekos === 0 ? aktivjatekos = 1 : aktivjatekos = 0;
  korpontszam = 0;

  document.getElementById('current-0').textContent = '0';
  document.getElementById('current-1').textContent = '1';

  document.querySelector('.player-0-panel').classList.toggle('active');
  document.querySelector('.player-1-panel').classList.toggle('active');

  document.querySelector('.dice').style.display = 'none';
}

document.querySelector('.btn-new').addEventListener('click', init);

function init()
{
  pontszamok = [0,0];
  aktivjatekos = 0;
  korpontszam = 0;

  document.querySelector('.dice').style.display = 'none';
document.getElementById('score-0').textContent = '0';
document.getElementById('score-1').textContent = '0';
document.getElementById('current-0').textContent = '0';
document.getElementById('current-1').textContent = '0';

document.querySelector('name-0').textContent = "Frodó"
document.querySelector('name-1').textContent = "Samu"
document.querySelector('.player-0-panel').classList.remove('winner');
document.querySelector('.player-1-panel').classList.remove('winner');
document.querySelector('.player-0-panel').classList.remove('active');
document.querySelector('.player-1-panel').classList.add('active');

}