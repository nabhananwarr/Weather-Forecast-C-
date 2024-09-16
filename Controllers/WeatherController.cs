using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeatherForecastApp.Models;

namespace WeatherForecastApp.Controllers{
    public class WeatherController : Controller
    {
        private readonly WeatherService _weatherService;
        private readonly ILogger<WeatherController> _logger;

        public WeatherController(WeatherService weatherService, ILogger<WeatherController> logger)
        {
            _weatherService = weatherService;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            // This method returns the initial form to the user
            Console.WriteLine("opop");
            return View("/Views/Home/Index.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Index(string city)
        {
            _logger.LogInformation($"City received: {city}"); // Using logger instead of Console.WriteLine

            var weatherData = await _weatherService.GetWeatherAsync(city);
            if (weatherData == null)
            {
                // Handle case where no data is returned
                ViewBag.ErrorMessage = "No weather data available for the specified city.";
                return View(); // Return the same Index view with an error message
            }
            return View(weatherData);
        }
    }
}
