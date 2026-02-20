using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Enter a 9 letter word, made of 3 parts (E.g. TomTheDog): ");
		string str = Console.ReadLine();
		
		Console.WriteLine($"Substring 1 = {str.Substring(0, 3)}");
		Console.WriteLine($"Substring 2 = {str.Substring(3, 3)}");
		Console.WriteLine($"Substring 3 = {str.Substring(6, 3)}");
		
		// Extension
		Console.WriteLine("Write a 10 letter word, made up of (1, 2, 3, and then 4 letters)");
		Console.Write("10 letter word (E.g. IAmTheBoss): ");
		string str2 = Console.ReadLine();
		
		Console.WriteLine($"Substring 1 = {str2.Substring(0, 1)}");
		Console.WriteLine($"Substring 2 = {str2.Substring(1, 2)}");
		Console.WriteLine($"Substring 3 = {str2.Substring(3, 3)}");
		Console.WriteLine($"Substring 4 = {str2.Substring(6, 4)}");
		
		// Extension 2
		string invert = string.Empty;
		for(int i = str.Length; i > 0; i--) {
			invert += str[i - 1];
		}
		
		Console.WriteLine($"Inverted 9 letter string: {invert}");
	}
}