using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace cica
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://catfact.ninja/facts");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dynamic catFacts = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                    foreach (var fact in catFacts.data)
                    {
                        Console.WriteLine(fact.fact);
                    }
                }
                else
                {
                    Console.WriteLine("Failed to retrieve cat facts. Status code: " + response.StatusCode);
                }
                Console.ReadKey();
            }
        }
    }
}
