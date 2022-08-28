// Make a calculator

using System;

namespace Calculators
{
	public class Calculator
	{
		public double Number01 { get; set; }
		public double Number02 { get; set; }
		
		public Calculator(double number01, double number02)
		{
			Number01 = number01;
			Number02 = number02;
		}
		
		public double AddNumbers()
		{
			return this.Number01 + this.Number02;
		}
		
		public double MultiplyNumbers()
		{
			return this.Number01 * this.Number02;
		}
		
		public double FirstRaisedToSecond()
		{
			double answer = this.Number01;
			for ( int i = 0; i < this.Number02 - 1; i++ )
			{
				answer *= this.Number01;
			}
			return answer;
		}
		
		public double SecondRaisedToFirst()
		{
			double answer = this.Number02;
			for ( int i = 0; i < this.Number01 - 1; i++ )
			{
				answer *= this.Number02;
			}
			return answer;
		}
	}
	
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your first number: ");
			double firstEntry = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter your second number: ");
			double secondEntry = Convert.ToDouble(Console.ReadLine());
			
			var firstPair = new Calculator(firstEntry, secondEntry);
			Console.WriteLine("The result of adding " + firstEntry + " + " + secondEntry + " is: " + firstPair.AddNumbers());
			Console.WriteLine("The result of multiplying " + firstEntry + " * " + secondEntry + " is: " + firstPair.MultiplyNumbers());
			Console.WriteLine("The result of raising " + firstEntry + " to the " + secondEntry + " is: " + firstPair.FirstRaisedToSecond());
			Console.WriteLine("The result of raising " + secondEntry + " to the " + firstEntry + " is: " + firstPair.SecondRaisedToFirst());
		}
	}
}