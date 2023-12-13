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

var pontszamok, korPontszam, aktivJatekos, jatekFolyamatban, elozoDobas;

init();

document.querySelector('.btn-roll').addEventListener('click', function(){

  if (jatekFolyamatban ) {

      // véletlen  szám
  var kocka1 = Math.floor(Math.random() * 6) + 1;
  var kocka2 = Math.floor(Math.random() * 6) + 1;

  //eredmény megjelenítés
  
  document.getElementById('dice-1').src = 'img/dice-' + kocka1 + '.png';
  document.getElementById('dice-2').src = 'img/dice-' + kocka2 + '.png';
  
  kockaKiBeKapcsolas('be');   

  if (kocka1 !== 1 && kocka2 !== 1) {
    // szám hozzáadása az aktuális ponthoz
    korPontszam += kocka1 + kocka2;
    document.querySelector('#current-' + aktivJatekos).textContent = korPontszam;

  } else {
    // következő játékos
  kovetkezoJatekos();
  }


  /*
  if (kocka === 6 && elozoDobas === 6) {
    pontszamok[aktivJatekos] = 0;

    document.querySelector('#score ' + aktivJatekos).textContent = 0;

    kovetkezoJatekos();
  } 
  //pontszám frissítés ha nem 1et dobunk
  else if (kocka !== 1) {
    // szám hozzáadása az aktuális ponthoz
    korPontszam += kocka;
    document.querySelector('#current-' + aktivJatekos).textContent = kocka;

  } else {
    // következő játékos
  kovetkezoJatekos();
  }
  elozoDobas = kocka; */
}
});


// megtartom a GOMB esemény kezelője
document.querySelector('.btn-hold').addEventListener('click', function() {


    if (jatekFolyamatban) {

        // összes pontszám frissítése a kódban
  pontszamok[aktivJatekos] += korPontszam;

  // összes pontszám frissítése a felületen (UI)
  document.querySelector('#score-' + aktivJatekos).textContent = pontszamok[aktivJatekos];

  var elerendoPontszam = document.querySelector('.elerendo-pontszam').value;
  console.log(elerendoPontszam);

  //if (!elerendoPontszam || isNaN(elerendoPontszam)) {
  //  elerendoPontszam = 15;
  //}
  

  if (elerendoPontszam && !isNaN(elerendoPontszam)) {
    elerendoPontszam = elerendoPontszam;
  } else {
    elerendoPontszam = 15;
  }
  console.log(elerendoPontszam);


  //nyert a játékos?
  if(pontszamok[aktivJatekos] >= elerendoPontszam) {
    document.querySelector('#name-' + aktivJatekos).textContent = 'Győztes!';
    document.querySelector('.player-' + aktivJatekos + '-panel').classList.add('winner');    
    document.querySelector('.player-' + aktivJatekos + '-panel').classList.remove('active');
    jatekFolyamatban = false;
  } else {
    //következő játékos
    kovetkezoJatekos();
  }

  //követező játékps
  kovetkezoJatekos();
    }
}
);

// következő játékos
function kovetkezoJatekos() {
  aktivJatekos === 0 ? aktivJatekos = 1 : aktivJatekos = 0;
  korPontszam = 0;

  document.getElementById('current-0').textContent = '0';
  document.getElementById('current-1').textContent = '0';

  document.querySelector('.player-0-panel').classList.toggle('active');
  document.querySelector('.player-1-panel').classList.toggle('active');

  kockaKiBeKapcsolas('ki');
}

// új játék indítása
document.querySelector('.btn-new').addEventListener('click', init);

//init
function init() {
  pontszamok = [0 ,0];
  aktivJatekos = 0;
  korPontszam = 0;
  jatekFolyamatban = true;
  elozoDobas = 0;


  kockaKiBeKapcsolas('ki');
  document.getElementById('score-0').textContent = '0';
  document.getElementById('current-0').textContent = '0';
  document.getElementById('score-1').textContent = '0';
  document.getElementById('current-0').textContent = '0';


  document.querySelector('#name-0').textContent = 'Frodó';
  document.querySelector('#name-1').textContent = 'Samu';

  document.querySelector('.player-0-panel').classList.remove('winner');
  document.querySelector('.player-1-panel').classList.remove('winner');
  document.querySelector('.player-0-panel').classList.remove('active');
  document.querySelector('.player-1-panel').classList.remove('active');
  document.querySelector('.player-0-panel').classList.add('active');
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