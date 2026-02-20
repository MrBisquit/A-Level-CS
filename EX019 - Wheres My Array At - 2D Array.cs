using System;
					
public class Program
{
	public static void Main()
	{
		string[,] names = new string[5, 2];
		
		for(int i = 0; i < 5; i++) {
			Console.Write($"Player {i + 1} name: ");
			string name = Console.ReadLine();
			names[i, 0] = name;
		}
		
		Console.WriteLine("Ascending Order");
		for(int i = 0; i < 5; i++) {
			Console.WriteLine($"{i + 1}: {names[i, 0]}");	
		}
		
		Console.WriteLine("Descending Order");
		for(int i = 0; i < 5; i++) {
			Console.WriteLine($"{i + 1}: {names[5 - i - 1, 0]}");
		}
	}
}