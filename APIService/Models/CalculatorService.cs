namespace APIService.Models
{
	public class CalculatorService : ICalculator
	{
		public int Sum(int x, int y)
		{
			return x * y;
		}
	}
}
