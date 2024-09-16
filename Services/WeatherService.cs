using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "24a8da4072c14f0b9a171141242403";

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeatherResponse> GetWeatherAsync(string city)
    {
        Console.WriteLine($"{city}");
        var url = $"http://api.weatherapi.com/v1/current.json?key=24a8da4072c14f0b9a171141242403&q={city}&aqi=no";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var responseBody = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<WeatherResponse>(responseBody);
    }
}
