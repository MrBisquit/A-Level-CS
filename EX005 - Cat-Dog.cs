using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Are you booking in a (C)at or a (D)og? (C/D) ");
		char animal = Console.ReadLine().ToUpper()[0];
		if(animal != 'C' && animal != 'D') {
			Console.WriteLine("Invalid option");
			return;
		}
		
		float cost = 0;
		int days = 0;
		
		Console.Write($"How many days are you booking for {(animal == 'C' ? "cat" : "dog")} for? ");
		days = int.Parse(Console.ReadLine());
		
		switch(animal) {
			case 'C':
				{
					Console.Write("Would you like (G)old or (S)ilver? (G/S) ");
					char package = Console.ReadLine().ToUpper()[0];
					if(package != 'G' && package != 'S') {
						Console.WriteLine("Invalid option");
						return;
					}
					
					cost = 20 * days;
					
					switch(package) {
						case 'G':
							cost *= 1.25f;
							Console.WriteLine($"The cat gold package will be £{cost}");
							break;
						case 'S':
							Console.WriteLine($"The cat silver package will be £{cost}");
							break;
					}
				}
				break;
			case 'D':
				{
					Console.Write("Would you like (P)latinum or (G)old? (P/G) ");
					char package = Console.ReadLine().ToUpper()[0];
					if(package != 'G' && package != 'S') {
						Console.WriteLine("Invalid option");
						return;
					}
					
					cost = 20 * days;
					
					switch(package) {
						case 'P':
							cost *= 1.25f;
							Console.WriteLine($"The dog platinum package will be £{cost}");
							break;
						case 'G':
							Console.WriteLine($"The dog gold package will be £{cost}");
							break;
					}
				}
				break;
		}
	}
}