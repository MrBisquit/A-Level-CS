using System;
					
public class Program
{
	public static void Main()
	{
		int 	currentFuelLevel 			= 10;
		int 	tankCapacity 				= 55;
		double 	unleadedPrice 				= 1.17;
		double 	superUnleadedPrice 			= 1.27;
		double 	dieselPrice 				= 1.21;
		double 	dieselPremiumPrice 			= 1.34;
		double 	pricePerLitre 				= 0;
		//string 	fuelChoice 					= "";
		//string 	fillTank 					= "";
		double 	quantityNeeded 				= 0;
		double 	cost						= 0;
		bool 	valid 						= false;
		
		string[] fuelNames = { "Unleaded", "Super Unleaded", "Diesel", "Diesel Premium" };
		double[] prices = { unleadedPrice, superUnleadedPrice, dieselPrice, dieselPremiumPrice };
		
		Console.WriteLine("You have {0} litres left in your tank\n", currentFuelLevel);
		
		for(int i = 0; i < fuelNames.Length; i++)
			Console.WriteLine($"{fuelNames[i].PadRight(15)} £{prices[i].ToString("F2")}");
		Console.Write("What fuel do you require? (A, B, C, or D)? (A/B/C/D): ");
		char option = Console.ReadLine().ToUpper()[0];
		
		Console.Write("Do you want to fill up to tank capacity? (Y/N) ");
		bool fillToCapacity = Console.ReadLine().ToUpper()[0] == 'Y';
		
		if(fillToCapacity) {
			quantityNeeded = (double)tankCapacity - (double)currentFuelLevel;
		} else {
			Console.Write("How many litres of fuel do you require? ");
			
			if((quantityNeeded = double.Parse(Console.ReadLine())) < 0) {
				Console.WriteLine("Cannot be a negative number");
				Environment.Exit(1);
			}
		}
		
		
	}
}