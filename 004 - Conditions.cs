using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Would you like to add ('+'), subtract ('-'), multiply ('*'), or divide ('/')? ");
		char option = Console.ReadLine()[0];
		
		float a = 0;
		float b = 0;
		
		try {
			Console.Write("First number: ");
			a = float.Parse(Console.ReadLine());
			
			Console.Write("Second number: ");
			b = float.Parse(Console.ReadLine());
		} catch (FormatException) {
			Console.WriteLine("Invalid input, first or second value entered is invalid");
		}
		
		if(option == '+') {
			Console.WriteLine($"{a} + {b} = {a + b}");
		} else if(option == '-') {
			Console.WriteLine($"{a} - {b} = {a - b}");
		} else if(option == '*') {
			Console.WriteLine($"{a} * {b} = {a * b}");
		} else if(option == '/') {
			if(a == 0 || b == 0)
				Console.WriteLine("Input not allowed, first or second value entered is 0");
			else
				Console.WriteLine($"{a} / {b} = {a / b}");
		} else {
			Console.WriteLine("Invalid input, the option entered is invalid");
		}
	}
}