using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Please enter the discounted price: ");
		double discounted = double.Parse(Console.ReadLine());
		Console.Write("Please enter the discount (%): ");
		double discount = double.Parse(Console.ReadLine());
		
		double original = (discounted / (100 - discount)) * 100;
		
		Console.WriteLine($"£{original}");
	}
}