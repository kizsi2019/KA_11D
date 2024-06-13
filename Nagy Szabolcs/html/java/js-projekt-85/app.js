    /*
    const azonositokLekerdezese = new Promise((resolve, reject) => {
    setTimeout(()=>{
        resolve([676, 102, 34, 1089, 321]);
        }, 2000);
    });
    
    azonositokLekerdezese.then(azonositiok => {
        console.log(azonositiok);
        }); */


        const azonositokLekerdezese = new Promise((resolve, reject) => {
            setTimeout(()=>{
                resolve([676, 102, 34, 1089, 321]);
                //reject("valami hiba van");
                }, 2000);
            });

            const receptlekeres = (receptID) => {
                return new Promise ((resolve, reject) => {
                    setTimeout ((id) => {
                        const recept = {
                            cim: 'Gulyás leves',
                            kategoria: 'levesek'
                        };
                        resolve(`${id}: ${recept.cim}`);
                    }, 1500, receptID);
                });
            };

            const kategorialekeres = (kategoria) => {
                return new Promise((resolve, reject) => {
                setTimeout((kat) => {
                const levesek = [
                        { cim: 'Tōkleves', kategoria: 'Levesek'},
                        { cim: 'Húsleves', kategoria: 'Levesek'},
                    ];
                    resolve(levesek);
                }, 1500, kategoria)
            });
        };

            azonositokLekerdezese.then(azonositiok => {
                console.log(azonositiok);
                return receptlekeres(azonositiok[2]);
            })
            .then((recept) => {
                console.log(recept)
                return kategorialekeres(recept.kategoria);
            })
            .then((kategoria) => {
                console.log(kategoria);
            })
            .catch(hiba => {
                console.log(hiba);
                });
                