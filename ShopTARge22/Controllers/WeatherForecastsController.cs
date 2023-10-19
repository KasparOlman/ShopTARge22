using Microsoft.AspNetCore.Mvc;
using ShopTARge22.Core.ServiceInterface;

namespace ShopTARge22.Controllers
{
    public class WeatherForecastsController : Controller
    {
        private readonly IWeatherForecastServices _weatherForecastServices;

        public WeatherForecastsController(
            IWeatherForecastServices weatherForecastServices)
        {
            _weatherForecastServices = weatherForecastServices;
        }   

        [HttpGet] 
        public IActionResult Index()
        {
            SearchCity model = new();
            return View();
        }
    }
}
