using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ServerlessBlazor.Shared;
using System.Net.Http.Json;

namespace ServerlessBlazor.Client.Services
{
    public class HttpWeatherForecastService : IWeatherForecastService
    {
        public HttpClient HttpClient { get; }

        public HttpWeatherForecastService(HttpClient httpClient) {
            HttpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetForeCasts()
        {
            return await HttpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}
