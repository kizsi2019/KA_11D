//JS 86- Promise API

const idojaras = (woeid) => {
    //ez egy halott linknek az API-át akarja megszerezni, ez az egész rész nem fog működni-e miatt
    fetch(`https://cors-anywhere.herokuapp.com/https://www.metaweather.com/api/location/${woeid}`)
    //Promise rész logikusan
    .then(result => {
        //console.log(result);
        return result.json();
    })
    .then(adat => {
        console.log(adat);
        const ma = adat.consolidated_weather[0];
        console.log(`Ma a hőmérséklet ${adat.title}en ${Math.round(ma.min_temp)} és ${Math.round(ma.max_temp)} fok között fog változni.`);

        const holnap = adat.consolidated_weather[1];
        console.log(`Holnap a hőmérséklet ${adat.title}en ${Math.round(holnap.min_temp)} és ${Math.round(holnap.max_temp)} fok között fog változni.`);

    })
    .catch(error => {
        console.log(error);
    })
}

idojaras(804365);