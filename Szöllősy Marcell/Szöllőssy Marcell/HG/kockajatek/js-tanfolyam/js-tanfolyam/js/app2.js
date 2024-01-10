/*
Játék szabályok:

-v2


*/

var pontszamok, korPontszam, aktivJatekos, jatekFolyamatban;

init();

document.querySelector('.btn-roll').addEventListener('click', function(){

  if (jatekFolyamatban ) {

      // véletlen  szám
  var kocka1 = Math.floor(Math.random() * 6) + 1;
  var kocka2 = Math.floor(Math.random() * 6) + 1;

  //eredmény megjelenítés

  document.getElementById('dice-1').src = 'img/dice-' + kocka1  + '.png';
  document.getElementById('dice-1').src = 'img/dice-' + kocka2  + '.png';
 
    kockaKiBekapcsolas('be');

    if (kocka1 !== 1 && kocka2 !== 2) { // körben elért szám hozzáadása az aktuális ponthoz
   
      korPontszam += kocka1 + kocka2;
    document.querySelector('#current-' + aktivJatekos).textContent = korPontszam;

  } else {
    // következő játékos
  kovetkezoJatekos();
  }


  /*  if (kocka === 6 && elozoDobas === 6) {
      // A játékos elveszíti az összes pontszámát
      pontszamok[aktivJatekos] = 0;

        // összes pontszám frissítése a felületen (UI)
        document.querySelector('#score-' + aktivJatekos).textContent = 0;

        // következő játékos
        kovetkezoJatekos();

    } else if (kocka !== 1) { // körben elért szám hozzáadása az aktuális ponthoz
   
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

      //hamis: 0, "", null, undefined
      // igaz: minden más egyéb
    //  if (!elerendoPontszam || isNaN(elerendoPontszam)) {
    //    elerendoPontszam = 15;
    //  }

      if (elerendoPontszam && !isNaN(elerendoPontszam)){
        elerendoPontszam = elerendoPontszam;
      } else {
        elerendoPontszam = 15;
      }
      console.log(elerendoPontszam)

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

 kockaKiBekapcsolas('ki');
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

  kockaKiBekapcsolas('ki');
  document.querySelector('.dice').style.display = 'none';
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

function kockaKiBekapcsolas(funkcio) {
  // funkcio 'ki', 'be'

  if (funkcio === 'ki') {
    document.getElementById('dice-1').style.display = 'none';
    document.getElementById('dice-2').style.display = 'none';
  } else if (funkcio === 'be') {
    document.getElementById('dice-1').style.display = 'block';
    document.getElementById('dice-2').style.display = 'block';
  }
}