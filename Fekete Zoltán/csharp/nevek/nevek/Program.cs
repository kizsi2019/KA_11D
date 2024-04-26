using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace nevek
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("A keresztnév alapján kitalálom a személy nemét, korát és országát.");
            Console.Write("Add meg a keresztnevet! ");
            string firstName = Console.ReadLine();

            try
            {
                var genderResult = await GetGenderAsync(firstName);
                var age = await GetAgeAsync(firstName);
                var natResult = await GetNatAsync(firstName);

                Console.WriteLine($"A neme: {(genderResult.Item1 == "male" ? "férfi" : "nő")}, " +
                                  $"ennek valószínűsége: {genderResult.Item2 * 100:.0f}%.");
                Console.WriteLine($"A kor valószínűleg {age} év.");
                Console.WriteLine($"Az ország kódja: {natResult.Item1}, " +
                                  $"ennek valószínűsége: {natResult.Item2 * 100:.0f}%.");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Hiba történt a lekérdezés során: {ex.Message}");
            }
        }

        static async Task<(string, double)> GetGenderAsync(string name)
        {
            using (var client = new HttpClient())
            {
                var response = await RetryWithDelay(() => client.GetAsync($"https://api.genderize.io/?name={name}"));
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(content);
                return (result.gender, result.probability);
            }
        }

        static async Task<int> GetAgeAsync(string name)
        {
            using (var client = new HttpClient())
            {
                var response = await RetryWithDelay(() => client.GetAsync($"https://api.agify.io/?name={name}"));
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(content);
                return result.age;
            }
        }

        static async Task<(string, double)> GetNatAsync(string name)
        {
            using (var client = new HttpClient())
            {
                var response = await RetryWithDelay(() => client.GetAsync($"https://api.nationalize.io/?name={name}"));
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(content);
                var country = result.country[0].country_id;
                var probability = result.country[0].probability;
                return (country, probability);
            }
        }

        static async Task<HttpResponseMessage> RetryWithDelay(Func<Task<HttpResponseMessage>> action, int retryCount = 3, TimeSpan delay = default)
        {
            int retries = 0;
            while (true)
            {
                try
                {
                    return await action();
                }
                catch (HttpRequestException ex) when (ex.Message.Contains("429") && retries < retryCount)
                {
                    retries++;
                    if (delay == default)
                        delay = TimeSpan.FromSeconds(5); // default delay of 5 seconds
                    await Task.Delay(delay);
                }
                catch (Exception)
                {
                    throw; // rethrow other exceptions
                }
                Console.ReadKey();
            }
        }
    }
    
}
