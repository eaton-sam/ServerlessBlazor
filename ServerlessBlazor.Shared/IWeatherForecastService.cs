using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServerlessBlazor.Shared
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForeCasts();
    }
}
