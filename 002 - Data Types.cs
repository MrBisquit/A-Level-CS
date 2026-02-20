using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{		
		List<string> names = new List<string>();
		List<double> prices = new List<double>();
		
		double overall = 0.0;
		
		Console.Write("Total Products: ");
		int total = int.Parse(Console.ReadLine());
		
		for(int i = 0; i < total; i++)
		{
			Console.Write($"Product {i + 1} Name: ");
			names.Add((string)Console.ReadLine());
			
			Console.Write($"Product {i + 1} Price: £");
			prices.Add(double.Parse(Console.ReadLine()));
			
			Console.Write("\n");
		}
		
		for(int i = 0; i < total; i++) {
			overall += prices[i];
			Console.WriteLine($"{names[i]} = £{prices[i]}");
		}
		
		Console.WriteLine($"Total Cost = £{overall}");
	}
}