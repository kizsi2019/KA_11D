/*Játék szabályok:

- A játék 2 szereplős és körökre osztott
- Minden egyes körben az adott játékos dob a kockával, ahányszor csak szeretne. A dobások eredménye hozzáadódik a játékos adott körben
  elért pontszámához, ami értelem szerűen minden körben nulláról indul.
- Ha az aktuális játékos 1-et dob, akkor az összes addigi pontja elveszik, és átadja a dobás jogát a következő játékosnak.
- A játékos választhatja a 'Megtartom' gombot is. Ebben az esetben az adott körben elért pontok száma, hozzáadódik a játékos összes
  pontszámához. Majd a dobás joga a másik játékosra száll.
- Az a játékos nyer, aki előbb eléri a 100 pontot.*/

var scores, roundscore, ActivePlayer;

scores = [0,0];
roundscore = 0;
ActivePlayer = 1;

//document.querySelector('#current-' + ActivePlayer).textContent = block;

document.querySelector('.dice').style.display = 'none';
document.getElementById('score-0').textContent = "0";
document.getElementById('current-0').textContent = "0";
document.getElementById('score-1').textContent = "0";
document.getElementById('current-1').textContent = "0";

document.querySelector('.btn-roll').addEventListener("click", function(){
  var block = Math.floor(Math.random() * 6) + 1;
  var blockDOM = document.querySelector('.dice');
  blockDOM.style.display = 'block';
  blockDOM.src = "img/dice-" + block + ".png";

  if (block !== 1){
    roundscore += block;
    document.querySelector('#current-' + ActivePlayer).textContent = roundscore;
  }else{
    ActivePlayer === 0 ? ActivePlayer = 1 : ActivePlayer = 0;
    roundscore = 0;

    document.getElementById('#current-0').textContent = '0';
    document.getElementById('#current-1').textContent = '0';

    document.querySelector('.player-0-panel').classList.toggle('active');
    document.querySelector('.player-1-panel').classList.toggle('active');

    document.querySelector('.dice').style.display = 'none';
  }
});

document.querySelector('.btn-hold').addEventListener('click',
function(){
	scores[ActivePlayer] += roundscore;

	document.querySelector('#score-' + ActivePlayer).textContent = scores[ActivePlayer];
});