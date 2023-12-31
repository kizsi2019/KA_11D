/*Játék szabályok:

- Ha egy játékos 2x 6-ost dob egymás után, akkor az összes eddigi pontját elveszíti és a dobás joga a másik játékora száll.
- Adjunk a programhoz egy olyan lehetőséget, hogy a felhasználói felületen meg lehessen
adni, hogy a győztesnek hány pontot kelljen elérni.
- Legyen még egy kocka. Ha az egyik kockával 1-est dob, akkor veszítse el a körben elért pontszámát.
*/

var scores, roundscore, ActivePlayer, alreadyplaying, recentthrow, requiredscore;

init();

//document.querySelector('#current-' + ActivePlayer).textContent = block;

document.querySelector('.btn-roll').addEventListener("click",
function(){
  	if (alreadyplaying){
		var block1 = Math.floor(Math.random() * 6) + 1;
		var block2 = Math.floor(Math.random() * 6) + 1;
		var blockDOM = document.querySelector('.dice');
		document.getElementById('dice-1').src = 'img/dice-' + block1 + '.png';
		document.getElementById('dice-2').src = 'img/dice-' + block2 + '.png';
		blockDOM.style.display = 'block';
		BlockOnOffSwitch('be');

		if (block1 !== 1 && block2 !== 2){
			roundscore += block1 + block2;
			document.querySelector('#current-' + ActivePlayer).textContent = roundscore;
		}else{
			nextplayer();
		}
	}
}
);


document.querySelector('.btn-hold').addEventListener('click', function(){
	if (alreadyplaying){
		scores[ActivePlayer] += roundscore;

		document.querySelector('#score-' + ActivePlayer).textContent = scores[ActivePlayer];

		var requiredscore = document.querySelector(".required-score").Value;
		console.log(requiredscore);

		if (requiredscore && !isNaN(requiredscore)){
			requiredscore - requiredscore;
		}else{
			requiredscore = 15;
		}

		console.log(requiredscore);

		if (scores[ActivePlayer] >= requiredscore) {
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

    BlockOnOffSwitch('ki');
}

document.querySelector('.btn-new').addEventListener('click', function(){
	init();
})

function init(){
	scores = [0,0];
	roundscore = 0;
	ActivePlayer = 1;
	alreadyplaying = true;

	BlockOnOffSwitch('ki');
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

function BlockOnOffSwitch(func){
	if (func === 'ki'){
		document.getElementById('dice-1').style.display = 'none';
		document.getElementById('dice-2').style.display = 'none';
	}else if (func === 'be'){
		document.getElementById('dice-1').style.display = 'block';
		document.getElementById('dice-2').style.display = 'block';
	}
}
