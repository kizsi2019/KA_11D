async function getReceptek (){
        const azonositiok = await azonositioklekerdezese;
        console.log(azonositiok);

         const recept = await receptlekeres (azonositok [2]);
         console.log(recept);

         const tovabbiak = await kategorialekeres(recept.kategoria);
          console.log(tovabbiak);

         return recept;

         }
getReceptek().then(eredmeny => console.log((`${eredmeny} a legjobb leves`)));