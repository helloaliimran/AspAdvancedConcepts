using APIService.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

		private readonly ILogger<WeatherForecastController> _logger;
		private readonly ICalculator _calculator;
		public WeatherForecastController(ILogger<WeatherForecastController> logger, ICalculator calculator)
		{
			_logger = logger;
			_calculator=calculator;

		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}

		[HttpGet(template: "SUM")]
		public float Sum(int A, int B)
		{
			return _calculator.Sum(A, B);
		}

	}
}