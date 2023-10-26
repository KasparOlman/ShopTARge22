using Nancy.Json;
using Newtonsoft.Json;
using ShopTARge22.Core.Dto.WeatherDtos;
using ShopTARge22.Core.ServiceInterface;
using System.Net;
using static ShopTARge22.Core.Dto.WeatherDtos.WeatherResponceRootDto;

namespace ShopTARge22.ApplicationServices.Services
{
    public class WeatherForecastServices : IWeatherForecastServices
    {
        public async Task<OpenWeatherResultDto> OpenWeatherResult(OpenWeatherResultDto dto)
        {
            string idOpenWeather = "e647c34e4d90740d22ee2a55ba0f33e2";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={dto.City},&units=metric&appid={idOpenWeather}";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                idOpenWeather = json;

                WeatherResponceRootDto weatherResult = new JavaScriptSerializer().Deserialize<WeatherResponceRootDto>(json);
            }

                return null;
        }
    }
}
