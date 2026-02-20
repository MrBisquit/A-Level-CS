using System;
					
public class Program
{
	public static void Main()
	{
		string[,] airports = {
			{ "BCN", "Barcelona International" },
			{ "DUB", "Dublin" },
			{ "LIS", "Lisbon" },
			{ "LHR", "London Heathrow" },
			{ "CDG", "Paris, Charles De Gaulle" },
			{ "PRG", "Prague" },
			{ "RKV", "Reykjavik" },
			{ "FCO", "Rome, Fiumicino" }
		};
		
		Console.Write("Please enter an airport code: ");
		string code = Console.ReadLine();
		
		for(int i = 0; i < airports.Length; i++) {
			if(airports[i, 0] == code) {
				Console.WriteLine(airports[i, 1]);	
				return;
			}
		}
		
		Console.WriteLine("Airport not found");
	}
}