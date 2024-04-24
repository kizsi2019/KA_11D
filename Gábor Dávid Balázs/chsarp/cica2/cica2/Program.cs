using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace cica2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("A keresztnév alapján kitalálom a személy nemét, korát és országát.");
            Console.Write("Add meg a keresztnevet! ");
            string firstName = Console.ReadLine();

            (string gender, double genProb) = await GetGender(firstName);
            Console.WriteLine($"A neme: {(gender == "male" ? "férfi" : "nő")}, ennek valószínűsége: {genProb * 100:.0f}%.");

            int age = await GetAge(firstName);
            Console.WriteLine($"A kor valószínűleg {age} év.");

            (string nationality, double natProb) = await GetNationality(firstName);
            Console.WriteLine($"Az ország kódja: {nationality}, ennek valószínűsége: {natProb * 100:.0f}%.");

            Console.WriteLine("Nyomj meg egy billentyűt a kilépéshez...");
            Console.ReadKey();
        }

        static async Task<(string gender, double probability)> GetGender(string name)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"https://api.genderize.io/?name={name}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                    string gender = result.gender;
                    double probability = result.probability;
                    return (gender, probability);
                }
                else
                {
                    Console.WriteLine($"Failed to retrieve gender for {name}. Status code: {response.StatusCode}");
                    return ("", 0);
                }
            }
        }

        static async Task<int> GetAge(string name)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"https://api.agify.io/?name={name}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                    int age = result.age;
                    return age;
                }
                else
                {
                    Console.WriteLine($"Failed to retrieve age for {name}. Status code: {response.StatusCode}");
                    return 0;
                }
            }
        }

        static async Task<(string country, double probability)> GetNationality(string name)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"https://api.nationalize.io/?name={name}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                    string country = result.country[0].country_id;
                    double probability = result.country[0].probability;
                    return (country, probability);
                }
                else
                {
                    Console.WriteLine($"Failed to retrieve nationality for {name}. Status code: {response.StatusCode}");
                    return ("", 0);
                }
                Console.ReadKey();
            }
        }
    }
}
