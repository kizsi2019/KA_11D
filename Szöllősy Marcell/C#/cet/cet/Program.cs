using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class CatFacts
{
    public static async Task GetCatFactsAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync("https://catfact.ninja/facts");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            JObject catFacts = JObject.Parse(jsonString);

            foreach (var fact in catFacts["data"])
            {
                Console.WriteLine(fact["fact"]);
            }
        }
    }

    public static void Main()
    {
        Task.WaitAll(GetCatFactsAsync());
    }
}
