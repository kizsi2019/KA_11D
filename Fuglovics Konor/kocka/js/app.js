/*Játék szabályok:

- A játék 2 szereplős és körökre osztott
- Minden egyes körben az adott játékos dob a kockával, ahányszor csak szeretne. A dobások eredménye hozzáadódik a játékos adott körben
  elért pontszámához, ami értelem szerűen minden körben nulláról indul.
- Ha az aktuális játékos 1-et dob, akkor az összes addigi pontja elveszik, és átadja a dobás jogát a következő játékosnak.
- A játékos választhatja a 'Megtartom' gombot is. Ebben az esetben az adott körben elért pontok száma, hozzáadódik a játékos összes
  pontszámához. Majd a dobás joga a másik játékosra száll.
- Az a játékos nyer, aki előbb eléri a 100 pontot.*/

var scores, roundscore, ActivePlayer, alreadyplaying;

init();

//document.querySelector('#current-' + ActivePlayer).textContent = block;

document.querySelector('.btn-roll').addEventListener("click", function(){
  	if (alreadyplaying){
		var block = Math.floor(Math.random() * 6) + 1;
  		var blockDOM = document.querySelector('.dice');
  		blockDOM.style.display = 'block';
  		blockDOM.src = "img/dice-" + block + ".png";

  		if (block !== 1){
			roundscore += block;
    		document.querySelector('#current-' + ActivePlayer).textContent = roundscore;
  		}else{
			nextplayer();
  		}
	}
});

document.querySelector('.btn-hold').addEventListener('click', function(){
	if (alreadyplaying){
		scores[ActivePlayer] += roundscore;

		document.querySelector('#score-' + ActivePlayer).textContent = scores[ActivePlayer];

		if (scores[ActivePlayer] >= 15) {
			document.querySelector('#name-' + ActivePlayer).textContent = 'Winner!';
			document.querySelector('.player-' + ActivePlayer + '-panel').classList.add('winner');
			document.querySelector('.player-' + ActivePlayer + '-panel').classList.remove('active');
			alreadyplaying = false;
		}else{
			nextplayer();
		}
	}
});

function nextplayer(){
	ActivePlayer === 0 ? ActivePlayer = 1 : ActivePlayer = 0;
    roundscore = 0;

    document.getElementById('current-0').textContent = '0';
    document.getElementById('current-1').textContent = '0';

    document.querySelector('.player-0-panel').classList.toggle('active');
    document.querySelector('.player-1-panel').classList.toggle('active');

    document.querySelector('.dice').style.display = 'none';
}

document.querySelector('.btn-new').addEventListener('click', function(){
	init();
})

function init(){
	scores = [0,0];
	roundscore = 0;
	ActivePlayer = 1;
	alreadyplaying = true;

	document.querySelector('.dice').style.display = 'none';
	document.getElementById('score-0').textContent = "0";
	document.getElementById('current-0').textContent = "0";
	document.getElementById('score-1').textContent = "0";
	document.getElementById('current-1').textContent = "0";

	document.getElementById('name-0').textContent = 'Frodó';
	document.getElementById('name-1').textContent = 'Samu';
	document.querySelector('.player-0-panel').classList.remove('winner');
	document.querySelector('.player-1-panel').classList.remove('winner');
	document.querySelector('.player-0-panel').classList.remove('active');
	document.querySelector('.player-1-panel').classList.remove('active');
	document.querySelector('.player-0-panel').classList.add('active');
}