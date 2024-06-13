/*
const masodik = () => {
    console.log("második")
};

const elso = () => {
    console.log('első')
    masodik();
    console.log("harmadik")
};

elso();


const masodik = () => {

    setTimeout(() => {
        console.log("Asszinkron masodik")
    }, 6000);
};

const elso = () => {
    console.log("első")
    masodik();
    console.log("harmadik")
};

elso();

*/

////////////////////////////////////////////////////////////////////////////////////////////////////
//Callback

function receptlekerdez() {
    setTimeout (() => {
        const receptID = [676, 102, 34, 1480,321]
        console.log(receptID)

        setTimeout((id) => {
            const recept = {
                cim: "Gulyás leves",
                kategoria: "Levesek"
            }
            console.log(`${id}: ${recept.cim}`);

            setTimeout(kategoria => {
                const Levesek = [
                    {cim: 'NYirségi gombocleves', kategoria: 'Levesek'},
                    {cim: 'Borosleves', kategoria:'Levesek'}
                ];

                console.log(Levesek);
            }, 2000, recept.kategoria);
        },   2000, recept.kategoria);
    },  2000, receptID[1])
} 3000