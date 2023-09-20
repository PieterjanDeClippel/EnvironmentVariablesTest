using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConfiguration configuration;
        public WeatherForecastController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
            
        [HttpGet(Name = "GetWeatherForecast")]
        public string? Get()
        {
            return configuration.GetValue<string>("Test");
        }
    }
}