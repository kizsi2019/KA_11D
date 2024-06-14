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

    async function GetReceptek() {
        const azonositok = await azonositokLekerdezese;
        console.log(azonositok);
    
        const recept = await receptLekeres(azonositok[2]);
        console.log(recept);
    
        const tovabbiak = await kategoriaLekeres(recept.kategoria);
        console.log(tovabbiak);
    
        return recept;
    }
    GetReceptek().then(eredemeny => console.log(`${eredemeny} a legjobb leves!`));