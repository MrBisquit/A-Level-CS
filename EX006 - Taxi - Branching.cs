using System;
					
public class Program
{
	public static void Main()
	{
		int people = 0;
		int miles = 0;
		float discount = 0f;
		float cost = 0f;
		
		Console.Write("How many people are travelling together? ");
		people = int.Parse(Console.ReadLine());
		
		Console.Write("How long is your journey in miles? ");
		miles = int.Parse(Console.ReadLine());
		
		if(people >= 4 && miles > 5)
			discount = 0.1f;
		else if(people == 2 && people == 3 && miles > 5)
			discount += 0.05f;
		
		cost = 6f * miles;
		cost *= discount + 1;
		
		Console.WriteLine($"The {miles} mile journey will be £{cost} with a {discount * 100}% discount");
	}
}