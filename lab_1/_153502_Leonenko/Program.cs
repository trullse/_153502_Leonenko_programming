using System;

namespace _153502_Leonenko
{
	public class Program
	{
		public static void Main(string[] args)
        {
			Console.WriteLine("Enter two numbers: ");
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
			int res = a / b;
			Console.WriteLine($"Result of division is {res}");
        }
	}
}