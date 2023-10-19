
using ShopTARge22.Core.Dto;

namespace ShopTARge22.Core.ServiceInterface
{
    public class IWeatherForecastServices
    {
        WeatherResponceRootDto GetForecast(string city);
    }
}
