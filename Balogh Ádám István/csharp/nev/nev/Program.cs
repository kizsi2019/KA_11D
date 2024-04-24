using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

class Program
{
    static async Task<string> GetGender(string name)
    {
        using HttpClient client = new HttpClient();
        string url = $"https://api.genderize.io/?name={name}";
        HttpResponseMessage response = await client.GetAsync(url);
        string jsonResponse = await response.Content.ReadAsStringAsync();
        var jsonDoc = JsonDocument.Parse(jsonResponse);
        string gender = jsonDoc.RootElement.GetProperty("gender").GetString();
        double probability = jsonDoc.RootElement.GetProperty("probability").GetDouble();
        return $"{gender}, valószínűsége: {probability * 100:F0}%";
    }

    static async Task<int> GetAge(string name)
    {
        using HttpClient client = new HttpClient();
        string url = $"https://api.agify.io/?name={name}";
        HttpResponseMessage response = await client.GetAsync(url);
        string jsonResponse = await response.Content.ReadAsStringAsync();
        var jsonDoc = JsonDocument.Parse(jsonResponse);
        int age = jsonDoc.RootElement.GetProperty("age").GetInt32();
        return age;
    }

    static async Task<string> GetNationality(string name)
    {
        using HttpClient client = new HttpClient();
        string url = $"https://api.nationalize.io/?name={name}";
        HttpResponseMessage response = await client.GetAsync(url);
        string jsonResponse = await response.Content.ReadAsStringAsync();
        var jsonDoc = JsonDocument.Parse(jsonResponse);
        var country = jsonDoc.RootElement.GetProperty("country")[0];
        string countryId = country.GetProperty("country_id").GetString();
        double probability = country.GetProperty("probability").GetDouble();
        return $"{countryId}, valószínűsége: {probability * 100:F0}%";
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("A keresztnév alapján kitalálom a személy nemét, korát és országát.");
        Console.Write("Add meg a keresztnevet: ");
        string firstName = Console.ReadLine();

        string gender = await GetGender(firstName);
        int age = await GetAge(firstName);
        string nationality = await GetNationality(firstName);

        Console.WriteLine($"A neme: {gender}.");
        Console.WriteLine($"A kor valószínűleg {age} év.");
        Console.WriteLine($"Az ország kódja: {nationality}.");
    }
}
