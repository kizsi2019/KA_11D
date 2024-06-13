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
*/

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