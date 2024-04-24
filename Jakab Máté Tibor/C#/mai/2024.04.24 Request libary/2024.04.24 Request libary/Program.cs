using System;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {

        using HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage response = await client.GetAsync("https://catfact.ninja/facts");
            response.EnsureSuccessStatusCode(); // dob hibát ha a kérés sikertelen

            string responseBody = await response.Content.ReadAsStringAsync();
            JObject catFacts = JObject.Parse(responseBody);

            foreach (var fact in catFacts["data"])
            {
                Console.WriteLine(fact["fact"]);
            }
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"HTTP hiba történt: {e.Message}");
        }
    }
}
