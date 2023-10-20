using APIService.Models;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace MyTestCases
{
	public class UnitTest1
	{
		private  ICalculator _calculator;

		[Theory]
		[InlineData(1, 1, 2)]
		[InlineData(4, 4, 8)]
		[InlineData(1, 2, 3)]
		public void Test1(int i, int j, int expected)
		{
			//Arange
			var services = new ServiceCollection();
			services.AddTransient<ICalculator, Calculator>();
			var serviceProvider = services.BuildServiceProvider();
			_calculator = serviceProvider.GetService<ICalculator>();

			//Act
			var result =_calculator.Sum(i, j);

			//Assert
			result.Should().Be(expected);
		}
	}
}