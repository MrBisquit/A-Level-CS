using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World!");
		
		// Define variables
		string what = "What's happening?";
		string first = string.Empty;
		string last = string.Empty;
		
		Console.WriteLine(what);
		
		// Ask for inputs
		Console.Write("\nWhat's your first name? ");
		first = Console.ReadLine();
		
		Console.Write("\nWhat's your last name? ");
		last = Console.ReadLine();
		
		// Output results
		Console.WriteLine($"\nNice to meet you {first} {last}!");
	}
}