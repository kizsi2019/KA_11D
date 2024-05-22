/*const masodik = () => {
    console.log ('masodik')
};

const elso = () => {
    console.log('elso')
    masodik();
    console.log('harmadik')
}

elso();*/

const masodik = () => {

    setTimeout(() => {
       console.log('Asszinkron masodik') 
    }, 6000);
};

const elso = () => {
    console.log('elso')
    masodik();
    console.log('harmadik')
};

elso();

function receptLkerdez() {
    setTimeout(() => {
       const receptID = [676, 102, 34 ,1489, 321]
       console.log(receptID)
       
       setTimeout((id) => {
        const recept = {
            cim: 'Gulyás Leves',
            kategoria: 'Levesek'
        }
        console.log(`${id}: ${recept.cim}`);
        
        setTimeout(kategoria => {
            const levesek = [
                { cim: 'Nyirségi gombócleves', kategoria: 'Levesek'},
                { cim: 'Borsóleves', kategoria: 'Levesek'}

            ];

            console.log(levesek);
        }, 2000, recept.kategoria);
       }, 2000, receptID[1])
    }, 3000)   

}

receptLkerdez();