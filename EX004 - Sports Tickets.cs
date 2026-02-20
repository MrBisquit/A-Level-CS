using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Would you like either the (L)ower or (U)pper tier? (L/U) ");
		char tier = Console.ReadLine().ToUpper()[0];
		if(tier != 'L' && tier != 'U') {
			Console.WriteLine("Invalid tier");
			return;
		}
		
		Console.Write("What is your age (in years): ");
		int age = int.Parse(Console.ReadLine());
		
		int price = 0;
		if(tier == 'L') {
			if(age > 65)
				price = 10;
			if(age < 16)
				price = 5;
			else
				price = 20;
		} else
			price = 20;
		
		if(tier == 'U')
			price += 5;
		
		Console.WriteLine($"Your ticket costs £{price}");
	}
}