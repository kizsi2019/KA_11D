//JS 87- Async Await

//rész ami kell a 85-ből ehez a kódhoz
const azonositokLekerdezese = new Promise((resolve, reject) => {
    setTimeout(() => {
        resolve([676, 102, 34, 1089, 321]);
    }, 2000);
});

const receptLekeres = (receptID) => {
    return new Promise((resolve, reject) => {
        setTimeout((id) => {
            const recept = {
              cim: 'Gulyás Leves',
              kategoria: 'Levesek' 
            };

            resolve(`${id}: ${recept.cim}`)
        }, 1500, receptID);
    });
};

const kategoriaLekeres = (kategoria) => {
    return new Promise((resolve, reject) => {
        setTimeout((kat) => {
            const Levesek = [
                { cim: 'Gulyás Leves', kategoria: 'Levesek' },
                {  cim: 'Hús Leves',kategoria: 'Levesek' }
            ];
            resolve(Levesek);
        }, 1500, kategoria)
    });
};

//maga a 87-es rész
//az await arra van hogy megvárja a promisenak a SIKERES visszatérését, a .then és .catch-et helyetessíti!
async function GetReceptek() {
    const azonositok = await azonositokLekerdezese;
    console.log(azonositok);

    const recept = await receptLekeres(azonositok[2]);
    console.log(recept);

    const tovabbiak = await kategoriaLekeres(recept.kategoria);
    console.log(tovabbiak);

    return recept;
}

//ez se, itt azt kapjuk, hogy pending, mert mikor ezt lekérdezzük a getReceptek még mindig fut és várja a promisokat!
//ez egy szinkron kód de az async az aszinkra, ami annyi hogy jah ezek nem tudnak menni egyszerre
/*
const rec = GetReceptek();
console.log(rec);
*/

//egy asnyc log
GetReceptek().then(eredemeny => console.log(`${eredemeny} a legjobb leves!`));