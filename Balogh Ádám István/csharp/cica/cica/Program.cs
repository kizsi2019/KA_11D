using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

public class CatFacts
{
    public static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();

        // HTTP GET kérés
        HttpResponseMessage response = await client.GetAsync("https://catfact.ninja/facts");

        // Ellenőrizzük, hogy a kérés sikeres volt-e
        if (response.IsSuccessStatusCode)
        {
            // JSON objektumot olvasunk a válaszból
            string jsonString = await response.Content.ReadAsStringAsync();
            JObject jsonObject = JObject.Parse(jsonString);

            // Az adatokat olvassuk a 'data' kulcs alól
            var catFacts = jsonObject["data"];

            // Végigmegyünk az összes tényleges tényen
            foreach (var fact in catFacts)
            {
                Console.WriteLine(fact["fact"]);
            }
        }
        else
        {
            Console.WriteLine("Hiba történt a kérés során.");
        }
        Console.ReadKey();
    }
}
