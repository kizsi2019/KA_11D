//Callback hell!

function askrecipe()
{
    setTimeout(() =>
    {
        const recipeID = [676,102,34,1489,321]
        console.log(recipeID)
        setTimeout((id) =>
        {
            const recipe =
            {
                title: 'Gulyásleves',
                category: 'Levesek'
            }
            console.log(`${id}: ${recipe.title}`);
        })
    })
}