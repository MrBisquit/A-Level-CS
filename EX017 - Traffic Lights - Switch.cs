using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Enter a colour combination: ");
		string colour = Console.ReadLine();
		
		switch(colour.ToLower()) {
			case "red":
			case "amber":
				Console.WriteLine("Stop");
				break;
			case "flashing amber":
			case "green":
				Console.WriteLine("Go");
				break;
			default:
				Console.WriteLine("Please enter a valid colour combination");
				break;
		}
	}
}