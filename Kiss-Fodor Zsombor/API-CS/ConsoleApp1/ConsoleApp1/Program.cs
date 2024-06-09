using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("A keresztnév alapján kitalálom a személy nemét, korát és országát.");
        Console.Write("Add meg a keresztnevet! ");
        string firstName = Console.ReadLine();

        var genderResult = await GetGender(firstName);
        Console.WriteLine($"A neme: {(genderResult.Gender == "male" ? "férfi" : "nő")}, " +
            $"ennek valószínűsége: {genderResult.Probability * 100:.0f}%.");

        var age = await GetAge(firstName);
        Console.WriteLine($"A kor valószínűleg {age} év.");

        var nationalityResult = await GetNationality(firstName);
        Console.WriteLine($"Az ország kódja: {nationalityResult.CountryId}, " +
            $"ennek valószínűsége: {nationalityResult.Probability * 100:.0f}%.");
    }

    static async Task<(string Gender, double Probability)> GetGender(string name)
    {
        using (var httpClient = new HttpClient())
        {
            var genUrl = $"https://api.genderize.io/?name={name}";
            var response = await httpClient.GetAsync(genUrl);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var json = JsonDocument.Parse(responseBody);
            var gender = json.RootElement.GetProperty("gender").GetString();
            var probability = json.RootElement.GetProperty("probability").GetDouble();
            return (gender, probability);
        }
    }

    static async Task<int> GetAge(string name)
    {
        using (var httpClient = new HttpClient())
        {
            var ageUrl = $"https://api.agify.io/?name={name}";
            var response = await httpClient.GetAsync(ageUrl);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var json = JsonDocument.Parse(responseBody);
            var age = json.RootElement.GetProperty("age").GetInt32();
            return age;
        }
    }

    static async Task<(string CountryId, double Probability)> GetNationality(string name)
    {
        using (var httpClient = new HttpClient())
        {
            var natUrl = $"https://api.nationalize.io/?name={name}";
            var response = await httpClient.GetAsync(natUrl);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var json = JsonDocument.Parse(responseBody);
            var countryId = json.RootElement.GetProperty("country")[0].GetProperty("country_id").GetString();
            var probability = json.RootElement.GetProperty("country")[0].GetProperty("probability").GetDouble();
            return (countryId, probability);
        }
    }
}
