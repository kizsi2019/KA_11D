using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class NameInfo
{
    private static async Task<(string gender, double probability)> GetGenderAsync(string name)
    {
        using (HttpClient client = new HttpClient())
        {
            var payload = new { name };
            HttpResponseMessage response = await client.GetAsync("https://api.genderize.io/?name=" + name);
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(jsonString);

            string gender = json["gender"].ToString();
            double probability = Convert.ToDouble(json["probability"].ToString());

            return (gender, probability);
        }
    }

    private static async Task<int> GetAgeAsync(string name)
    {
        using (HttpClient client = new HttpClient())
        {
            var payload = new { name };
            HttpResponseMessage response = await client.GetAsync("https://api.agify.io/?name=" + name);
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(jsonString);

            return Convert.ToInt32(json["age"].ToString());
        }
    }

    private static async Task<(string countryId, double probability)> GetNationalityAsync(string name)
    {
        using (HttpClient client = new HttpClient())
        {
            var payload = new { name };
            HttpResponseMessage response = await client.GetAsync("https://api.nationalize.io/?name=" + name);
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(jsonString);

            string countryId = json["country"][0]["country_id"].ToString();
            double probability = Convert.ToDouble(json["country"][0]["probability"].ToString());

            return (countryId, probability);
        }
    }

    public static async Task Main()
    {
        Console.WriteLine("A keresztnév alapján kitalálom a személy nemét, korát és országát.");
        Console.Write("Add meg a keresztnevet! ");
        string firstName = Console.ReadLine();

        var genderInfo = await GetGenderAsync(firstName);
        var age = await GetAgeAsync(firstName);
        var nationalityInfo = await GetNationalityAsync(firstName);

        Console.WriteLine($"A neme: {(genderInfo.gender == "male" ? "férfi" : "nő")}, ennek valószínűsége: {genderInfo.probability * 100:F0}%.");
        Console.WriteLine($"A kor valószínűleg {age} év.");
        Console.WriteLine($"Az ország kódja: {nationalityInfo.countryId}, ennek valószínűsége: {nationalityInfo.probability * 100:F0}%.");
    }
}
