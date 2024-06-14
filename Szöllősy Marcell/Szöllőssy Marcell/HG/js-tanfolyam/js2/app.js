/*
Játék szabályok:

- A játék 2 szereplős és körökre osztott
- Minden egyes körben az adott játékos dob kettő kockával, ahányszor csak szeretne. A dobások eredménye hozzáadódik a játékos adott körben
  elért pontszámához, ami értelem szerűen minden körben nulláról indul.
- Ha az aktuális játékos 1-et dob, akkor az összes addigi pontja elveszik, és átadja a dobás jogát a következő játékosnak.
- A játékos választhatja a 'Megtartom' gombot is. Ebben az esetben az adott körben elért pontok száma, hozzáadódik a játékos összes
  pontszámához. Majd a dobás joga a másik játékosra száll.
-Ha egy játékos kétszer hatost dob egymás után akkor ugyanaz mint ha egyest dobna az ember
- Az a játékos nyer, aki előbb eléri a 100 pontot.  

*/

// változók létrehozása és adatainak megadása
var pontszamok, korpontszam, aktivjatekos, jatekFolyamatban;

init();


document.querySelector('.btn-roll').addEventListener('click', function()
{
  //
  if (jatekFolyamatban) 
  {
    //
    var kocka1 = Math.floor(Math.random() * 6) + 1;
    var kocka2 = Math.floor(Math.random() * 6) + 1;

    //
    document.getElementById('dice-1').src = '../img/dice-' + kocka1 + '.png';
    document.getElementById('dice-2').src = '../img/dice-' + kocka2 + '.png';
    kockaKiBeKapcsolas('be');

    if (kocka1 !==1 && kocka2 !== 2){
      //dobásunkat hozza ádjuk az aktív játékos pontjaihoz
      korpontszam += kocka1 + kocka2;
      document.querySelector('#current-' + aktivjatekos).textContent = korpontszam;
    } 
    //ha viszont 1 akkor ezt csinálja
    else {
      //
      Kovetekzojatekos();
    }
  
    /*
    if (kocka == 6 && elezoDobas == 6) {
      pontszamok[aktivjatekos] = 0;
      document.querySelector('#score' + aktivjatekos).textContent = 0
      Kovetekzojatekos();
    }
    else if (kocka !==1){
      //dobásunkat hozza ádjuk az aktív játékos pontjaihoz
      korpontszam += kocka;
      document.querySelector('#current-' + aktivjatekos).textContent = korpontszam;
    } 
    //ha viszont 1 akkor ezt csinálja
    else {
      //
      Kovetekzojatekos();
    }

    elezoDobas = kocka
    */
  }
});

//megtartjuk a dobást
document.querySelector('.btn-hold').addEventListener('click', function() {
  if (jatekFolyamatban) {
    //
    pontszamok[aktivjatekos] += korpontszam;

    //
    document.querySelector('#score-' + aktivjatekos).textContent = pontszamok[aktivjatekos];

    var elerendopont = document.querySelector('.elerendo').value;
    
    if (elerendopont && !isNaN(elerendopont)) {
      elerendopont = elerendopont;
    }
    else {
      elerendopont = 15;
    }

    console.log(elerendopont)

    //
    if (pontszamok[aktivjatekos] >= elerendopont) {
      document.querySelector('#name-' + aktivjatekos).textContent = "Győztes!";
      document.querySelector('.player-' + aktivjatekos + '-panel').classList.add('winner')
      document.querySelector('.player-' + aktivjatekos + '-panel').classList.remove('active')
      jatekFolyamatban = false;
    }
    else {
      //
    Kovetekzojatekos();
    }
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

  kockaKiBeKapcsolas('ki');
}

document.querySelector('.btn-new').addEventListener('click', init);

function init()
{
  pontszamok = [0,0];
  aktivjatekos = 0;
  korpontszam = 0;
  jatekFolyamatban = true;

  kockaKiBeKapcsolas('ki');
  document.getElementById('score-0').textContent = '0';
  document.getElementById('score-1').textContent = '0';
  document.getElementById('current-0').textContent = '0';
  document.getElementById('current-1').textContent = '0';

  document.getElementById('name-0').textContent = "Frodó";
  document.getElementById('name-1').textContent = "Samu";
  document.querySelector('.player-0-panel').classList.remove('winner');
  document.querySelector('.player-1-panel').classList.remove('winner');
  document.querySelector('.player-0-panel').classList.remove('active');
  document.querySelector('.player-1-panel').classList.add('active');
}

function kockaKiBeKapcsolas(funkcio) {
  if (funkcio === 'ki') {
    document.getElementById('dice-1').style.display = 'none';
    document.getElementById('dice-2').style.display = 'none';
  } else if (funkcio === 'be') {
    document.getElementById('dice-1').style.display = 'block';
    document.getElementById('dice-2').style.display = 'block';
  }
}