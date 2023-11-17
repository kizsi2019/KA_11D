
// DOM Manipuláció: js-el módosítjuk a html-t és a css-t

let scores, roundScore, activePlayer;


function init() {
  // a két játékos pontszáma egy 2 elemű tömbben lesz tárolva
  // az első elem az első játékos pontszáma, a második a második játékos pontszáma
  scores = [0, 0];

  // az aktuáis játékos kör alatt megszerzett pontjai
  roundScore = 0;

  // mindig az első játékos kezd
  activePlayer = 0;

  // beállítjuk a kezdőértékeket a UI-n is (a html-ben) - dinamikusan itt tudjuk állítani

  document.querySelector('#score-0').textContent = 0;
  document.querySelector('#score-1').textContent = 0;
  //  ez a jQuery-je ennek: $( '#score-1' ).html(0);

  document.querySelector('#current-0').textContent = 0;
  document.querySelector('#current-1').textContent = 0;

  // a játék kezdetekor a kockát eltüntetjük 
  // inline style-t adunk hozzá az img-hez
  document.querySelector('.dice').style.display = 'none';
  // a gombokat megjelenítjük
  document.querySelector('.btn-roll').style.display = 'block';
  document.querySelector('.btn-hold').style.display = 'block';

  document.querySelector('#name-0').textContent = 'Frodó';
  document.querySelector('#name-1').textContent = 'Samu';

  document.querySelector('.player-0-panel').classList.remove('winner');
  document.querySelector('.player-1-panel').classList.remove('winner');

  document.querySelector('.player-1-panel').classList.remove('active');
  document.querySelector('.player-0-panel').classList.add('active');

}

init();
document.querySelector('.btn-new').addEventListener('click', init)

// ha a roll dice gombra kattint az user
document.querySelector('.btn-roll').addEventListener('click', function () {
  console.log('rolling the dice...');
  // 1. generálunk egy random számot 1-6 között
  let dice = Math.floor(Math.random() * 6) + 1;
  console.log(dice);
  // 2. az eredményt megjelenítjük a UI-n
  let diceDOM = document.querySelector('.dice');
  diceDOM.style.display = 'block';
  // string concatenation, sztring összefűzés 'dice-'+dice'.png'
  diceDOM.setAttribute('src', 'dice-' + dice + '.png');


  // Ha a játékos 1-est dob, a roundScore értékét elveszti, és a következő játékos jön

  if (dice !== 1) {
    // A dobott értéket kiszámoljuk majd megjelenítjük a piros dobozban
    roundScore = roundScore + dice;

    document.querySelector('#current-' + activePlayer).textContent = roundScore;

    // ha a játékos 1-est dobott
  } else {
    nextPlayer();
  }

});

// DRY: do not repeat yourself

function nextPlayer() {
  // a roundScore értéket nullázzuk a UI-n is
  document.querySelector('#current-' + activePlayer).textContent = 0;
  // a következő játékos jön
  if (activePlayer === 0) {
    activePlayer = 1;
  } else {
    activePlayer = 0;
  }
  roundScore = 0;
  // ha rajta volt a class, akkor leveszi, ha nem, akkor rárakja
  document.querySelector('.player-0-panel').classList.toggle('active');
  document.querySelector('.player-1-panel').classList.toggle('active');
}

// ha a hold gombra rányom a játékos
document.querySelector('.btn-hold').addEventListener('click', function () {
  // a játékos megszerzi a kör alatt szerzett pontjait
  // az előző érték plusz a mostani
  scores[activePlayer] = scores[activePlayer] + roundScore;
  // update the UI (megjelenítjük az usernek)
  document.querySelector('#score-' + activePlayer).textContent = scores[activePlayer];

  // ellenőrizzük, hogy van-e nyertes
  if (scores[activePlayer] >= 20) {
    // a játék vége
    document.querySelector('.player-' + activePlayer + '-panel').classList.add('winner');
    document.querySelector('.player-' + activePlayer + '-panel').classList.remove('active');
    document.querySelector('#name-' + activePlayer).textContent = 'Győztes!';
    document.querySelector('.dice').style.display = 'none';
    document.querySelector('.btn-roll').style.display = 'none';
    document.querySelector('.btn-hold').style.display = 'none';

  } else {
    nextPlayer();
  }
});