//JS 85- Promise

//egy tömböt kérünk le 2 mp után, a resolval tudjuk hogy ez a lekérdés ment és ilyenkor minden rendesen fut le
//a reject meg ennek az ellentétje
const azonositokLekerdezese = new Promise((resolve, reject) => {
    setTimeout(() => {
        resolve([676, 102, 34, 1089, 321]);
        //reject("valami hiba van");
    }, 2000);
});

//egy recept objektumot kérünk le majd ami majd aztán a másik Promise után fog lefutni mert egybe vannak fésülve
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

// -||-
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

//ez fut le ha sikeres a Promise
azonositokLekerdezese.then(azonositok =>{
    console.log(azonositok);
    return receptLekeres(azonositok[2]);
})
//összefésült visszahívások az előzövel
.then((recept) => {
    console.log(recept)
    return kategoriaLekeres(recept.kategoria);
})
.then((kategoria) => {
    console.log(kategoria);
})
//ez fut le ha bármikor a három Promise rejected lesz
.catch(hiba=> {
    console.log
});

//fuh remélem ezt jól értettem lol