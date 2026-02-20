using System;

public class Program
{
	public static void Main()
	{
		// Normal
		for(int i = 10; i >= 0; i--) {
			Console.WriteLine($"The rocket will launch in {i} second{(i != 1 ? "s" : "")}");
		}
		
		Console.WriteLine("Rocket Launched!");
		
		// Extension
		Console.Write("Input a sentence:  ");
		string sentence = Console.ReadLine();
		for(int i = 0; i < sentence.Length; i++)
			Console.WriteLine(sentence[i].ToString());
		
		// Reversed
		for(int i = sentence.Length - 1; i >= 0; i--)
			Console.WriteLine(sentence[i].ToString());
	}
}