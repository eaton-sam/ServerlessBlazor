using ServerlessBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Text.Json;

namespace ServerlessBlazor.Server.Services
{
    public class FileWeatherForecastService : IWeatherForecastService
    {
        public FileWeatherForecastService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public async Task<WeatherForecast[]> GetForeCasts()
        {
            using var stream = WebHostEnvironment.WebRootFileProvider.GetFileInfo("sample-data/weather.json").CreateReadStream();
            return await JsonSerializer.DeserializeAsync<WeatherForecast[]>(stream);
        }
    }
}
