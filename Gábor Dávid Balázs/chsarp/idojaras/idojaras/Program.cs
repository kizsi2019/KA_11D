using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace idojaras
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string apiKey = "d4bb2337611a250530225d86c6e1e06c";
            string oneCallApi = "https://api.openweathermap.org/data/3.0/onecall?lat=33.44&lon=-94.04&exclude=hourly,daily&appid={apiKey}";
            string geocodingApi = "http://api.openweathermap.org/geo/1.0/direct?q=London&limit=5&appid={apikey}";
            string city = "Sopron";

            (double lat, double lon) = await GetCoordinates(city, apiKey, geocodingApi);
            dynamic weather = await GetWeather(lat, lon, apiKey, oneCallApi);

            if (weather != null)
            {
                Console.WriteLine("Current weather in " + city + ":");
                Console.WriteLine("Temperature: " + weather.current.temp + " °C");
                Console.WriteLine("Weather description: " + weather.current.weather[0].description);
            }
            else
            {
                Console.WriteLine("Failed to retrieve weather data.");
            }

            Console.ReadKey(); // Áthelyezve ide
        }

        static async Task<(double lat, double lon)> GetCoordinates(string city, string apiKey, string geocodingApi)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{geocodingApi}?q={city}&appid={apiKey}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                    double lat = result[0].lat;
                    double lon = result[0].lon;
                    return (lat, lon);
                }
                else
                {
                    Console.WriteLine($"Failed to retrieve coordinates for {city}. Status code: {response.StatusCode}");
                    return (0, 0);
                }
            }
        }

        static async Task<dynamic> GetWeather(double lat, double lon, string apiKey, string oneCallApi)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{oneCallApi}?lat={lat}&lon={lon}&appid={apiKey}&units=metric&lang=hu");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                    return result;
                }
                else
                {
                    Console.WriteLine($"Failed to retrieve weather data. Status code: {response.StatusCode}");
                    return null;
                }
            }
        }
    }
}
