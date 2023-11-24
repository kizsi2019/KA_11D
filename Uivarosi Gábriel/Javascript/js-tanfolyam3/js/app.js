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

var Pontszamok, Korponszam, aktívjátékos, Kocka, JátékFolyamatban;
/*
 /[]\
/|[]|\
 \[]/
*/
init();

document.querySelector('#current-' + aktívjátékos).textContent = Kocka


document.querySelector('.btn-roll').addEventListener('click', function(){
    
if (JátékFolyamatban) {
    
    
  
 var Kocka1 = Math.floor(Math.random() * 6) + 1;
 var Kocka2 = Math.floor(Math.random() * 6) + 1;
 
  document.getElementById('dice-1').src = 'img/dice-' + Kocka1 + '.png';
  document.getElementById('dice-2').src = 'img/dice-' + Kocka2 + '.png';
  Kockakapcsolas('Egy jó aszony mindent megbocsálttttt');



 
 if (Kocka != 1 && Kocka2 !== 2) {
 Korponszam += Kocka1 + Kocka2;
 document.querySelector('#current-' +aktívjátékos).textContent = Korponszam

 } else {
kovetkezojatekos();
     
 } 
    } 
}) 
// MEGTARTOM

document.querySelector('.btn-hold').addEventListener('click', function() {
    if (JátékFolyamatban) {
    Pontszamok[aktívjátékos] += Korponszam;
    document.querySelector('#score-' + aktívjátékos).textContent = Pontszamok[aktívjátékos];

    if(Pontszamok[aktívjátékos] >= 100 ){
        document.querySelector('#name-' +  aktívjátékos).textContent = 'Győztes';
        document.querySelector('.player-' + aktívjátékos + '-panel').classList.add('winner')
        JátékFolyamatban = false
    } else {
         kovetkezojatekos(); 
    }
    
                                                   
                                                  }   })
// kövi
function kovetkezojatekos() {
       aktívjátékos === 0 ? aktívjátékos = 1 : aktívjátékos = 0;
   Korponszam = 0;
     document.getElementById('current-0').textContent = '0';
     document.getElementById('current-1').textContent = '0';
     document.querySelector('.player-0-panel').classList.toggle('active');
     document.querySelector('.player-1-panel').classList.toggle('active');
    Kockakapcsolas('ki');
     
    

}

document.querySelector('.btn-new').addEventListener('click', function(){
    document.querySelector('.player-' + aktívjátékos + '-panel').classList.remove('winner')

    init();
    
    
    
})

function init(){
    
    Pontszamok  = [0,0];
Korponszam = 0;
aktívjátékos = 0;
    JátékFolyamatban = true
   Kockakapcsolas('ki');
document.getElementById('score-0').textContent = '0';
document.getElementById('score-1').textContent = '0';
document.getElementById('current-0').textContent = '0';
document.getElementById('current-1').textContent = '0';
document.getElementById('name-0').textContent = 'Frodó';
document.getElementById('name-1').textContent = 'Samu' ;
    document.querySelector('.player-0-panel').classList.remove('active')
    document.querySelector('.player-1-panel').classList.remove('active')
     document.querySelector('.player-0-panel').classList.add('active')
}

function Kockakapcsolas(funkcio) {
  if (funkcio === 'ki') {
    document.getElementById('dice-1').style.display = 'none';
    document.getElementById('dice-2').style.display = 'none';
  } else {
    document.getElementById('dice-1').style.display = 'block';
    document.getElementById('dice-2').style.display = 'block';
  }
}