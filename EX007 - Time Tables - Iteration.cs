using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Which times table would you like to output? ");
		int table = int.Parse(Console.ReadLine());
		Console.Write("How far would you like to go? ");
		int length = int.Parse(Console.ReadLine());
		
		int padding = 4;
		
		for(int i = 0; i < length; i++) {
			Console.Write((i + 1).ToString().PadRight(padding, ' '));
			Console.Write("*".PadRight(padding, ' '));
			Console.Write(table.ToString().PadRight(padding, ' '));
			Console.Write("=".PadRight(padding, ' '));
			Console.Write(((i + 1) * table).ToString().PadRight(padding, ' '));
			Console.WriteLine();
		}
	}
}