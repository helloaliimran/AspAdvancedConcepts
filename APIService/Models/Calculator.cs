﻿namespace APIService.Models
{
	public class Calculator : ICalculator
	{
		public int Sum(int x, int y)
		{
			return x + y;
		}
	}
}
