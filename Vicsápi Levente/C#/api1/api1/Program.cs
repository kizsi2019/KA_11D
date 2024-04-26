using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace api1
{
    internal class Program
    {
        /*
        static async Task Main(string[] args)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://catfact.ninja/facts");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                JObject jsonResponse = JObject.Parse(responseBody);
                JArray data = (JArray)jsonResponse["data"];

                foreach (JToken fact in data)
                {
                    Console.WriteLine(fact["fact"]);
                }
            }
            Console.ReadKey();
        }
        */

        static async Task Main(string[] args)
        {
            Console.WriteLine("A keresztnév alapján kitalálom a személy nemét, korát és országát.");
            Console.Write("Add meg a keresztnevet! ");
            string firstName = Console.ReadLine();

            (string gender, double genProb) = await GetGender(firstName);
            Console.WriteLine($"A neme: {(gender == "male" ? "férfi" : "nő")}, ennek valószínűsége: {genProb * 100:.0f}%.");

            int age = await GetAge(firstName);
            Console.WriteLine($"A kor valószínűleg {age} év.");

            (string nat, double natProb) = await GetNat(firstName);
            Console.WriteLine($"Az ország kódja: {nat}, ennek valószínűsége: {natProb * 100:.0f}%.");
            Console.ReadKey();
        }

        static async Task<(string, double)> GetGender(string name)
        {
            using (var httpClient = new HttpClient())
            {
                string genUrl = "https://api.genderize.io/";
                var payload = new Dictionary<string, string> { { "name", name } };
                HttpResponseMessage genResp = await httpClient.GetAsync(genUrl + "?name=" + name);
                genResp.EnsureSuccessStatusCode();
                string responseBody = await genResp.Content.ReadAsStringAsync();
                dynamic jsonResponse = JObject.Parse(responseBody);
                string gender = jsonResponse.gender;
                double genProb = jsonResponse.probability;
                return (gender, genProb);
            }
        }

        static async Task<int> GetAge(string name)
        {
            using (var httpClient = new HttpClient())
            {
                string ageUrl = "https://api.agify.io/";
                HttpResponseMessage ageResp = await httpClient.GetAsync(ageUrl + "?name=" + name);
                ageResp.EnsureSuccessStatusCode();
                string responseBody = await ageResp.Content.ReadAsStringAsync();
                dynamic jsonResponse = JObject.Parse(responseBody);
                int age = jsonResponse.age;
                return age;
            }
        }

        static async Task<(string, double)> GetNat(string name)
        {
            using (var httpClient = new HttpClient())
            {
                string natUrl = "https://api.nationalize.io/";
                HttpResponseMessage natResp = await httpClient.GetAsync(natUrl + "?name=" + name);
                natResp.EnsureSuccessStatusCode();
                string responseBody = await natResp.Content.ReadAsStringAsync();
                dynamic jsonResponse = JObject.Parse(responseBody);
                string nat = jsonResponse.country[0].country_id;
                double natProb = jsonResponse.country[0].probability;
                return (nat, natProb);
            }
        }
    }
}
