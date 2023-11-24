/*
Játék szabályok:

- Ha egy játékos 2x 6-ost dob egymás után, akkor az összes eddigi pontját elveszíti és a dobás joga a másik játékosra száll
- Adjunk a programhoz egy olyan lehetőséget, hogy a felhasználói felületen meg lehessen adni, hogy a győztesnek hány pontot kelljen elérni.
- Legyen még egy kocka, ha az egyik kockával 1-est dob, akkor veszítse el a körben elért pontszámot.

*/

var pontszamok, korPontszam, aktivJatekos, jatekFolyamatban, elozoDobas;

init();

// pontszamok = [0,0];
// korPontszam = 0;

// aktivJatekos = 0;

// document.querySelector('#current-' + aktivJatekos).textContent = kocka;
// document.querySelector('#current-' + aktivJatekos).textContent = '<us>' + kocka + '</up';


// DOBÁS gomb kezelője
document.querySelector('.btn-roll').addEventListener('click', function(){

  if (jatekFolyamatban) {
    // kell egy véletlen szám
    var kocka1 = Math.floor(Math.random() * 6) + 1;
    var kocka2 = Math.floor(Math.random() * 6) + 1;

    // eredmény megjelenítése
    document.getElementById('dice-1').src = 'img/dice-' + kocka1 + '.png';
    document.getElementById('dice-2').src = 'img/dice-' + kocka2 + '.png';

    kockaKiBeKapcsolas('be');

    if (kocka1 !== 1 && kocka1 !== 2) { // körben elért pontszám frissítése, ha nem 1-et dobunk

      // itt adjuk hozza szamot az aktualis ponthoz
      korPontszam += kocka1 + kocka2;
      document.querySelector('#current-' + aktivJatekos).textContent = korPontszam;
  
    } else {
        // következő jatekos
        kovetkezoJatekos();
      }
/*
    if(kocka === 6 && elozoDobas === 6) {
      // A játékos elveszíti az összes pontszámát
      pontszamok[aktivJatekos] = 0;

      // összes pontszám frissítése a felületen (UI)
      document.querySelector('#score-' + aktivJatekos).textContent = 0;

      // következő jatekos
      kovetkezoJatekos();

    } else if (kocka !== 1) { // körben elért pontszám frissítése, ha nem 1-et dobunk

    // itt adjuk hozza szamot az aktualis ponthoz
    korPontszam += kocka;
    document.querySelector('#current-' + aktivJatekos).textContent = korPontszam;

  } else {
      // következő jatekos
      kovetkezoJatekos();
    }
    elozoDobas = kocka;*/
  }
});

// megtartom gomb eseménykezelője
document.querySelector('.btn-hold').addEventListener('click', function() {

    if (jatekFolyamatban) {
      //összes pontszám frissítése a kódban
      pontszamok[aktivJatekos] += korPontszam;

      // összes pontszám frissítése a felületen (UI)
      document.querySelector('#score-' + aktivJatekos).textContent = pontszamok[aktivJatekos];

      var elerendoPontszam = document.querySelector('.elerendo-pontszam').Value;
      console.log(elerendoPontszam);

      // hamis: 0, "", null, undefined
      // igaz: minden más egyéb
      // if (!elerendoPontszam) || isNaN(elerendoPontszam)) {
      // elerendoPontszam = 15;
      // }

      if (elerendoPontszam && !isNaN(elerendoPontszam)){
        elerendoPontszam = elerendoPontszam;
      } else {
        elerendoPontszam = 15;
      }

      console.log(elerendoPontszam);

      // nyert a játékos?
      if(pontszamok[aktivJatekos] >= elerendoPontszam) {
        document.querySelector('#name-' + aktivJatekos).textContent = 'Győztes!';
        document.querySelector('.player-' + aktivJatekos + '-panel').classList.add('winner');
        document.querySelector('.player-' + aktivJatekos + '-panel').classList.remove('active');
        jatekFolyamatban = false;
      } else {
        // következő jatekos
        kovetkezoJatekos();
    }
  }
});

// következő jatekos
function kovetkezoJatekos(){
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

// init
function init() {
    pontszamok = [0, 0];
    aktivJatekos = 0;
    korPontszam = 0;
    jatekFolyamatban = true;
    
    kockaKiBeKapcsolas('ki');
    document.getElementById('score-0').textContent = '0';
    document.getElementById('current-0').textContent = '0';
    document.getElementById('score-1').textContent = '0';
    document.getElementById('current-0').textContent = '0';
    
    document.getElementById('name-0').textContent = 'Frodó';
    document.getElementById('name-1').textContent = 'Samu';
    
    document.querySelector('.player-0-panel').classList.remove('winner');
    document.querySelector('.player-1-panel').classList.remove('winner');
    document.querySelector('.player-0-panel').classList.remove('active');
    document.querySelector('.player-1-panel').classList.remove('active');
    document.querySelector('.player-0-panel').classList.add('active');
}

function kockaKiBeKapcsolas(funkcio) {
  //funkcio = 'ki', 'be'

  if (funkcio === 'ki') {
      document.getElementById('dice-1').style.display = 'none';
      document.getElementById('dice-2').style.display = 'none';
  } else if (funkcio === 'be') {
      document.getElementById('dice-1').style.display = 'block';
      document.getElementById('dice-2').style.display = 'block';
  }
}