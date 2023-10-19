using Newtonsoft.Json;
using ShopTARge22.Core.Dto;
using ShopTARge22.Core.ServiceInterface;

namespace ShopTARge22.ApplicationServices.Services
{
    public class WeatherForecastServices : IWeatherForecastServices
    {
        WeatherResponceRootDto IWeatherForecastServices.GetForecast(string city)
        {
            string IdOpenWeather = "e647c34e4d90740d22ee2a55ba0f33e2";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city},&units=metric&appid={IdOpenWeather}"; 


            return null;
        }
    }
}
